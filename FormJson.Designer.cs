﻿namespace MetrixExtract
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
            this.TxtRates = new System.Windows.Forms.TextBox();
            this.BtnParse = new System.Windows.Forms.Button();
            this.TxtJson = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // TxtIssues
            // 
            this.TxtIssues.Location = new System.Drawing.Point(490, 41);
            this.TxtIssues.Multiline = true;
            this.TxtIssues.Name = "TxtIssues";
            this.TxtIssues.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TxtIssues.Size = new System.Drawing.Size(692, 253);
            this.TxtIssues.TabIndex = 7;
            // 
            // TxtRates
            // 
            this.TxtRates.Location = new System.Drawing.Point(490, 300);
            this.TxtRates.Multiline = true;
            this.TxtRates.Name = "TxtRates";
            this.TxtRates.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TxtRates.Size = new System.Drawing.Size(692, 248);
            this.TxtRates.TabIndex = 6;
            // 
            // BtnParse
            // 
            this.BtnParse.Location = new System.Drawing.Point(490, 12);
            this.BtnParse.Name = "BtnParse";
            this.BtnParse.Size = new System.Drawing.Size(75, 23);
            this.BtnParse.TabIndex = 5;
            this.BtnParse.Text = "Parse";
            this.BtnParse.UseVisualStyleBackColor = true;
            this.BtnParse.Click += new System.EventHandler(this.btnParse_Click);
            // 
            // TxtJson
            // 
            this.TxtJson.Location = new System.Drawing.Point(12, 12);
            this.TxtJson.Multiline = true;
            this.TxtJson.Name = "TxtJson";
            this.TxtJson.Size = new System.Drawing.Size(472, 536);
            this.TxtJson.TabIndex = 4;
            this.TxtJson.Text = resources.GetString("TxtJson.Text");
            // 
            // FormJson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1195, 559);
            this.Controls.Add(this.TxtIssues);
            this.Controls.Add(this.TxtRates);
            this.Controls.Add(this.BtnParse);
            this.Controls.Add(this.TxtJson);
            this.Name = "FormJson";
            this.Text = "Json Test";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.TextBox TxtIssues;
        internal System.Windows.Forms.TextBox TxtRates;
        internal System.Windows.Forms.Button BtnParse;
        internal System.Windows.Forms.TextBox TxtJson;
    }
}