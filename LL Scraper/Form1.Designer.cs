namespace LL_Scraper
{
	partial class Form1
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			tbSingleGameURL = new TextBox();
			listGamesToProcess = new ListBox();
			lblSingleGameURL = new Label();
			lblGamesToProcess = new Label();
			btnAddGameByURL = new Button();
			tbFormattedText = new TextBox();
			btnCopy = new Button();
			lblFormattedText = new Label();
			btnProcess = new Button();
			btnClearFormattedText = new Button();
			btnClearAddedURLs = new Button();
			btnAddSeasonByURL = new Button();
			lblGameRange = new Label();
			nudGameByURLMin = new NumericUpDown();
			lblTo = new Label();
			nudGameByURLMax = new NumericUpDown();
			btnSortAddedURLs = new Button();
			lblOr = new Label();
			lblAddGameByNumber = new Label();
			lblSeason = new Label();
			nudSeasonByNumber = new NumericUpDown();
			nudGameByNumber = new NumericUpDown();
			lblGame = new Label();
			btnAddSeasonByNumber = new Button();
			btnAddGameByNumber = new Button();
			grpAddGames = new GroupBox();
			grpGamesToProcess = new GroupBox();
			grpProcessedGames = new GroupBox();
			toolTip1 = new ToolTip(components);
			((System.ComponentModel.ISupportInitialize)nudGameByURLMin).BeginInit();
			((System.ComponentModel.ISupportInitialize)nudGameByURLMax).BeginInit();
			((System.ComponentModel.ISupportInitialize)nudSeasonByNumber).BeginInit();
			((System.ComponentModel.ISupportInitialize)nudGameByNumber).BeginInit();
			grpAddGames.SuspendLayout();
			grpGamesToProcess.SuspendLayout();
			grpProcessedGames.SuspendLayout();
			SuspendLayout();
			// 
			// tbSingleGameURL
			// 
			tbSingleGameURL.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			tbSingleGameURL.Location = new Point(182, 22);
			tbSingleGameURL.Name = "tbSingleGameURL";
			tbSingleGameURL.Size = new Size(582, 23);
			tbSingleGameURL.TabIndex = 0;
			tbSingleGameURL.KeyDown += tbSingleGameURL_KeyDown;
			// 
			// listGamesToProcess
			// 
			listGamesToProcess.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			listGamesToProcess.FormattingEnabled = true;
			listGamesToProcess.ItemHeight = 15;
			listGamesToProcess.Location = new Point(182, 22);
			listGamesToProcess.Name = "listGamesToProcess";
			listGamesToProcess.Size = new Size(582, 124);
			listGamesToProcess.TabIndex = 1;
			listGamesToProcess.KeyDown += listURLsToProcess_KeyDown;
			// 
			// lblSingleGameURL
			// 
			lblSingleGameURL.AutoSize = true;
			lblSingleGameURL.Location = new Point(79, 25);
			lblSingleGameURL.Name = "lblSingleGameURL";
			lblSingleGameURL.Size = new Size(100, 15);
			lblSingleGameURL.TabIndex = 2;
			lblSingleGameURL.Text = "Single Game URL:";
			// 
			// lblGamesToProcess
			// 
			lblGamesToProcess.AutoSize = true;
			lblGamesToProcess.Location = new Point(79, 25);
			lblGamesToProcess.Name = "lblGamesToProcess";
			lblGamesToProcess.Size = new Size(100, 15);
			lblGamesToProcess.TabIndex = 3;
			lblGamesToProcess.Text = "Games to Process";
			// 
			// btnAddGameByURL
			// 
			btnAddGameByURL.Location = new Point(182, 55);
			btnAddGameByURL.Name = "btnAddGameByURL";
			btnAddGameByURL.Size = new Size(127, 23);
			btnAddGameByURL.TabIndex = 4;
			btnAddGameByURL.Text = "Add just this game";
			btnAddGameByURL.UseVisualStyleBackColor = true;
			btnAddGameByURL.Click += btnAddGameByURL_Click;
			// 
			// tbFormattedText
			// 
			tbFormattedText.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			tbFormattedText.Location = new Point(182, 51);
			tbFormattedText.Multiline = true;
			tbFormattedText.Name = "tbFormattedText";
			tbFormattedText.ScrollBars = ScrollBars.Vertical;
			tbFormattedText.Size = new Size(582, 144);
			tbFormattedText.TabIndex = 5;
			toolTip1.SetToolTip(tbFormattedText, "The question data from the processed games, designed to be paste-able into a spreadsheet");
			// 
			// btnCopy
			// 
			btnCopy.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
			btnCopy.Location = new Point(688, 201);
			btnCopy.Name = "btnCopy";
			btnCopy.Size = new Size(76, 23);
			btnCopy.TabIndex = 6;
			btnCopy.Text = "Copy";
			toolTip1.SetToolTip(btnCopy, "Copy the text from the processed games text box");
			btnCopy.UseVisualStyleBackColor = true;
			btnCopy.Click += btnCopy_Click;
			// 
			// lblFormattedText
			// 
			lblFormattedText.AutoSize = true;
			lblFormattedText.Location = new Point(55, 54);
			lblFormattedText.Name = "lblFormattedText";
			lblFormattedText.Size = new Size(121, 15);
			lblFormattedText.TabIndex = 7;
			lblFormattedText.Text = "Processed Game Data";
			// 
			// btnProcess
			// 
			btnProcess.Location = new Point(182, 152);
			btnProcess.Name = "btnProcess";
			btnProcess.Size = new Size(76, 23);
			btnProcess.TabIndex = 8;
			btnProcess.Text = "Process";
			toolTip1.SetToolTip(btnProcess, "Process all games in the above list");
			btnProcess.UseVisualStyleBackColor = true;
			btnProcess.Click += btnProcess_Click;
			// 
			// btnClearFormattedText
			// 
			btnClearFormattedText.Anchor = AnchorStyles.Top | AnchorStyles.Right;
			btnClearFormattedText.Location = new Point(688, 22);
			btnClearFormattedText.Name = "btnClearFormattedText";
			btnClearFormattedText.Size = new Size(76, 23);
			btnClearFormattedText.TabIndex = 9;
			btnClearFormattedText.Text = "Clear";
			btnClearFormattedText.UseVisualStyleBackColor = true;
			btnClearFormattedText.Click += btnClearFormattedText_Click;
			// 
			// btnClearAddedURLs
			// 
			btnClearAddedURLs.Anchor = AnchorStyles.Top | AnchorStyles.Right;
			btnClearAddedURLs.Location = new Point(688, 152);
			btnClearAddedURLs.Name = "btnClearAddedURLs";
			btnClearAddedURLs.Size = new Size(76, 23);
			btnClearAddedURLs.TabIndex = 10;
			btnClearAddedURLs.Text = "Clear";
			btnClearAddedURLs.UseVisualStyleBackColor = true;
			btnClearAddedURLs.Click += btnClearAddedURLs_Click;
			// 
			// btnAddSeasonByURL
			// 
			btnAddSeasonByURL.Location = new Point(315, 55);
			btnAddSeasonByURL.Name = "btnAddSeasonByURL";
			btnAddSeasonByURL.Size = new Size(205, 23);
			btnAddSeasonByURL.TabIndex = 11;
			btnAddSeasonByURL.Text = "Add all games from this season";
			btnAddSeasonByURL.UseVisualStyleBackColor = true;
			btnAddSeasonByURL.Click += btnAddSeasonByURL_Click;
			// 
			// lblGameRange
			// 
			lblGameRange.AutoSize = true;
			lblGameRange.Location = new Point(535, 59);
			lblGameRange.Name = "lblGameRange";
			lblGameRange.Size = new Size(97, 15);
			lblGameRange.TabIndex = 12;
			lblGameRange.Text = "Include game #'s";
			// 
			// nudGameByURLMin
			// 
			nudGameByURLMin.Location = new Point(638, 55);
			nudGameByURLMin.Maximum = new decimal(new int[] { 25, 0, 0, 0 });
			nudGameByURLMin.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
			nudGameByURLMin.Name = "nudGameByURLMin";
			nudGameByURLMin.Size = new Size(48, 23);
			nudGameByURLMin.TabIndex = 13;
			nudGameByURLMin.Value = new decimal(new int[] { 1, 0, 0, 0 });
			// 
			// lblTo
			// 
			lblTo.AutoSize = true;
			lblTo.Location = new Point(692, 59);
			lblTo.Name = "lblTo";
			lblTo.Size = new Size(18, 15);
			lblTo.TabIndex = 14;
			lblTo.Text = "to";
			// 
			// nudGameByURLMax
			// 
			nudGameByURLMax.Location = new Point(716, 55);
			nudGameByURLMax.Maximum = new decimal(new int[] { 25, 0, 0, 0 });
			nudGameByURLMax.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
			nudGameByURLMax.Name = "nudGameByURLMax";
			nudGameByURLMax.Size = new Size(48, 23);
			nudGameByURLMax.TabIndex = 15;
			nudGameByURLMax.Value = new decimal(new int[] { 25, 0, 0, 0 });
			// 
			// btnSortAddedURLs
			// 
			btnSortAddedURLs.Location = new Point(264, 152);
			btnSortAddedURLs.Name = "btnSortAddedURLs";
			btnSortAddedURLs.Size = new Size(76, 23);
			btnSortAddedURLs.TabIndex = 16;
			btnSortAddedURLs.Text = "Sort";
			toolTip1.SetToolTip(btnSortAddedURLs, "Sort games to process by season and then game");
			btnSortAddedURLs.UseVisualStyleBackColor = true;
			btnSortAddedURLs.Click += btnSortAddedURLs_Click;
			// 
			// lblOr
			// 
			lblOr.AutoSize = true;
			lblOr.Location = new Point(153, 96);
			lblOr.Name = "lblOr";
			lblOr.Size = new Size(23, 15);
			lblOr.TabIndex = 17;
			lblOr.Text = "OR";
			// 
			// lblAddGameByNumber
			// 
			lblAddGameByNumber.AutoSize = true;
			lblAddGameByNumber.Location = new Point(0, 134);
			lblAddGameByNumber.Name = "lblAddGameByNumber";
			lblAddGameByNumber.Size = new Size(175, 15);
			lblAddGameByNumber.TabIndex = 18;
			lblAddGameByNumber.Text = "Select Season and Game to add:";
			// 
			// lblSeason
			// 
			lblSeason.AutoSize = true;
			lblSeason.Location = new Point(185, 163);
			lblSeason.Name = "lblSeason";
			lblSeason.Size = new Size(44, 15);
			lblSeason.TabIndex = 19;
			lblSeason.Text = "Season";
			// 
			// nudSeasonByNumber
			// 
			nudSeasonByNumber.Location = new Point(235, 161);
			nudSeasonByNumber.Maximum = new decimal(new int[] { 103, 0, 0, 0 });
			nudSeasonByNumber.Minimum = new decimal(new int[] { 60, 0, 0, 0 });
			nudSeasonByNumber.Name = "nudSeasonByNumber";
			nudSeasonByNumber.Size = new Size(48, 23);
			nudSeasonByNumber.TabIndex = 20;
			toolTip1.SetToolTip(nudSeasonByNumber, "Only seasons 60 and onward will work with the parsing logic in this program");
			nudSeasonByNumber.Value = new decimal(new int[] { 60, 0, 0, 0 });
			// 
			// nudGameByNumber
			// 
			nudGameByNumber.Location = new Point(235, 132);
			nudGameByNumber.Maximum = new decimal(new int[] { 25, 0, 0, 0 });
			nudGameByNumber.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
			nudGameByNumber.Name = "nudGameByNumber";
			nudGameByNumber.Size = new Size(48, 23);
			nudGameByNumber.TabIndex = 22;
			nudGameByNumber.Value = new decimal(new int[] { 1, 0, 0, 0 });
			// 
			// lblGame
			// 
			lblGame.AutoSize = true;
			lblGame.Location = new Point(185, 134);
			lblGame.Name = "lblGame";
			lblGame.Size = new Size(38, 15);
			lblGame.TabIndex = 21;
			lblGame.Text = "Game";
			// 
			// btnAddSeasonByNumber
			// 
			btnAddSeasonByNumber.Location = new Point(289, 161);
			btnAddSeasonByNumber.Name = "btnAddSeasonByNumber";
			btnAddSeasonByNumber.Size = new Size(205, 23);
			btnAddSeasonByNumber.TabIndex = 24;
			btnAddSeasonByNumber.Text = "Add all games from this season";
			btnAddSeasonByNumber.UseVisualStyleBackColor = true;
			btnAddSeasonByNumber.Click += btnAddSeasonByNumber_Click;
			// 
			// btnAddGameByNumber
			// 
			btnAddGameByNumber.Location = new Point(289, 132);
			btnAddGameByNumber.Name = "btnAddGameByNumber";
			btnAddGameByNumber.Size = new Size(205, 23);
			btnAddGameByNumber.TabIndex = 23;
			btnAddGameByNumber.Text = "Add just this game";
			btnAddGameByNumber.UseVisualStyleBackColor = true;
			btnAddGameByNumber.Click += btnAddGameByNumber_Click;
			// 
			// grpAddGames
			// 
			grpAddGames.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			grpAddGames.Controls.Add(lblSingleGameURL);
			grpAddGames.Controls.Add(btnAddSeasonByNumber);
			grpAddGames.Controls.Add(tbSingleGameURL);
			grpAddGames.Controls.Add(btnAddGameByNumber);
			grpAddGames.Controls.Add(btnAddGameByURL);
			grpAddGames.Controls.Add(nudGameByNumber);
			grpAddGames.Controls.Add(btnAddSeasonByURL);
			grpAddGames.Controls.Add(lblGame);
			grpAddGames.Controls.Add(lblGameRange);
			grpAddGames.Controls.Add(nudSeasonByNumber);
			grpAddGames.Controls.Add(nudGameByURLMin);
			grpAddGames.Controls.Add(lblSeason);
			grpAddGames.Controls.Add(lblTo);
			grpAddGames.Controls.Add(lblAddGameByNumber);
			grpAddGames.Controls.Add(nudGameByURLMax);
			grpAddGames.Controls.Add(lblOr);
			grpAddGames.Location = new Point(12, 12);
			grpAddGames.Name = "grpAddGames";
			grpAddGames.Size = new Size(770, 202);
			grpAddGames.TabIndex = 25;
			grpAddGames.TabStop = false;
			grpAddGames.Text = "Add Games";
			// 
			// grpGamesToProcess
			// 
			grpGamesToProcess.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			grpGamesToProcess.Controls.Add(listGamesToProcess);
			grpGamesToProcess.Controls.Add(lblGamesToProcess);
			grpGamesToProcess.Controls.Add(btnSortAddedURLs);
			grpGamesToProcess.Controls.Add(btnProcess);
			grpGamesToProcess.Controls.Add(btnClearAddedURLs);
			grpGamesToProcess.Location = new Point(12, 220);
			grpGamesToProcess.Name = "grpGamesToProcess";
			grpGamesToProcess.Size = new Size(770, 187);
			grpGamesToProcess.TabIndex = 26;
			grpGamesToProcess.TabStop = false;
			grpGamesToProcess.Text = "Games to Process";
			// 
			// grpProcessedGames
			// 
			grpProcessedGames.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			grpProcessedGames.Controls.Add(lblFormattedText);
			grpProcessedGames.Controls.Add(tbFormattedText);
			grpProcessedGames.Controls.Add(btnClearFormattedText);
			grpProcessedGames.Controls.Add(btnCopy);
			grpProcessedGames.Location = new Point(12, 413);
			grpProcessedGames.Name = "grpProcessedGames";
			grpProcessedGames.Size = new Size(770, 230);
			grpProcessedGames.TabIndex = 27;
			grpProcessedGames.TabStop = false;
			grpProcessedGames.Text = "ProcessedGames";
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(794, 655);
			Controls.Add(grpProcessedGames);
			Controls.Add(grpGamesToProcess);
			Controls.Add(grpAddGames);
			Icon = (Icon)resources.GetObject("$this.Icon");
			MinimumSize = new Size(810, 694);
			Name = "Form1";
			Text = "LL Scraper";
			Load += Form1_Load;
			((System.ComponentModel.ISupportInitialize)nudGameByURLMin).EndInit();
			((System.ComponentModel.ISupportInitialize)nudGameByURLMax).EndInit();
			((System.ComponentModel.ISupportInitialize)nudSeasonByNumber).EndInit();
			((System.ComponentModel.ISupportInitialize)nudGameByNumber).EndInit();
			grpAddGames.ResumeLayout(false);
			grpAddGames.PerformLayout();
			grpGamesToProcess.ResumeLayout(false);
			grpGamesToProcess.PerformLayout();
			grpProcessedGames.ResumeLayout(false);
			grpProcessedGames.PerformLayout();
			ResumeLayout(false);
		}

		#endregion

		private TextBox tbSingleGameURL;
		private ListBox listGamesToProcess;
		private Label lblSingleGameURL;
		private Label lblGamesToProcess;
		private Button btnAddGameByURL;
		private TextBox tbFormattedText;
		private Button btnCopy;
		private Label lblFormattedText;
		private Button btnProcess;
		private Button btnClearFormattedText;
		private Button btnClearAddedURLs;
		private Button btnAddSeasonByURL;
		private Label lblGameRange;
		private NumericUpDown nudGameByURLMin;
		private Label lblTo;
		private NumericUpDown nudGameByURLMax;
		private Button btnSortAddedURLs;
		private Label lblOr;
		private Label lblAddGameByNumber;
		private Label lblSeason;
		private NumericUpDown nudSeasonByNumber;
		private NumericUpDown nudGameByNumber;
		private Label lblGame;
		private Button btnAddSeasonByNumber;
		private Button btnAddGameByNumber;
		private GroupBox grpAddGames;
		private GroupBox grpGamesToProcess;
		private GroupBox grpProcessedGames;
		private ToolTip toolTip1;
	}
}
