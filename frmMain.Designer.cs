
namespace AutomationFirstProject
{
    partial class frmMain
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
            this.lblUri = new System.Windows.Forms.Label();
            this.txtUri = new System.Windows.Forms.TextBox();
            this.btnGetContent = new System.Windows.Forms.Button();
            this.lstNews = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lblUri
            // 
            this.lblUri.AutoSize = true;
            this.lblUri.Location = new System.Drawing.Point(13, 13);
            this.lblUri.Name = "lblUri";
            this.lblUri.Size = new System.Drawing.Size(57, 13);
            this.lblUri.TabIndex = 0;
            this.lblUri.Text = "Site Adresi";
            // 
            // txtUri
            // 
            this.txtUri.Location = new System.Drawing.Point(76, 10);
            this.txtUri.Name = "txtUri";
            this.txtUri.Size = new System.Drawing.Size(198, 20);
            this.txtUri.TabIndex = 1;
            this.txtUri.Text = "https://www.haberler.com/son-dakika/";
            // 
            // btnGetContent
            // 
            this.btnGetContent.Location = new System.Drawing.Point(280, 8);
            this.btnGetContent.Name = "btnGetContent";
            this.btnGetContent.Size = new System.Drawing.Size(98, 23);
            this.btnGetContent.TabIndex = 2;
            this.btnGetContent.Text = "Haberleri Getir";
            this.btnGetContent.UseVisualStyleBackColor = true;
            this.btnGetContent.Click += new System.EventHandler(this.btnGetContent_Click);
            // 
            // lstNews
            // 
            this.lstNews.FormattingEnabled = true;
            this.lstNews.Location = new System.Drawing.Point(16, 36);
            this.lstNews.Name = "lstNews";
            this.lstNews.Size = new System.Drawing.Size(362, 329);
            this.lstNews.TabIndex = 3;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 374);
            this.Controls.Add(this.lstNews);
            this.Controls.Add(this.btnGetContent);
            this.Controls.Add(this.txtUri);
            this.Controls.Add(this.lblUri);
            this.Name = "frmMain";
            this.Text = "Haber Sitesi Botu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUri;
        private System.Windows.Forms.TextBox txtUri;
        private System.Windows.Forms.Button btnGetContent;
        private System.Windows.Forms.ListBox lstNews;
    }
}

