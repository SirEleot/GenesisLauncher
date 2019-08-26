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
            this.GProgress = new System.Windows.Forms.ProgressBar();
            this.GButton_play = new System.Windows.Forms.Button();
            this.GButton_forum = new System.Windows.Forms.Button();
            this.GButton_lk = new System.Windows.Forms.Button();
            this.GButton_vk = new System.Windows.Forms.Button();
            this.GButton_youtube = new System.Windows.Forms.Button();
            this.GButton_settings = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.GButton_close = new System.Windows.Forms.Button();
            this.GButton_min = new System.Windows.Forms.Button();
            this.GLabel_update = new System.Windows.Forms.Label();
            this.GLabel_progress = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // GProgress
            // 
            this.GProgress.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.GProgress.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.GProgress.Location = new System.Drawing.Point(191, 568);
            this.GProgress.Name = "GProgress";
            this.GProgress.Size = new System.Drawing.Size(434, 11);
            this.GProgress.Step = 1;
            this.GProgress.TabIndex = 1;
            this.GProgress.Value = 50;
            // 
            // GButton_play
            // 
            this.GButton_play.BackColor = System.Drawing.Color.Transparent;
            this.GButton_play.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.GButton_play.Cursor = System.Windows.Forms.Cursors.Hand;
            this.GButton_play.FlatAppearance.BorderSize = 0;
            this.GButton_play.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.GButton_play.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.GButton_play.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GButton_play.Location = new System.Drawing.Point(645, 546);
            this.GButton_play.Margin = new System.Windows.Forms.Padding(0);
            this.GButton_play.Name = "GButton_play";
            this.GButton_play.Size = new System.Drawing.Size(141, 45);
            this.GButton_play.TabIndex = 3;
            this.GButton_play.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.GButton_play.UseMnemonic = false;
            this.GButton_play.UseVisualStyleBackColor = false;
            this.GButton_play.MouseEnter += new System.EventHandler(this.GButton_play_MouseEnter);
            // 
            // GButton_forum
            // 
            this.GButton_forum.BackColor = System.Drawing.Color.Transparent;
            this.GButton_forum.BackgroundImage = global::Launcher.Properties.Resources.forum;
            this.GButton_forum.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.GButton_forum.Cursor = System.Windows.Forms.Cursors.Hand;
            this.GButton_forum.FlatAppearance.BorderSize = 0;
            this.GButton_forum.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.GButton_forum.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.GButton_forum.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GButton_forum.ForeColor = System.Drawing.Color.Transparent;
            this.GButton_forum.Location = new System.Drawing.Point(0, 81);
            this.GButton_forum.Name = "GButton_forum";
            this.GButton_forum.Size = new System.Drawing.Size(150, 40);
            this.GButton_forum.TabIndex = 4;
            this.GButton_forum.Tag = "0";
            this.GButton_forum.UseVisualStyleBackColor = false;
            this.GButton_forum.Click += new System.EventHandler(this.GButton_forum_Click);
            this.GButton_forum.MouseEnter += new System.EventHandler(this.GButton_forum_MouseEnter);
            // 
            // GButton_lk
            // 
            this.GButton_lk.BackColor = System.Drawing.Color.Transparent;
            this.GButton_lk.BackgroundImage = global::Launcher.Properties.Resources.LK;
            this.GButton_lk.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.GButton_lk.Cursor = System.Windows.Forms.Cursors.Hand;
            this.GButton_lk.FlatAppearance.BorderSize = 0;
            this.GButton_lk.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.GButton_lk.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.GButton_lk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GButton_lk.Location = new System.Drawing.Point(-1, 136);
            this.GButton_lk.Name = "GButton_lk";
            this.GButton_lk.Size = new System.Drawing.Size(150, 40);
            this.GButton_lk.TabIndex = 4;
            this.GButton_lk.Tag = "1";
            this.GButton_lk.UseVisualStyleBackColor = false;
            this.GButton_lk.Click += new System.EventHandler(this.GButton_lk_Click);
            this.GButton_lk.MouseEnter += new System.EventHandler(this.GButton_lk_MouseEnter);
            // 
            // GButton_vk
            // 
            this.GButton_vk.BackColor = System.Drawing.Color.Transparent;
            this.GButton_vk.BackgroundImage = global::Launcher.Properties.Resources.VK;
            this.GButton_vk.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.GButton_vk.Cursor = System.Windows.Forms.Cursors.Hand;
            this.GButton_vk.FlatAppearance.BorderSize = 0;
            this.GButton_vk.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.GButton_vk.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.GButton_vk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GButton_vk.ForeColor = System.Drawing.Color.Transparent;
            this.GButton_vk.Location = new System.Drawing.Point(-1, 192);
            this.GButton_vk.Name = "GButton_vk";
            this.GButton_vk.Size = new System.Drawing.Size(150, 40);
            this.GButton_vk.TabIndex = 4;
            this.GButton_vk.Tag = "2";
            this.GButton_vk.UseVisualStyleBackColor = false;
            this.GButton_vk.Click += new System.EventHandler(this.GButton_vk_Click);
            this.GButton_vk.MouseEnter += new System.EventHandler(this.GButton_vk_MouseEnter);
            // 
            // GButton_youtube
            // 
            this.GButton_youtube.BackColor = System.Drawing.Color.Transparent;
            this.GButton_youtube.BackgroundImage = global::Launcher.Properties.Resources.YouTube;
            this.GButton_youtube.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.GButton_youtube.Cursor = System.Windows.Forms.Cursors.Hand;
            this.GButton_youtube.FlatAppearance.BorderSize = 0;
            this.GButton_youtube.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.GButton_youtube.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.GButton_youtube.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GButton_youtube.Location = new System.Drawing.Point(-1, 249);
            this.GButton_youtube.Name = "GButton_youtube";
            this.GButton_youtube.Size = new System.Drawing.Size(150, 40);
            this.GButton_youtube.TabIndex = 4;
            this.GButton_youtube.Tag = "3";
            this.GButton_youtube.UseVisualStyleBackColor = false;
            this.GButton_youtube.Click += new System.EventHandler(this.GButton_youtube_Click);
            this.GButton_youtube.MouseEnter += new System.EventHandler(this.GButton_youtube_MouseEnter);
            // 
            // GButton_settings
            // 
            this.GButton_settings.BackColor = System.Drawing.Color.Transparent;
            this.GButton_settings.BackgroundImage = global::Launcher.Properties.Resources.settings_nav;
            this.GButton_settings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.GButton_settings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.GButton_settings.FlatAppearance.BorderSize = 0;
            this.GButton_settings.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.GButton_settings.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.GButton_settings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GButton_settings.Location = new System.Drawing.Point(-1, 306);
            this.GButton_settings.Margin = new System.Windows.Forms.Padding(0);
            this.GButton_settings.Name = "GButton_settings";
            this.GButton_settings.Size = new System.Drawing.Size(152, 45);
            this.GButton_settings.TabIndex = 4;
            this.GButton_settings.Tag = "4";
            this.GButton_settings.UseVisualStyleBackColor = false;
            this.GButton_settings.Click += new System.EventHandler(this.GButton_settings_Click);
            this.GButton_settings.MouseEnter += new System.EventHandler(this.GButton_settings_MouseEnter);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = global::Launcher.Properties.Resources.cube;
            this.panel1.Controls.Add(this.GButton_forum);
            this.panel1.Controls.Add(this.GButton_settings);
            this.panel1.Controls.Add(this.GButton_lk);
            this.panel1.Controls.Add(this.GButton_youtube);
            this.panel1.Controls.Add(this.GButton_vk);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(152, 600);
            this.panel1.TabIndex = 5;
            // 
            // GButton_close
            // 
            this.GButton_close.BackColor = System.Drawing.Color.Transparent;
            this.GButton_close.BackgroundImage = global::Launcher.Properties.Resources.close;
            this.GButton_close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.GButton_close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.GButton_close.FlatAppearance.BorderSize = 0;
            this.GButton_close.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.GButton_close.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.GButton_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GButton_close.Location = new System.Drawing.Point(756, 12);
            this.GButton_close.Name = "GButton_close";
            this.GButton_close.Size = new System.Drawing.Size(32, 32);
            this.GButton_close.TabIndex = 7;
            this.GButton_close.UseVisualStyleBackColor = false;
            this.GButton_close.Click += new System.EventHandler(this.GButton_close_Click);
            this.GButton_close.MouseEnter += new System.EventHandler(this.GButton_close_MouseEnter);
            // 
            // GButton_min
            // 
            this.GButton_min.BackColor = System.Drawing.Color.Transparent;
            this.GButton_min.BackgroundImage = global::Launcher.Properties.Resources.minimize;
            this.GButton_min.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.GButton_min.Cursor = System.Windows.Forms.Cursors.Hand;
            this.GButton_min.FlatAppearance.BorderSize = 0;
            this.GButton_min.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.GButton_min.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.GButton_min.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GButton_min.Location = new System.Drawing.Point(705, 12);
            this.GButton_min.Name = "GButton_min";
            this.GButton_min.Size = new System.Drawing.Size(32, 32);
            this.GButton_min.TabIndex = 7;
            this.GButton_min.UseVisualStyleBackColor = false;
            this.GButton_min.Click += new System.EventHandler(this.GButton_min_Click);
            this.GButton_min.MouseEnter += new System.EventHandler(this.GButton_min_MouseEnter);
            // 
            // GLabel_update
            // 
            this.GLabel_update.AutoSize = true;
            this.GLabel_update.BackColor = System.Drawing.Color.Transparent;
            this.GLabel_update.ForeColor = System.Drawing.SystemColors.Control;
            this.GLabel_update.Location = new System.Drawing.Point(197, 546);
            this.GLabel_update.Name = "GLabel_update";
            this.GLabel_update.Size = new System.Drawing.Size(69, 13);
            this.GLabel_update.TabIndex = 8;
            this.GLabel_update.Text = "Downloading";
            // 
            // GLabel_progress
            // 
            this.GLabel_progress.AutoSize = true;
            this.GLabel_progress.BackColor = System.Drawing.Color.Transparent;
            this.GLabel_progress.ForeColor = System.Drawing.SystemColors.Control;
            this.GLabel_progress.Location = new System.Drawing.Point(592, 546);
            this.GLabel_progress.Name = "GLabel_progress";
            this.GLabel_progress.Size = new System.Drawing.Size(33, 13);
            this.GLabel_progress.TabIndex = 8;
            this.GLabel_progress.Text = "100%";
            this.GLabel_progress.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // GForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Launcher.Properties.Resources.bg;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.GLabel_progress);
            this.Controls.Add(this.GLabel_update);
            this.Controls.Add(this.GButton_min);
            this.Controls.Add(this.GButton_close);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.GButton_play);
            this.Controls.Add(this.GProgress);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "GForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Launcher";
            this.TransparencyKey = System.Drawing.Color.LimeGreen;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GForm_FormClosing);
            this.Load += new System.EventHandler(this.GForm_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ProgressBar GProgress;
        private System.Windows.Forms.Button GButton_play;
        private System.Windows.Forms.Button GButton_forum;
        private System.Windows.Forms.Button GButton_lk;
        private System.Windows.Forms.Button GButton_vk;
        private System.Windows.Forms.Button GButton_youtube;
        private System.Windows.Forms.Button GButton_settings;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button GButton_close;
        private System.Windows.Forms.Button GButton_min;
        private System.Windows.Forms.Label GLabel_update;
        private System.Windows.Forms.Label GLabel_progress;
    }
}

