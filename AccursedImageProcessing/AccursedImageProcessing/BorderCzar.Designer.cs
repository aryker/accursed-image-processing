namespace AccursedImageProcessing
{
    partial class BorderCzar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BorderCzar));
            this.instructionsLabel = new System.Windows.Forms.Label();
            this.directoryLabel = new System.Windows.Forms.Label();
            this.directoryTextBox = new System.Windows.Forms.TextBox();
            this.directoryButton = new System.Windows.Forms.Button();
            this.borderColorLabel = new System.Windows.Forms.Label();
            this.colorPickerButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.processButton = new System.Windows.Forms.Button();
            this.progressLabel = new System.Windows.Forms.Label();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.backgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // instructionsLabel
            // 
            this.instructionsLabel.AutoSize = true;
            this.instructionsLabel.ForeColor = System.Drawing.Color.Red;
            this.instructionsLabel.Location = new System.Drawing.Point(12, 9);
            this.instructionsLabel.Name = "instructionsLabel";
            this.instructionsLabel.Size = new System.Drawing.Size(415, 75);
            this.instructionsLabel.TabIndex = 0;
            this.instructionsLabel.Text = resources.GetString("instructionsLabel.Text");
            // 
            // directoryLabel
            // 
            this.directoryLabel.AutoSize = true;
            this.directoryLabel.Location = new System.Drawing.Point(12, 102);
            this.directoryLabel.Name = "directoryLabel";
            this.directoryLabel.Size = new System.Drawing.Size(58, 15);
            this.directoryLabel.TabIndex = 1;
            this.directoryLabel.Text = "Directory:";
            // 
            // directoryTextBox
            // 
            this.directoryTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.directoryTextBox.Location = new System.Drawing.Point(76, 99);
            this.directoryTextBox.Name = "directoryTextBox";
            this.directoryTextBox.Size = new System.Drawing.Size(340, 23);
            this.directoryTextBox.TabIndex = 2;
            this.directoryTextBox.TextChanged += new System.EventHandler(this.directoryTextBox_TextChanged);
            // 
            // directoryButton
            // 
            this.directoryButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.directoryButton.Location = new System.Drawing.Point(422, 99);
            this.directoryButton.Name = "directoryButton";
            this.directoryButton.Size = new System.Drawing.Size(46, 23);
            this.directoryButton.TabIndex = 3;
            this.directoryButton.Text = "...";
            this.directoryButton.UseVisualStyleBackColor = true;
            this.directoryButton.Click += new System.EventHandler(this.directoryButton_Click);
            // 
            // borderColorLabel
            // 
            this.borderColorLabel.AutoSize = true;
            this.borderColorLabel.Location = new System.Drawing.Point(12, 146);
            this.borderColorLabel.Name = "borderColorLabel";
            this.borderColorLabel.Size = new System.Drawing.Size(119, 15);
            this.borderColorLabel.TabIndex = 4;
            this.borderColorLabel.Text = "Desired Border Color:";
            // 
            // colorPickerButton
            // 
            this.colorPickerButton.BackColor = System.Drawing.Color.Magenta;
            this.colorPickerButton.ForeColor = System.Drawing.Color.Magenta;
            this.colorPickerButton.Location = new System.Drawing.Point(137, 136);
            this.colorPickerButton.Name = "colorPickerButton";
            this.colorPickerButton.Size = new System.Drawing.Size(40, 35);
            this.colorPickerButton.TabIndex = 5;
            this.colorPickerButton.UseVisualStyleBackColor = false;
            this.colorPickerButton.Click += new System.EventHandler(this.colorPickerButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(12, 223);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(228, 57);
            this.exitButton.TabIndex = 6;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // processButton
            // 
            this.processButton.Location = new System.Drawing.Point(246, 223);
            this.processButton.Name = "processButton";
            this.processButton.Size = new System.Drawing.Size(228, 57);
            this.processButton.TabIndex = 7;
            this.processButton.Text = "Process";
            this.processButton.UseVisualStyleBackColor = true;
            this.processButton.Click += new System.EventHandler(this.processButton_Click);
            // 
            // progressLabel
            // 
            this.progressLabel.AutoSize = true;
            this.progressLabel.Location = new System.Drawing.Point(15, 186);
            this.progressLabel.Name = "progressLabel";
            this.progressLabel.Size = new System.Drawing.Size(55, 15);
            this.progressLabel.TabIndex = 8;
            this.progressLabel.Text = "Progress:";
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(76, 184);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(392, 23);
            this.progressBar.TabIndex = 9;
            // 
            // backgroundWorker
            // 
            this.backgroundWorker.WorkerReportsProgress = true;
            this.backgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker_DoWork);
            this.backgroundWorker.ProgressChanged += backgroundWorker_ProgressChanged;
            // 
            // BorderCzar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 294);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.progressLabel);
            this.Controls.Add(this.processButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.colorPickerButton);
            this.Controls.Add(this.borderColorLabel);
            this.Controls.Add(this.directoryButton);
            this.Controls.Add(this.directoryTextBox);
            this.Controls.Add(this.directoryLabel);
            this.Controls.Add(this.instructionsLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BorderCzar";
            this.Text = "BorderCzar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label instructionsLabel;
        private Label directoryLabel;
        private TextBox directoryTextBox;
        private Button directoryButton;
        private Label borderColorLabel;
        private Button colorPickerButton;
        private Button exitButton;
        private Button processButton;
        private Label progressLabel;
        private ProgressBar progressBar;
        private System.ComponentModel.BackgroundWorker backgroundWorker;
    }
}