namespace MetrixExtract
{
    partial class FormJson
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormJson));
            this.TxtIssues = new System.Windows.Forms.TextBox();
            this.TxtWorkRates = new System.Windows.Forms.TextBox();
            this.BtnParseFromTextBox = new System.Windows.Forms.Button();
            this.TxtJson = new System.Windows.Forms.TextBox();
            this.TxtColumns = new System.Windows.Forms.TextBox();
            this.TxtAverage = new System.Windows.Forms.TextBox();
            this.BtnLoadAndParseJSON = new System.Windows.Forms.Button();
            this.TxtJSONPath = new System.Windows.Forms.TextBox();
            this.LblJSONPath = new System.Windows.Forms.Label();
            this.BtnParseFromCoded = new System.Windows.Forms.Button();
            this.BtnGetBoards = new System.Windows.Forms.Button();
            this.CboBoards = new System.Windows.Forms.ComboBox();
            this.TxtBoards = new System.Windows.Forms.TextBox();
            this.LblCycleTimes = new System.Windows.Forms.Label();
            this.LblJSON = new System.Windows.Forms.Label();
            this.LblIssues = new System.Windows.Forms.Label();
            this.LblWorkRates = new System.Windows.Forms.Label();
            this.LblBoardsJSON = new System.Windows.Forms.Label();
            this.LblColumns = new System.Windows.Forms.Label();
            this.CboFilters = new System.Windows.Forms.ComboBox();
            this.BtnFilters = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TxtIssues
            // 
            this.TxtIssues.Location = new System.Drawing.Point(12, 160);
            this.TxtIssues.Multiline = true;
            this.TxtIssues.Name = "TxtIssues";
            this.TxtIssues.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TxtIssues.Size = new System.Drawing.Size(484, 92);
            this.TxtIssues.TabIndex = 7;
            // 
            // TxtWorkRates
            // 
            this.TxtWorkRates.Location = new System.Drawing.Point(12, 569);
            this.TxtWorkRates.Multiline = true;
            this.TxtWorkRates.Name = "TxtWorkRates";
            this.TxtWorkRates.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TxtWorkRates.Size = new System.Drawing.Size(484, 115);
            this.TxtWorkRates.TabIndex = 6;
            // 
            // BtnParseFromTextBox
            // 
            this.BtnParseFromTextBox.Location = new System.Drawing.Point(265, 38);
            this.BtnParseFromTextBox.Name = "BtnParseFromTextBox";
            this.BtnParseFromTextBox.Size = new System.Drawing.Size(93, 23);
            this.BtnParseFromTextBox.TabIndex = 5;
            this.BtnParseFromTextBox.Text = "Parse from Txt";
            this.BtnParseFromTextBox.UseVisualStyleBackColor = true;
            this.BtnParseFromTextBox.Click += new System.EventHandler(this.BtnParseFromTextBox_Click);
            // 
            // TxtJson
            // 
            this.TxtJson.Location = new System.Drawing.Point(13, 65);
            this.TxtJson.Multiline = true;
            this.TxtJson.Name = "TxtJson";
            this.TxtJson.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TxtJson.Size = new System.Drawing.Size(483, 76);
            this.TxtJson.TabIndex = 4;
            this.TxtJson.Text = resources.GetString("TxtJson.Text");
            // 
            // TxtColumns
            // 
            this.TxtColumns.Location = new System.Drawing.Point(12, 469);
            this.TxtColumns.Multiline = true;
            this.TxtColumns.Name = "TxtColumns";
            this.TxtColumns.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TxtColumns.Size = new System.Drawing.Size(484, 77);
            this.TxtColumns.TabIndex = 8;
            // 
            // TxtAverage
            // 
            this.TxtAverage.Location = new System.Drawing.Point(12, 268);
            this.TxtAverage.Multiline = true;
            this.TxtAverage.Name = "TxtAverage";
            this.TxtAverage.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TxtAverage.Size = new System.Drawing.Size(484, 182);
            this.TxtAverage.TabIndex = 10;
            // 
            // BtnLoadAndParseJSON
            // 
            this.BtnLoadAndParseJSON.Location = new System.Drawing.Point(313, 12);
            this.BtnLoadAndParseJSON.Name = "BtnLoadAndParseJSON";
            this.BtnLoadAndParseJSON.Size = new System.Drawing.Size(183, 23);
            this.BtnLoadAndParseJSON.TabIndex = 11;
            this.BtnLoadAndParseJSON.Text = "Load and Parse JSON from .txt";
            this.BtnLoadAndParseJSON.UseVisualStyleBackColor = true;
            this.BtnLoadAndParseJSON.Click += new System.EventHandler(this.BtnLoadJSON_Click);
            // 
            // TxtJSONPath
            // 
            this.TxtJSONPath.Location = new System.Drawing.Point(66, 12);
            this.TxtJSONPath.Name = "TxtJSONPath";
            this.TxtJSONPath.Size = new System.Drawing.Size(241, 20);
            this.TxtJSONPath.TabIndex = 12;
            this.TxtJSONPath.Text = "C:\\Users\\Greg\\Desktop\\Delete\\ONJSON.txt";
            // 
            // LblJSONPath
            // 
            this.LblJSONPath.AutoSize = true;
            this.LblJSONPath.Location = new System.Drawing.Point(9, 15);
            this.LblJSONPath.Name = "LblJSONPath";
            this.LblJSONPath.Size = new System.Drawing.Size(51, 13);
            this.LblJSONPath.TabIndex = 13;
            this.LblJSONPath.Text = "File Path:";
            // 
            // BtnParseFromCoded
            // 
            this.BtnParseFromCoded.Location = new System.Drawing.Point(371, 38);
            this.BtnParseFromCoded.Name = "BtnParseFromCoded";
            this.BtnParseFromCoded.Size = new System.Drawing.Size(125, 23);
            this.BtnParseFromCoded.TabIndex = 14;
            this.BtnParseFromCoded.Text = "Parse from Hard Coded";
            this.BtnParseFromCoded.UseVisualStyleBackColor = true;
            this.BtnParseFromCoded.Click += new System.EventHandler(this.BtnParseFromCoded_Click);
            // 
            // BtnGetBoards
            // 
            this.BtnGetBoards.Location = new System.Drawing.Point(502, 12);
            this.BtnGetBoards.Name = "BtnGetBoards";
            this.BtnGetBoards.Size = new System.Drawing.Size(74, 23);
            this.BtnGetBoards.TabIndex = 15;
            this.BtnGetBoards.Text = "Get Boards";
            this.BtnGetBoards.UseVisualStyleBackColor = true;
            this.BtnGetBoards.Click += new System.EventHandler(this.BtnGetBoards_Click);
            // 
            // CboBoards
            // 
            this.CboBoards.FormattingEnabled = true;
            this.CboBoards.Location = new System.Drawing.Point(582, 14);
            this.CboBoards.MaxDropDownItems = 50;
            this.CboBoards.Name = "CboBoards";
            this.CboBoards.Size = new System.Drawing.Size(214, 21);
            this.CboBoards.TabIndex = 16;
            // 
            // TxtBoards
            // 
            this.TxtBoards.Location = new System.Drawing.Point(502, 56);
            this.TxtBoards.Multiline = true;
            this.TxtBoards.Name = "TxtBoards";
            this.TxtBoards.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TxtBoards.Size = new System.Drawing.Size(483, 85);
            this.TxtBoards.TabIndex = 17;
            this.TxtBoards.Text = resources.GetString("TxtBoards.Text");
            // 
            // LblCycleTimes
            // 
            this.LblCycleTimes.AutoSize = true;
            this.LblCycleTimes.Location = new System.Drawing.Point(9, 252);
            this.LblCycleTimes.Name = "LblCycleTimes";
            this.LblCycleTimes.Size = new System.Drawing.Size(67, 13);
            this.LblCycleTimes.TabIndex = 18;
            this.LblCycleTimes.Text = "Cycle Times:";
            // 
            // LblJSON
            // 
            this.LblJSON.AutoSize = true;
            this.LblJSON.Location = new System.Drawing.Point(12, 44);
            this.LblJSON.Name = "LblJSON";
            this.LblJSON.Size = new System.Drawing.Size(83, 13);
            this.LblJSON.TabIndex = 19;
            this.LblJSON.Text = "JSON of Issues:";
            // 
            // LblIssues
            // 
            this.LblIssues.AutoSize = true;
            this.LblIssues.Location = new System.Drawing.Point(9, 144);
            this.LblIssues.Name = "LblIssues";
            this.LblIssues.Size = new System.Drawing.Size(94, 13);
            this.LblIssues.TabIndex = 20;
            this.LblIssues.Text = "Issues from JSON:";
            // 
            // LblWorkRates
            // 
            this.LblWorkRates.AutoSize = true;
            this.LblWorkRates.Location = new System.Drawing.Point(9, 553);
            this.LblWorkRates.Name = "LblWorkRates";
            this.LblWorkRates.Size = new System.Drawing.Size(67, 13);
            this.LblWorkRates.TabIndex = 21;
            this.LblWorkRates.Text = "Work Rates:";
            // 
            // LblBoardsJSON
            // 
            this.LblBoardsJSON.AutoSize = true;
            this.LblBoardsJSON.Location = new System.Drawing.Point(499, 40);
            this.LblBoardsJSON.Name = "LblBoardsJSON";
            this.LblBoardsJSON.Size = new System.Drawing.Size(86, 13);
            this.LblBoardsJSON.TabIndex = 22;
            this.LblBoardsJSON.Text = "JSON of Boards:";
            // 
            // LblColumns
            // 
            this.LblColumns.AutoSize = true;
            this.LblColumns.Location = new System.Drawing.Point(9, 453);
            this.LblColumns.Name = "LblColumns";
            this.LblColumns.Size = new System.Drawing.Size(50, 13);
            this.LblColumns.TabIndex = 23;
            this.LblColumns.Text = "Columns:";
            // 
            // CboFilters
            // 
            this.CboFilters.FormattingEnabled = true;
            this.CboFilters.Location = new System.Drawing.Point(582, 160);
            this.CboFilters.MaxDropDownItems = 50;
            this.CboFilters.Name = "CboFilters";
            this.CboFilters.Size = new System.Drawing.Size(214, 21);
            this.CboFilters.TabIndex = 25;
            // 
            // BtnFilters
            // 
            this.BtnFilters.Location = new System.Drawing.Point(502, 158);
            this.BtnFilters.Name = "BtnFilters";
            this.BtnFilters.Size = new System.Drawing.Size(74, 23);
            this.BtnFilters.TabIndex = 24;
            this.BtnFilters.Text = "Get Filters";
            this.BtnFilters.UseVisualStyleBackColor = true;
            // 
            // FormJson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1121, 690);
            this.Controls.Add(this.CboFilters);
            this.Controls.Add(this.BtnFilters);
            this.Controls.Add(this.LblColumns);
            this.Controls.Add(this.LblBoardsJSON);
            this.Controls.Add(this.LblWorkRates);
            this.Controls.Add(this.LblIssues);
            this.Controls.Add(this.LblJSON);
            this.Controls.Add(this.LblCycleTimes);
            this.Controls.Add(this.TxtBoards);
            this.Controls.Add(this.CboBoards);
            this.Controls.Add(this.BtnGetBoards);
            this.Controls.Add(this.BtnParseFromCoded);
            this.Controls.Add(this.LblJSONPath);
            this.Controls.Add(this.TxtJSONPath);
            this.Controls.Add(this.BtnLoadAndParseJSON);
            this.Controls.Add(this.TxtAverage);
            this.Controls.Add(this.TxtColumns);
            this.Controls.Add(this.TxtIssues);
            this.Controls.Add(this.TxtWorkRates);
            this.Controls.Add(this.BtnParseFromTextBox);
            this.Controls.Add(this.TxtJson);
            this.Name = "FormJson";
            this.Text = "Json Test";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.TextBox TxtIssues;
        internal System.Windows.Forms.TextBox TxtWorkRates;
        internal System.Windows.Forms.Button BtnParseFromTextBox;
        internal System.Windows.Forms.TextBox TxtJson;
        internal System.Windows.Forms.TextBox TxtColumns;
        internal System.Windows.Forms.TextBox TxtAverage;
        private System.Windows.Forms.Button BtnLoadAndParseJSON;
        private System.Windows.Forms.TextBox TxtJSONPath;
        private System.Windows.Forms.Label LblJSONPath;
        internal System.Windows.Forms.Button BtnParseFromCoded;
        private System.Windows.Forms.Button BtnGetBoards;
        private System.Windows.Forms.ComboBox CboBoards;
        internal System.Windows.Forms.TextBox TxtBoards;
        private System.Windows.Forms.Label LblCycleTimes;
        private System.Windows.Forms.Label LblJSON;
        private System.Windows.Forms.Label LblIssues;
        private System.Windows.Forms.Label LblWorkRates;
        private System.Windows.Forms.Label LblBoardsJSON;
        private System.Windows.Forms.Label LblColumns;
        private System.Windows.Forms.ComboBox CboFilters;
        private System.Windows.Forms.Button BtnFilters;
    }
}