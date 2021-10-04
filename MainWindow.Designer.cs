
namespace gifskiWinGUI
{
    partial class MainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.Loadfile_Browsebutton = new System.Windows.Forms.Button();
            this.Savefile_Browsebutton = new System.Windows.Forms.Button();
            this.LoadFile_Pathbox = new System.Windows.Forms.TextBox();
            this.SaveFile_Pathbox = new System.Windows.Forms.TextBox();
            this.Resize_Check = new System.Windows.Forms.CheckBox();
            this.HeightLabel = new System.Windows.Forms.Label();
            this.WidthLabel = new System.Windows.Forms.Label();
            this.HeightNumeric = new System.Windows.Forms.NumericUpDown();
            this.WidthNumeric = new System.Windows.Forms.NumericUpDown();
            this.fpsNumeric = new System.Windows.Forms.NumericUpDown();
            this.fpsLabel = new System.Windows.Forms.Label();
            this.QualityLabel = new System.Windows.Forms.Label();
            this.QualityNumeric = new System.Windows.Forms.NumericUpDown();
            this.SourcesLabel = new System.Windows.Forms.Label();
            this.DestinationLabel = new System.Windows.Forms.Label();
            this.RenderButton = new System.Windows.Forms.Button();
            this.helpButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.HeightNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WidthNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fpsNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.QualityNumeric)).BeginInit();
            this.SuspendLayout();
            // 
            // Loadfile_Browsebutton
            // 
            this.Loadfile_Browsebutton.AccessibleDescription = "Browse to the path and file names of the frames that will be used to render your " +
    "animation using Windows Explorer.";
            this.Loadfile_Browsebutton.AccessibleName = "Loading Browse Button";
            this.Loadfile_Browsebutton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Loadfile_Browsebutton.Location = new System.Drawing.Point(1011, 43);
            this.Loadfile_Browsebutton.Name = "Loadfile_Browsebutton";
            this.Loadfile_Browsebutton.Size = new System.Drawing.Size(91, 37);
            this.Loadfile_Browsebutton.TabIndex = 0;
            this.Loadfile_Browsebutton.Text = "Browse...";
            this.Loadfile_Browsebutton.UseVisualStyleBackColor = true;
            this.Loadfile_Browsebutton.Click += new System.EventHandler(this.Loadfile_Browsebutton_Click);
            // 
            // Savefile_Browsebutton
            // 
            this.Savefile_Browsebutton.AccessibleDescription = "Browse to the path and enter the name for your animation using Windows File Explo" +
    "rer.";
            this.Savefile_Browsebutton.AccessibleName = "Saving Browse Button";
            this.Savefile_Browsebutton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Savefile_Browsebutton.Location = new System.Drawing.Point(1011, 245);
            this.Savefile_Browsebutton.Name = "Savefile_Browsebutton";
            this.Savefile_Browsebutton.Size = new System.Drawing.Size(91, 37);
            this.Savefile_Browsebutton.TabIndex = 1;
            this.Savefile_Browsebutton.Text = "Browse...";
            this.Savefile_Browsebutton.UseVisualStyleBackColor = true;
            this.Savefile_Browsebutton.Click += new System.EventHandler(this.Savefile_Browsebutton_Click);
            // 
            // LoadFile_Pathbox
            // 
            this.LoadFile_Pathbox.AccessibleDescription = "The path and file names of the frames that will be used to render your animation." +
    "";
            this.LoadFile_Pathbox.AccessibleName = "Loading path";
            this.LoadFile_Pathbox.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoadFile_Pathbox.Location = new System.Drawing.Point(194, 44);
            this.LoadFile_Pathbox.MaximumSize = new System.Drawing.Size(811, 40);
            this.LoadFile_Pathbox.Name = "LoadFile_Pathbox";
            this.LoadFile_Pathbox.Size = new System.Drawing.Size(811, 35);
            this.LoadFile_Pathbox.TabIndex = 2;
            this.LoadFile_Pathbox.WordWrap = false;
            this.LoadFile_Pathbox.TextChanged += new System.EventHandler(this.LoadFile_Pathbox_TextChanged);
            // 
            // SaveFile_Pathbox
            // 
            this.SaveFile_Pathbox.AccessibleDescription = "The path and file name that your animation will be saved under.";
            this.SaveFile_Pathbox.AccessibleName = "Saving path";
            this.SaveFile_Pathbox.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveFile_Pathbox.Location = new System.Drawing.Point(194, 246);
            this.SaveFile_Pathbox.MaximumSize = new System.Drawing.Size(811, 40);
            this.SaveFile_Pathbox.Name = "SaveFile_Pathbox";
            this.SaveFile_Pathbox.Size = new System.Drawing.Size(811, 35);
            this.SaveFile_Pathbox.TabIndex = 3;
            this.SaveFile_Pathbox.WordWrap = false;
            this.SaveFile_Pathbox.TextChanged += new System.EventHandler(this.SaveFile_Pathbox_TextChanged);
            // 
            // Resize_Check
            // 
            this.Resize_Check.AccessibleDescription = "Select this option if you would like the size of the output animation file to be " +
    "different from the source files.";
            this.Resize_Check.AccessibleName = "Resize Output Checkbox";
            this.Resize_Check.AutoSize = true;
            this.Resize_Check.Location = new System.Drawing.Point(791, 124);
            this.Resize_Check.Name = "Resize_Check";
            this.Resize_Check.Size = new System.Drawing.Size(93, 17);
            this.Resize_Check.TabIndex = 7;
            this.Resize_Check.Text = "Resize Output";
            this.Resize_Check.UseVisualStyleBackColor = true;
            this.Resize_Check.CheckedChanged += new System.EventHandler(this.Resize_Check_CheckedChanged);
            // 
            // HeightLabel
            // 
            this.HeightLabel.AutoSize = true;
            this.HeightLabel.Enabled = false;
            this.HeightLabel.Location = new System.Drawing.Point(891, 124);
            this.HeightLabel.Name = "HeightLabel";
            this.HeightLabel.Size = new System.Drawing.Size(41, 13);
            this.HeightLabel.TabIndex = 10;
            this.HeightLabel.Text = "Height:";
            this.HeightLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // WidthLabel
            // 
            this.WidthLabel.AutoSize = true;
            this.WidthLabel.Enabled = false;
            this.WidthLabel.Location = new System.Drawing.Point(894, 150);
            this.WidthLabel.Name = "WidthLabel";
            this.WidthLabel.Size = new System.Drawing.Size(38, 13);
            this.WidthLabel.TabIndex = 11;
            this.WidthLabel.Text = "Width:";
            // 
            // HeightNumeric
            // 
            this.HeightNumeric.Enabled = false;
            this.HeightNumeric.Location = new System.Drawing.Point(935, 121);
            this.HeightNumeric.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.HeightNumeric.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.HeightNumeric.Name = "HeightNumeric";
            this.HeightNumeric.Size = new System.Drawing.Size(70, 20);
            this.HeightNumeric.TabIndex = 12;
            this.HeightNumeric.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.HeightNumeric.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.HeightNumeric.ValueChanged += new System.EventHandler(this.HeightNumeric_ValueChanged);
            // 
            // WidthNumeric
            // 
            this.WidthNumeric.Enabled = false;
            this.WidthNumeric.Location = new System.Drawing.Point(935, 148);
            this.WidthNumeric.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.WidthNumeric.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.WidthNumeric.Name = "WidthNumeric";
            this.WidthNumeric.Size = new System.Drawing.Size(70, 20);
            this.WidthNumeric.TabIndex = 13;
            this.WidthNumeric.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.WidthNumeric.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.WidthNumeric.ValueChanged += new System.EventHandler(this.WidthNumeric_ValueChanged);
            // 
            // fpsNumeric
            // 
            this.fpsNumeric.Location = new System.Drawing.Point(935, 174);
            this.fpsNumeric.Maximum = new decimal(new int[] {
            240,
            0,
            0,
            0});
            this.fpsNumeric.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.fpsNumeric.Name = "fpsNumeric";
            this.fpsNumeric.Size = new System.Drawing.Size(70, 20);
            this.fpsNumeric.TabIndex = 14;
            this.fpsNumeric.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.fpsNumeric.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.fpsNumeric.ValueChanged += new System.EventHandler(this.fpsNumeric_ValueChanged);
            // 
            // fpsLabel
            // 
            this.fpsLabel.AutoSize = true;
            this.fpsLabel.Location = new System.Drawing.Point(831, 176);
            this.fpsLabel.Name = "fpsLabel";
            this.fpsLabel.Size = new System.Drawing.Size(98, 13);
            this.fpsLabel.TabIndex = 15;
            this.fpsLabel.Text = "FPS (Default is 50):";
            // 
            // QualityLabel
            // 
            this.QualityLabel.AutoSize = true;
            this.QualityLabel.Location = new System.Drawing.Point(816, 202);
            this.QualityLabel.Name = "QualityLabel";
            this.QualityLabel.Size = new System.Drawing.Size(116, 13);
            this.QualityLabel.TabIndex = 17;
            this.QualityLabel.Text = "Quality (Default is 100):";
            // 
            // QualityNumeric
            // 
            this.QualityNumeric.Location = new System.Drawing.Point(935, 200);
            this.QualityNumeric.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.QualityNumeric.Name = "QualityNumeric";
            this.QualityNumeric.Size = new System.Drawing.Size(70, 20);
            this.QualityNumeric.TabIndex = 16;
            this.QualityNumeric.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.QualityNumeric.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.QualityNumeric.ValueChanged += new System.EventHandler(this.QualityNumeric_ValueChanged);
            // 
            // SourcesLabel
            // 
            this.SourcesLabel.AutoSize = true;
            this.SourcesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SourcesLabel.Location = new System.Drawing.Point(36, 53);
            this.SourcesLabel.Name = "SourcesLabel";
            this.SourcesLabel.Size = new System.Drawing.Size(152, 17);
            this.SourcesLabel.TabIndex = 18;
            this.SourcesLabel.Text = "Source Frames Folder:";
            this.SourcesLabel.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // DestinationLabel
            // 
            this.DestinationLabel.AutoSize = true;
            this.DestinationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DestinationLabel.Location = new System.Drawing.Point(105, 255);
            this.DestinationLabel.Name = "DestinationLabel";
            this.DestinationLabel.Size = new System.Drawing.Size(83, 17);
            this.DestinationLabel.TabIndex = 19;
            this.DestinationLabel.Text = "Destination:";
            // 
            // RenderButton
            // 
            this.RenderButton.AccessibleDescription = "Render the selected frames to the set output using the settings selected.";
            this.RenderButton.AccessibleName = "Render Button";
            this.RenderButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RenderButton.Location = new System.Drawing.Point(1040, 300);
            this.RenderButton.Name = "RenderButton";
            this.RenderButton.Size = new System.Drawing.Size(132, 52);
            this.RenderButton.TabIndex = 20;
            this.RenderButton.Text = "Render Animation";
            this.RenderButton.UseVisualStyleBackColor = true;
            this.RenderButton.Click += new System.EventHandler(this.RenderButton_Click);
            // 
            // helpButton
            // 
            this.helpButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.helpButton.Location = new System.Drawing.Point(65, 148);
            this.helpButton.Name = "helpButton";
            this.helpButton.Size = new System.Drawing.Size(108, 50);
            this.helpButton.TabIndex = 21;
            this.helpButton.Text = "Help";
            this.helpButton.UseVisualStyleBackColor = true;
            this.helpButton.Click += new System.EventHandler(this.helpButton_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1211, 366);
            this.Controls.Add(this.helpButton);
            this.Controls.Add(this.RenderButton);
            this.Controls.Add(this.DestinationLabel);
            this.Controls.Add(this.SourcesLabel);
            this.Controls.Add(this.QualityLabel);
            this.Controls.Add(this.QualityNumeric);
            this.Controls.Add(this.fpsLabel);
            this.Controls.Add(this.fpsNumeric);
            this.Controls.Add(this.WidthNumeric);
            this.Controls.Add(this.HeightNumeric);
            this.Controls.Add(this.WidthLabel);
            this.Controls.Add(this.HeightLabel);
            this.Controls.Add(this.Resize_Check);
            this.Controls.Add(this.SaveFile_Pathbox);
            this.Controls.Add(this.LoadFile_Pathbox);
            this.Controls.Add(this.Savefile_Browsebutton);
            this.Controls.Add(this.Loadfile_Browsebutton);
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "gifskiWinGUI";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.HeightNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WidthNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fpsNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.QualityNumeric)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Loadfile_Browsebutton;
        private System.Windows.Forms.Button Savefile_Browsebutton;
        private System.Windows.Forms.TextBox LoadFile_Pathbox;
        private System.Windows.Forms.TextBox SaveFile_Pathbox;
        private System.Windows.Forms.CheckBox Resize_Check;
        private System.Windows.Forms.Label HeightLabel;
        private System.Windows.Forms.Label WidthLabel;
        private System.Windows.Forms.NumericUpDown HeightNumeric;
        private System.Windows.Forms.NumericUpDown WidthNumeric;
        private System.Windows.Forms.NumericUpDown fpsNumeric;
        private System.Windows.Forms.Label fpsLabel;
        private System.Windows.Forms.Label QualityLabel;
        private System.Windows.Forms.NumericUpDown QualityNumeric;
        private System.Windows.Forms.Label SourcesLabel;
        private System.Windows.Forms.Label DestinationLabel;
        private System.Windows.Forms.Button RenderButton;
        private System.Windows.Forms.Button helpButton;
    }
}

