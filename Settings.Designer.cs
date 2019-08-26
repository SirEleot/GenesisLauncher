namespace Launcher
{
    partial class GSettings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GSettings));
            this.GLable_gamePath = new System.Windows.Forms.Label();
            this.GLable_modPath = new System.Windows.Forms.Label();
            this.GTbox_gamePath = new System.Windows.Forms.TextBox();
            this.GTbox_modPath = new System.Windows.Forms.TextBox();
            this.GButton_settingGamePath = new System.Windows.Forms.Button();
            this.GButton_settingModPath = new System.Windows.Forms.Button();
            this.GCheck_x64 = new System.Windows.Forms.CheckBox();
            this.GCheck_window = new System.Windows.Forms.CheckBox();
            this.GCheck_HT = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // GLable_gamePath
            // 
            this.GLable_gamePath.AutoSize = true;
            this.GLable_gamePath.Location = new System.Drawing.Point(12, 23);
            this.GLable_gamePath.Name = "GLable_gamePath";
            this.GLable_gamePath.Size = new System.Drawing.Size(126, 13);
            this.GLable_gamePath.TabIndex = 0;
            this.GLable_gamePath.Text = "Путь до папки с  игрой:";
            // 
            // GLable_modPath
            // 
            this.GLable_modPath.AutoSize = true;
            this.GLable_modPath.Location = new System.Drawing.Point(12, 62);
            this.GLable_modPath.Name = "GLable_modPath";
            this.GLable_modPath.Size = new System.Drawing.Size(131, 13);
            this.GLable_modPath.TabIndex = 0;
            this.GLable_modPath.Text = "Путь до папки с  модом:";
            // 
            // GTbox_gamePath
            // 
            this.GTbox_gamePath.Enabled = false;
            this.GTbox_gamePath.Location = new System.Drawing.Point(15, 39);
            this.GTbox_gamePath.Name = "GTbox_gamePath";
            this.GTbox_gamePath.Size = new System.Drawing.Size(433, 20);
            this.GTbox_gamePath.TabIndex = 1;
            // 
            // GTbox_modPath
            // 
            this.GTbox_modPath.Enabled = false;
            this.GTbox_modPath.Location = new System.Drawing.Point(15, 78);
            this.GTbox_modPath.Name = "GTbox_modPath";
            this.GTbox_modPath.Size = new System.Drawing.Size(433, 20);
            this.GTbox_modPath.TabIndex = 1;
            // 
            // GButton_settingGamePath
            // 
            this.GButton_settingGamePath.Location = new System.Drawing.Point(463, 37);
            this.GButton_settingGamePath.Name = "GButton_settingGamePath";
            this.GButton_settingGamePath.Size = new System.Drawing.Size(25, 23);
            this.GButton_settingGamePath.TabIndex = 2;
            this.GButton_settingGamePath.Text = "F";
            this.GButton_settingGamePath.UseVisualStyleBackColor = true;
            this.GButton_settingGamePath.Click += new System.EventHandler(this.GButton_settingGamePath_Click);
            // 
            // GButton_settingModPath
            // 
            this.GButton_settingModPath.Location = new System.Drawing.Point(463, 75);
            this.GButton_settingModPath.Name = "GButton_settingModPath";
            this.GButton_settingModPath.Size = new System.Drawing.Size(25, 23);
            this.GButton_settingModPath.TabIndex = 2;
            this.GButton_settingModPath.Text = "F";
            this.GButton_settingModPath.UseVisualStyleBackColor = true;
            this.GButton_settingModPath.Click += new System.EventHandler(this.GButton_settingModPath_Click);
            // 
            // GCheck_x64
            // 
            this.GCheck_x64.AutoSize = true;
            this.GCheck_x64.Location = new System.Drawing.Point(15, 132);
            this.GCheck_x64.Name = "GCheck_x64";
            this.GCheck_x64.Size = new System.Drawing.Size(168, 17);
            this.GCheck_x64.TabIndex = 3;
            this.GCheck_x64.Text = "Запускать х64 версию игры";
            this.GCheck_x64.UseVisualStyleBackColor = true;
            this.GCheck_x64.CheckedChanged += new System.EventHandler(this.GCheck_x64_CheckedChanged);
            // 
            // GCheck_window
            // 
            this.GCheck_window.AutoSize = true;
            this.GCheck_window.Location = new System.Drawing.Point(15, 155);
            this.GCheck_window.Name = "GCheck_window";
            this.GCheck_window.Size = new System.Drawing.Size(203, 17);
            this.GCheck_window.TabIndex = 3;
            this.GCheck_window.Text = "Запускать игру в оконном режиме";
            this.GCheck_window.UseVisualStyleBackColor = true;
            this.GCheck_window.CheckedChanged += new System.EventHandler(this.GCheck_window_CheckedChanged);
            // 
            // GCheck_HT
            // 
            this.GCheck_HT.AutoSize = true;
            this.GCheck_HT.Location = new System.Drawing.Point(15, 178);
            this.GCheck_HT.Name = "GCheck_HT";
            this.GCheck_HT.Size = new System.Drawing.Size(372, 17);
            this.GCheck_HT.TabIndex = 3;
            this.GCheck_HT.Text = "Включить HyperThrading (для процессоров Intel если поддерживают)";
            this.GCheck_HT.UseVisualStyleBackColor = true;
            this.GCheck_HT.CheckedChanged += new System.EventHandler(this.GCheck_HT_CheckedChanged);
            // 
            // GSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 279);
            this.Controls.Add(this.GCheck_HT);
            this.Controls.Add(this.GCheck_window);
            this.Controls.Add(this.GCheck_x64);
            this.Controls.Add(this.GButton_settingModPath);
            this.Controls.Add(this.GButton_settingGamePath);
            this.Controls.Add(this.GTbox_modPath);
            this.Controls.Add(this.GTbox_gamePath);
            this.Controls.Add(this.GLable_modPath);
            this.Controls.Add(this.GLable_gamePath);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GSettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Settings";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GSettings_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label GLable_gamePath;
        private System.Windows.Forms.Label GLable_modPath;
        private System.Windows.Forms.TextBox GTbox_gamePath;
        private System.Windows.Forms.TextBox GTbox_modPath;
        private System.Windows.Forms.Button GButton_settingGamePath;
        private System.Windows.Forms.Button GButton_settingModPath;
        private System.Windows.Forms.CheckBox GCheck_x64;
        private System.Windows.Forms.CheckBox GCheck_window;
        private System.Windows.Forms.CheckBox GCheck_HT;
    }
}