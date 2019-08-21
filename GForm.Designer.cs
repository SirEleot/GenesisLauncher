using System.Drawing;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GForm));
            this.GBrowser = new System.Windows.Forms.WebBrowser();
            this.GProgress = new System.Windows.Forms.ProgressBar();
            this.GButton_play = new System.Windows.Forms.Button();
            this.GButton_forum = new System.Windows.Forms.Button();
            this.GButton_lk = new System.Windows.Forms.Button();
            this.GButton_vk = new System.Windows.Forms.Button();
            this.GButton_youtube = new System.Windows.Forms.Button();
            this.GButton_settings = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // GBrowser
            // 
            this.GBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GBrowser.Location = new System.Drawing.Point(0, 0);
            this.GBrowser.Margin = new System.Windows.Forms.Padding(0);
            this.GBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.GBrowser.Name = "GBrowser";
            this.GBrowser.ScrollBarsEnabled = false;
            this.GBrowser.Size = new System.Drawing.Size(800, 600);
            this.GBrowser.TabIndex = 0;
            this.GBrowser.Url = new System.Uri("", System.UriKind.Relative);
            this.GBrowser.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.Browser_DocumentCompleted);
            // 
            // GProgress
            // 
            this.GProgress.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.GProgress.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.GProgress.Location = new System.Drawing.Point(184, 571);
            this.GProgress.Name = "GProgress";
            this.GProgress.Size = new System.Drawing.Size(434, 11);
            this.GProgress.Step = 1;
            this.GProgress.TabIndex = 1;
            this.GProgress.Value = 50;
            // 
            // GButton_play
            // 
            this.GButton_play.Cursor = System.Windows.Forms.Cursors.Hand;
            this.GButton_play.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GButton_play.Location = new System.Drawing.Point(649, 565);
            this.GButton_play.Margin = new System.Windows.Forms.Padding(0);
            this.GButton_play.Name = "GButton_play";
            this.GButton_play.Size = new System.Drawing.Size(125, 23);
            this.GButton_play.TabIndex = 3;
            this.GButton_play.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.GButton_play.UseMnemonic = false;
            this.GButton_play.UseVisualStyleBackColor = true;
            // 
            // GButton_forum
            // 
            this.GButton_forum.Location = new System.Drawing.Point(12, 102);
            this.GButton_forum.Name = "GButton_forum";
            this.GButton_forum.Size = new System.Drawing.Size(116, 23);
            this.GButton_forum.TabIndex = 4;
            this.GButton_forum.Tag = "0";
            this.GButton_forum.Text = "Forum";
            this.GButton_forum.UseVisualStyleBackColor = true;
            this.GButton_forum.Click += new System.EventHandler(Navigation.GoToLink);
            // 
            // GButton_lk
            // 
            this.GButton_lk.Location = new System.Drawing.Point(12, 131);
            this.GButton_lk.Name = "GButton_lk";
            this.GButton_lk.Size = new System.Drawing.Size(116, 23);
            this.GButton_lk.TabIndex = 4;
            this.GButton_lk.Tag = "1";
            this.GButton_lk.Text = "LK";
            this.GButton_lk.UseVisualStyleBackColor = true;
            this.GButton_lk.Click += new System.EventHandler(Navigation.GoToLink);
            // 
            // GButton_vk
            // 
            this.GButton_vk.Location = new System.Drawing.Point(12, 160);
            this.GButton_vk.Name = "GButton_vk";
            this.GButton_vk.Size = new System.Drawing.Size(116, 23);
            this.GButton_vk.TabIndex = 4;
            this.GButton_vk.Tag = "2";
            this.GButton_vk.Text = "VK";
            this.GButton_vk.UseVisualStyleBackColor = true;
            this.GButton_vk.Click += new System.EventHandler(Navigation.GoToLink);
            // 
            // GButton_youtube
            // 
            this.GButton_youtube.Location = new System.Drawing.Point(12, 189);
            this.GButton_youtube.Name = "GButton_youtube";
            this.GButton_youtube.Size = new System.Drawing.Size(116, 23);
            this.GButton_youtube.TabIndex = 4;
            this.GButton_youtube.Tag = "3";
            this.GButton_youtube.Text = "Youtube";
            this.GButton_youtube.UseVisualStyleBackColor = true;
            this.GButton_youtube.Click += new System.EventHandler(Navigation.GoToLink);
            // 
            // GButton_settings
            // 
            this.GButton_settings.Location = new System.Drawing.Point(12, 218);
            this.GButton_settings.Name = "GButton_settings";
            this.GButton_settings.Size = new System.Drawing.Size(116, 23);
            this.GButton_settings.TabIndex = 4;
            this.GButton_settings.Tag = "4";
            this.GButton_settings.Text = "Settings";
            this.GButton_settings.UseVisualStyleBackColor = true;
            this.GButton_settings.Click += new System.EventHandler(Navigation.OpenSettingMenu);
            // 
            // GForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Launcher.Properties.Resources.изображение_viber_2019_08_20_16_24_12;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.GButton_settings);
            this.Controls.Add(this.GButton_youtube);
            this.Controls.Add(this.GButton_vk);
            this.Controls.Add(this.GButton_lk);
            this.Controls.Add(this.GButton_forum);
            this.Controls.Add(this.GButton_play);
            this.Controls.Add(this.GProgress);
            this.Controls.Add(this.GBrowser);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "GForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Launcher";
            this.TransparencyKey = System.Drawing.Color.LimeGreen;
            this.Load += new System.EventHandler(this.GForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.WebBrowser GBrowser;
        private System.Windows.Forms.ProgressBar GProgress;
        private System.Windows.Forms.Button GButton_play;
        private System.Windows.Forms.Button GButton_forum;
        private System.Windows.Forms.Button GButton_lk;
        private System.Windows.Forms.Button GButton_vk;
        private System.Windows.Forms.Button GButton_youtube;
        private System.Windows.Forms.Button GButton_settings;
    }
}

