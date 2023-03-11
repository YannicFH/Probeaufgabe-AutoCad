namespace Probeaufgabe_AutoCad
{
    partial class MessageModal
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
            this.btnExportExcle = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblAttTag = new System.Windows.Forms.Label();
            this.lblAttString = new System.Windows.Forms.Label();
            this.lblAttTagText = new System.Windows.Forms.Label();
            this.lblAttStringText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnExportExcle
            // 
            this.btnExportExcle.Location = new System.Drawing.Point(264, 129);
            this.btnExportExcle.Name = "btnExportExcle";
            this.btnExportExcle.Size = new System.Drawing.Size(75, 23);
            this.btnExportExcle.TabIndex = 0;
            this.btnExportExcle.Text = "Export";
            this.btnExportExcle.UseVisualStyleBackColor = true;
            this.btnExportExcle.Click += new System.EventHandler(this.btnExportExcle_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(21, 129);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "Ok";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblAttTag
            // 
            this.lblAttTag.AutoSize = true;
            this.lblAttTag.Location = new System.Drawing.Point(21, 24);
            this.lblAttTag.Name = "lblAttTag";
            this.lblAttTag.Size = new System.Drawing.Size(0, 13);
            this.lblAttTag.TabIndex = 2;
            // 
            // lblAttString
            // 
            this.lblAttString.AutoSize = true;
            this.lblAttString.Location = new System.Drawing.Point(21, 46);
            this.lblAttString.Name = "lblAttString";
            this.lblAttString.Size = new System.Drawing.Size(0, 13);
            this.lblAttString.TabIndex = 3;
            // 
            // lblAttTagText
            // 
            this.lblAttTagText.AutoSize = true;
            this.lblAttTagText.Location = new System.Drawing.Point(146, 24);
            this.lblAttTagText.Name = "lblAttTagText";
            this.lblAttTagText.Size = new System.Drawing.Size(0, 13);
            this.lblAttTagText.TabIndex = 4;
            // 
            // lblAttStringText
            // 
            this.lblAttStringText.AutoSize = true;
            this.lblAttStringText.Location = new System.Drawing.Point(146, 46);
            this.lblAttStringText.Name = "lblAttStringText";
            this.lblAttStringText.Size = new System.Drawing.Size(0, 13);
            this.lblAttStringText.TabIndex = 5;
            // 
            // MessageModal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 169);
            this.Controls.Add(this.lblAttStringText);
            this.Controls.Add(this.lblAttTagText);
            this.Controls.Add(this.lblAttString);
            this.Controls.Add(this.lblAttTag);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnExportExcle);
            this.Name = "MessageModal";
            this.Text = "Attributes";
            this.Load += new System.EventHandler(this.MessageModal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExportExcle;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblAttTag;
        private System.Windows.Forms.Label lblAttString;
        private System.Windows.Forms.Label lblAttTagText;
        private System.Windows.Forms.Label lblAttStringText;
    }
}