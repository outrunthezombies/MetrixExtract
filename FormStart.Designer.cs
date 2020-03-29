namespace MetrixExtract
{
    partial class FormStart
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
            this.BtnMetrixThruDB = new System.Windows.Forms.Button();
            this.BtnParseJSON = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnMetrixThruDB
            // 
            this.BtnMetrixThruDB.Location = new System.Drawing.Point(48, 32);
            this.BtnMetrixThruDB.Name = "BtnMetrixThruDB";
            this.BtnMetrixThruDB.Size = new System.Drawing.Size(191, 23);
            this.BtnMetrixThruDB.TabIndex = 0;
            this.BtnMetrixThruDB.Text = "Add/Edit/Delete Metrix Manually";
            this.BtnMetrixThruDB.UseVisualStyleBackColor = true;
            this.BtnMetrixThruDB.Click += new System.EventHandler(this.BtnMetrixThruDB_Click);
            // 
            // BtnParseJSON
            // 
            this.BtnParseJSON.Location = new System.Drawing.Point(48, 61);
            this.BtnParseJSON.Name = "BtnParseJSON";
            this.BtnParseJSON.Size = new System.Drawing.Size(191, 23);
            this.BtnParseJSON.TabIndex = 1;
            this.BtnParseJSON.Text = "Parse JSON Data";
            this.BtnParseJSON.UseVisualStyleBackColor = true;
            this.BtnParseJSON.Click += new System.EventHandler(this.BtnParseJSON_Click);
            // 
            // FormStart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 265);
            this.Controls.Add(this.BtnParseJSON);
            this.Controls.Add(this.BtnMetrixThruDB);
            this.Name = "FormStart";
            this.Text = "Choose Your Adventure";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnMetrixThruDB;
        private System.Windows.Forms.Button BtnParseJSON;
    }
}