using HtmlAgilityPack;
using System.Collections.Generic;
using System.ComponentModel;
using System.Web;
using System.Windows.Forms;

namespace LL_Scraper
{
	public partial class Form1 : Form
	{
		private BindingList<string> GamesToProcess = new BindingList<string>();
		private const string BaseGameURL = "https://www.learnedleague.com/match.php?";
		private const int minGameNumber = 1;
		private const int maxGameNumber = 25;

		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			listGamesToProcess.DataSource = GamesToProcess;
		}

		private async void btnProcess_Click(object sender, EventArgs e)
		{
			Cursor = Cursors.WaitCursor;
			var fullQuestions = new List<FullQuestion>();
			foreach (var url in GamesToProcess)
			{
				fullQuestions.AddRange(await LLDataScraper.GetSingleMatch(url));
			}

			foreach (var fullQuestion in fullQuestions)
			{
				tbFormattedText.AppendText($"{fullQuestion.category}\t{fullQuestion.question}\t{fullQuestion.percentCorrect}\t{fullQuestion.answer}\r\n");
			}
			Cursor = Cursors.Default;
		}

		private async void btnAddGameByURL_Click(object sender, EventArgs e)
		{
			Cursor = Cursors.WaitCursor;
			await AddSingleGame(tbSingleGameURL.Text);
			Cursor = Cursors.Default;
		}

		private async void btnAddSeasonByURL_Click(object sender, EventArgs e)
		{
			var singleGameURL = tbSingleGameURL.Text;
			var seasonBaseURL = singleGameURL.Substring(0, singleGameURL.IndexOf('&') + 1);
			Cursor = Cursors.WaitCursor;
			for (int i = (int)nudGameByURLMin.Value; i <= (int)nudGameByURLMax.Value; i++)
			{
				await AddSingleGame(seasonBaseURL + i.ToString());
			}
			SortAddedURLs();
			Cursor = Cursors.Default;
		}

		private async void btnAddGameByNumber_Click(object sender, EventArgs e)
		{
			Cursor = Cursors.WaitCursor;
			await AddSingleGame($"{BaseGameURL}{nudSeasonByNumber.Value}&{nudGameByNumber.Value}");
			Cursor = Cursors.Default;
		}

		private async void btnAddSeasonByNumber_Click(object sender, EventArgs e)
		{
			Cursor = Cursors.WaitCursor;
			for (int i = minGameNumber; i <= maxGameNumber; i++)
			{
				await AddSingleGame($"{BaseGameURL}{nudSeasonByNumber.Value}&{i}");
			}
			SortAddedURLs();
			Cursor = Cursors.Default;
		}

		private async Task AddSingleGame(string URL)
		{
			bool isValid = await LLDataScraper.isValidWebPage(URL);
			if (isValid && !listGamesToProcess.Items.Contains(URL))
			{
				GamesToProcess.Add(URL);
			}
		}

		private void btnClearAddedURLs_Click(object sender, EventArgs e)
		{
			GamesToProcess.Clear();
		}

		private void btnClearFormattedText_Click(object sender, EventArgs e)
		{
			tbFormattedText.Clear();
		}

		private void tbSingleGameURL_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				AddSingleGame(tbSingleGameURL.Text);
			}
		}

		private void btnSortAddedURLs_Click(object sender, EventArgs e)
		{
			SortAddedURLs();
		}

		private void SortAddedURLs()
		{
			var sorted = GamesToProcess.ToList<string>();
			sorted.Sort(new LLURLComparer());
			GamesToProcess.Clear();
			foreach (var url in sorted)
			{
				GamesToProcess.Add(url);
			}
		}

		private class LLURLComparer : IComparer<string>
		{
			public int Compare(string? x, string? y)
			{
				var xQuestionIndex = x.IndexOf('?');
				var xAmpIndex = x.IndexOf('&');
				var yQuestionIndex = y.IndexOf('?');
				var yAmpIndex = y.IndexOf('&');

				var xSeason = int.Parse(x.Substring(xQuestionIndex + 1, xAmpIndex - xQuestionIndex - 1));
				var xGame = int.Parse(x.Substring(xAmpIndex + 1));

				var ySeason = int.Parse(y.Substring(yQuestionIndex + 1, yAmpIndex - yQuestionIndex - 1));
				var yGame = int.Parse(y.Substring(yAmpIndex + 1));


				if (xSeason > ySeason) return 1;
				else if (xSeason < ySeason) return -1;
				else if (xGame > yGame) return 1;
				else if (xGame < yGame) return -1;
				else return 0;
			}
		}

		private void btnCopy_Click(object sender, EventArgs e)
		{
			if (tbFormattedText.Text.Length > 0)
			{
				Clipboard.SetText(tbFormattedText.Text);
			}
		}

		private void listURLsToProcess_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Delete || e.KeyCode == Keys.Back)
			{
				if (listGamesToProcess.SelectedIndex != -1)
				{
					GamesToProcess.RemoveAt(listGamesToProcess.SelectedIndex);
				}
			}
		}
	}
}
