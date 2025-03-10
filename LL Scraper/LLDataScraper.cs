using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace LL_Scraper
{
	internal static class LLDataScraper
	{
		public static async Task<bool> isValidWebPage(string url)
		{
			try
			{
				using HttpClient client = new HttpClient();
				HttpResponseMessage response = await client.GetAsync(url);

				// Consider 200-299 as valid web page responses
				return response.IsSuccessStatusCode;
			}
			catch
			{
				return false; // Invalid URL or network error
			}
		}

		public static async Task<List<FullQuestion>> GetSingleMatch(string url)
		{
			var fullQuestions = new List<FullQuestion>();

			using HttpClient client = new HttpClient();
			string html = await client.GetStringAsync(url);

			HtmlAgilityPack.HtmlDocument doc = new HtmlAgilityPack.HtmlDocument();
			doc.LoadHtml(html);

			var questionsNode = doc.DocumentNode.ChildNodes[2].ChildNodes[3].ChildNodes[5].ChildNodes[3].ChildNodes[1].ChildNodes[29].ChildNodes[1];
			var metricsNode = doc.DocumentNode.ChildNodes[2].ChildNodes[3].ChildNodes[5].ChildNodes[3].ChildNodes[1].ChildNodes[29].ChildNodes[3];

			var questionsHTML = await GetElementsByClass(questionsNode, "ind-Q20 dont-break-out");
			var answersHTML = await GetElementsByClass(questionsNode, "answer3");

			var questions = new List<string>();
			var answers = new List<string>();
			var categories = new List<string>();

			var percentages = await GetFullDayPercentages(metricsNode);

			foreach (var questionHTML in questionsHTML)
			{
				var inner = questionHTML.InnerHtml;
				var splitQuestion = inner.Trim().Split(" - ");
				var category = HttpUtility.HtmlDecode(splitQuestion[0].Split("</span>")[1].Trim().Replace("<i>", "").Replace("</i>", ""));
				var question = HttpUtility.HtmlDecode(splitQuestion[1].Trim().Replace("<i>", "").Replace("</i>", ""));

				categories.Add(category);
				questions.Add(question);
			}

			foreach (var answer in answersHTML)
			{
				answers.Add(HttpUtility.HtmlDecode(answer.InnerHtml.Split("px;'>")[1].Split("</div>")[0].Trim()));
			}

			for (int i = 0; i < questions.Count; i++)
			{
				fullQuestions.Add(new FullQuestion(questions[i], answers[i], categories[i], percentages[i]));
			}

			return fullQuestions;
		}

		public static async Task<List<double>> GetFullDayPercentages(HtmlNode node)
		{
			var percentages = new List<double>();

			var cells = node.SelectNodes("//tfoot/tr[1]//td").Take(new Range(2, 8));

			foreach (var cell in cells)
			{
				percentages.Add(double.Parse(cell.InnerHtml));
			}

			return percentages;
		}


		#region Helpers
		private static async Task<HtmlNodeCollection> GetElementsByClass(string url, string className)
		{
			using HttpClient client = new HttpClient();
			string html = await client.GetStringAsync(url);

			HtmlAgilityPack.HtmlDocument doc = new HtmlAgilityPack.HtmlDocument();
			doc.LoadHtml(html);

			return await GetElementsByClass(doc.DocumentNode, className);
		}

		private static async Task<HtmlNodeCollection> GetElementsByClass(HtmlAgilityPack.HtmlNode node, string className)
		{
			return node.SelectNodes($"//*[@class=\"{className}\"]");
		}

		#endregion
	}

	public struct FullQuestion
	{
		public string question;
		public string answer;
		public string category;
		public double percentCorrect;

		public FullQuestion(string q, string a, string c, double p)
		{
			question = q;
			answer = a;
			category = c;
			percentCorrect = p;
		}

		public FullQuestion(string q, string a, string c)
		{
			question = q;
			answer = a;
			category = c;
			percentCorrect = 0;
		}
	}
}
