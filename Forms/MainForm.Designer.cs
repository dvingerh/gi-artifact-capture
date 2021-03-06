﻿
namespace genshin_artifact_collage_maker
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.StartButton = new System.Windows.Forms.Button();
            this.CaptureProgressBar = new System.Windows.Forms.ProgressBar();
            this.SaveIndividualImagesCheckBox = new System.Windows.Forms.CheckBox();
            this.GenshinProcessTimer = new System.Windows.Forms.Timer(this.components);
            this.TimeOutUpDown = new System.Windows.Forms.NumericUpDown();
            this.TimeOutLabel = new System.Windows.Forms.Label();
            this.SaveInOwnDirectoryCheckBox = new System.Windows.Forms.CheckBox();
            this.OpenOutputDirectoryButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.TimeOutUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // StartButton
            // 
            this.StartButton.Enabled = false;
            this.StartButton.Location = new System.Drawing.Point(12, 112);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(261, 23);
            this.StartButton.TabIndex = 0;
            this.StartButton.Text = "Game not running";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartCapture);
            // 
            // CaptureProgressBar
            // 
            this.CaptureProgressBar.Location = new System.Drawing.Point(13, 90);
            this.CaptureProgressBar.Name = "CaptureProgressBar";
            this.CaptureProgressBar.Size = new System.Drawing.Size(259, 16);
            this.CaptureProgressBar.Step = 20;
            this.CaptureProgressBar.TabIndex = 1;
            // 
            // SaveIndividualImagesCheckBox
            // 
            this.SaveIndividualImagesCheckBox.AutoSize = true;
            this.SaveIndividualImagesCheckBox.Checked = true;
            this.SaveIndividualImagesCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.SaveIndividualImagesCheckBox.Location = new System.Drawing.Point(12, 9);
            this.SaveIndividualImagesCheckBox.Margin = new System.Windows.Forms.Padding(2);
            this.SaveIndividualImagesCheckBox.Name = "SaveIndividualImagesCheckBox";
            this.SaveIndividualImagesCheckBox.Size = new System.Drawing.Size(244, 17);
            this.SaveIndividualImagesCheckBox.TabIndex = 3;
            this.SaveIndividualImagesCheckBox.Text = "Save individual artifact screenshots as well";
            this.SaveIndividualImagesCheckBox.UseVisualStyleBackColor = true;
            // 
            // GenshinProcessTimer
            // 
            this.GenshinProcessTimer.Enabled = true;
            this.GenshinProcessTimer.Interval = 500;
            this.GenshinProcessTimer.Tick += new System.EventHandler(this.UpdateGameRunningStatus);
            // 
            // TimeOutUpDown
            // 
            this.TimeOutUpDown.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TimeOutUpDown.Location = new System.Drawing.Point(12, 58);
            this.TimeOutUpDown.Margin = new System.Windows.Forms.Padding(2);
            this.TimeOutUpDown.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.TimeOutUpDown.Minimum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.TimeOutUpDown.Name = "TimeOutUpDown";
            this.TimeOutUpDown.Size = new System.Drawing.Size(47, 22);
            this.TimeOutUpDown.TabIndex = 5;
            this.TimeOutUpDown.Value = new decimal(new int[] {
            1500,
            0,
            0,
            0});
            // 
            // TimeOutLabel
            // 
            this.TimeOutLabel.AutoSize = true;
            this.TimeOutLabel.Location = new System.Drawing.Point(61, 60);
            this.TimeOutLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.TimeOutLabel.Name = "TimeOutLabel";
            this.TimeOutLabel.Size = new System.Drawing.Size(204, 13);
            this.TimeOutLabel.TabIndex = 6;
            this.TimeOutLabel.Text = "milliseconds between each screenshot";
            // 
            // SaveInOwnDirectoryCheckBox
            // 
            this.SaveInOwnDirectoryCheckBox.AutoSize = true;
            this.SaveInOwnDirectoryCheckBox.Checked = true;
            this.SaveInOwnDirectoryCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.SaveInOwnDirectoryCheckBox.Location = new System.Drawing.Point(12, 30);
            this.SaveInOwnDirectoryCheckBox.Margin = new System.Windows.Forms.Padding(2);
            this.SaveInOwnDirectoryCheckBox.Name = "SaveInOwnDirectoryCheckBox";
            this.SaveInOwnDirectoryCheckBox.Size = new System.Drawing.Size(258, 17);
            this.SaveInOwnDirectoryCheckBox.TabIndex = 7;
            this.SaveInOwnDirectoryCheckBox.Text = "Save each artifact collage to its own directory\r\n";
            this.SaveInOwnDirectoryCheckBox.UseVisualStyleBackColor = true;
            // 
            // OpenOutputDirectoryButton
            // 
            this.OpenOutputDirectoryButton.Location = new System.Drawing.Point(12, 141);
            this.OpenOutputDirectoryButton.Name = "OpenOutputDirectoryButton";
            this.OpenOutputDirectoryButton.Size = new System.Drawing.Size(261, 23);
            this.OpenOutputDirectoryButton.TabIndex = 8;
            this.OpenOutputDirectoryButton.Text = "Open output directory";
            this.OpenOutputDirectoryButton.UseVisualStyleBackColor = true;
            this.OpenOutputDirectoryButton.Click += new System.EventHandler(this.OpenOutputDirectory);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(284, 176);
            this.Controls.Add(this.OpenOutputDirectoryButton);
            this.Controls.Add(this.SaveInOwnDirectoryCheckBox);
            this.Controls.Add(this.TimeOutLabel);
            this.Controls.Add(this.TimeOutUpDown);
            this.Controls.Add(this.SaveIndividualImagesCheckBox);
            this.Controls.Add(this.CaptureProgressBar);
            this.Controls.Add(this.StartButton);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "genshin-artifact-collage-maker";
            ((System.ComponentModel.ISupportInitialize)(this.TimeOutUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.ProgressBar CaptureProgressBar;
        private System.Windows.Forms.CheckBox SaveIndividualImagesCheckBox;
        private System.Windows.Forms.Timer GenshinProcessTimer;
        private System.Windows.Forms.NumericUpDown TimeOutUpDown;
        private System.Windows.Forms.Label TimeOutLabel;
        private System.Windows.Forms.CheckBox SaveInOwnDirectoryCheckBox;
        private System.Windows.Forms.Button OpenOutputDirectoryButton;
    }
}

