namespace Launcher
{
    partial class GForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.Browser = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // Browser
            // 
            this.Browser.Location = new System.Drawing.Point(460, 142);
            this.Browser.MinimumSize = new System.Drawing.Size(20, 20);
            this.Browser.Name = "Browser";
            this.Browser.ScrollBarsEnabled = false;
            this.Browser.Size = new System.Drawing.Size(250, 250);
            this.Browser.TabIndex = 0;
            this.Browser.Url = new System.Uri("", System.UriKind.Relative);
            this.Browser.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.Browser_DocumentCompleted);
            // 
            // GForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.Browser);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Launcher";
            this.Load += new System.EventHandler(this.GForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.WebBrowser Browser;
    }
}

