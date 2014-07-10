﻿namespace MangaReader.SettingsForms
{
    partial class SettingsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {

            parent.Enabled = true;
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
            this.components = new System.ComponentModel.Container();
            this.SettingsTab = new System.Windows.Forms.TabControl();
            this.Preferences = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.AlertCheckBox = new System.Windows.Forms.CheckBox();
            this.SettingsTab.SuspendLayout();
            this.Preferences.SuspendLayout();
            this.SuspendLayout();
            // 
            // SettingsTab
            // 
            this.SettingsTab.Controls.Add(this.Preferences);
            this.SettingsTab.Controls.Add(this.tabPage2);
            this.SettingsTab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SettingsTab.Location = new System.Drawing.Point(0, 0);
            this.SettingsTab.Name = "SettingsTab";
            this.SettingsTab.SelectedIndex = 0;
            this.SettingsTab.Size = new System.Drawing.Size(1005, 501);
            this.SettingsTab.TabIndex = 0;
            // 
            // Preferences
            // 
            this.Preferences.Controls.Add(this.AlertCheckBox);
            this.Preferences.Location = new System.Drawing.Point(4, 22);
            this.Preferences.Name = "Preferences";
            this.Preferences.Padding = new System.Windows.Forms.Padding(3);
            this.Preferences.Size = new System.Drawing.Size(997, 475);
            this.Preferences.TabIndex = 0;
            this.Preferences.Text = "Preferences";
            this.Preferences.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(997, 475);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // AlertCheckBox
            // 
            this.AlertCheckBox.AutoSize = true;
            this.AlertCheckBox.Location = new System.Drawing.Point(27, 38);
            this.AlertCheckBox.Name = "AlertCheckBox";
            this.AlertCheckBox.Size = new System.Drawing.Size(145, 17);
            this.AlertCheckBox.TabIndex = 0;
            this.AlertCheckBox.Text = "Beginning and End Alerts";
            this.AlertCheckBox.UseVisualStyleBackColor = true;
            this.AlertCheckBox.CheckedChanged += new System.EventHandler(this.AlertCheckBox_CheckedChanged);
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1005, 501);
            this.Controls.Add(this.SettingsTab);
            this.Name = "Settings";
            this.Text = "Settings";
            this.SettingsTab.ResumeLayout(false);
            this.Preferences.ResumeLayout(false);
            this.Preferences.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl SettingsTab;
        private System.Windows.Forms.TabPage Preferences;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.CheckBox AlertCheckBox;
    }
}