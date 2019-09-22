namespace PhotoSort
{
    partial class PhotoSortForm
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
            this.TopContainer = new System.Windows.Forms.SplitContainer();
            this.StatsTextBox = new System.Windows.Forms.TextBox();
            this.BottomContainer = new System.Windows.Forms.SplitContainer();
            this.PhotoContainer = new System.Windows.Forms.SplitContainer();
            this.ReferencePictureBox = new System.Windows.Forms.PictureBox();
            this.TargetPictureBox = new System.Windows.Forms.PictureBox();
            this.EstimatedYearButton = new System.Windows.Forms.Button();
            this.EstimateYearMonthButton = new System.Windows.Forms.Button();
            this.NewReferenceButton = new System.Windows.Forms.Button();
            this.DateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.ConfirmDateButton = new System.Windows.Forms.Button();
            this.OlderButton = new System.Windows.Forms.Button();
            this.NewerButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.TopContainer)).BeginInit();
            this.TopContainer.Panel1.SuspendLayout();
            this.TopContainer.Panel2.SuspendLayout();
            this.TopContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BottomContainer)).BeginInit();
            this.BottomContainer.Panel1.SuspendLayout();
            this.BottomContainer.Panel2.SuspendLayout();
            this.BottomContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PhotoContainer)).BeginInit();
            this.PhotoContainer.Panel1.SuspendLayout();
            this.PhotoContainer.Panel2.SuspendLayout();
            this.PhotoContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ReferencePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TargetPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // TopContainer
            // 
            this.TopContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TopContainer.Location = new System.Drawing.Point(0, 0);
            this.TopContainer.Name = "TopContainer";
            this.TopContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // TopContainer.Panel1
            // 
            this.TopContainer.Panel1.Controls.Add(this.StatsTextBox);
            // 
            // TopContainer.Panel2
            // 
            this.TopContainer.Panel2.Controls.Add(this.BottomContainer);
            this.TopContainer.Size = new System.Drawing.Size(1032, 643);
            this.TopContainer.SplitterDistance = 87;
            this.TopContainer.TabIndex = 0;
            // 
            // StatsTextBox
            // 
            this.StatsTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StatsTextBox.Location = new System.Drawing.Point(0, 0);
            this.StatsTextBox.Multiline = true;
            this.StatsTextBox.Name = "StatsTextBox";
            this.StatsTextBox.Size = new System.Drawing.Size(1032, 87);
            this.StatsTextBox.TabIndex = 0;
            // 
            // BottomContainer
            // 
            this.BottomContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BottomContainer.Location = new System.Drawing.Point(0, 0);
            this.BottomContainer.Name = "BottomContainer";
            this.BottomContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // BottomContainer.Panel1
            // 
            this.BottomContainer.Panel1.Controls.Add(this.PhotoContainer);
            // 
            // BottomContainer.Panel2
            // 
            this.BottomContainer.Panel2.Controls.Add(this.EstimatedYearButton);
            this.BottomContainer.Panel2.Controls.Add(this.EstimateYearMonthButton);
            this.BottomContainer.Panel2.Controls.Add(this.NewReferenceButton);
            this.BottomContainer.Panel2.Controls.Add(this.DateTimePicker);
            this.BottomContainer.Panel2.Controls.Add(this.ConfirmDateButton);
            this.BottomContainer.Panel2.Controls.Add(this.OlderButton);
            this.BottomContainer.Panel2.Controls.Add(this.NewerButton);
            this.BottomContainer.Size = new System.Drawing.Size(1032, 552);
            this.BottomContainer.SplitterDistance = 443;
            this.BottomContainer.TabIndex = 0;
            // 
            // PhotoContainer
            // 
            this.PhotoContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PhotoContainer.Location = new System.Drawing.Point(0, 0);
            this.PhotoContainer.Name = "PhotoContainer";
            // 
            // PhotoContainer.Panel1
            // 
            this.PhotoContainer.Panel1.Controls.Add(this.ReferencePictureBox);
            // 
            // PhotoContainer.Panel2
            // 
            this.PhotoContainer.Panel2.Controls.Add(this.TargetPictureBox);
            this.PhotoContainer.Size = new System.Drawing.Size(1032, 443);
            this.PhotoContainer.SplitterDistance = 490;
            this.PhotoContainer.TabIndex = 0;
            // 
            // ReferencePictureBox
            // 
            this.ReferencePictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ReferencePictureBox.Location = new System.Drawing.Point(0, 0);
            this.ReferencePictureBox.Name = "ReferencePictureBox";
            this.ReferencePictureBox.Size = new System.Drawing.Size(490, 443);
            this.ReferencePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ReferencePictureBox.TabIndex = 0;
            this.ReferencePictureBox.TabStop = false;
            // 
            // TargetPictureBox
            // 
            this.TargetPictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TargetPictureBox.Location = new System.Drawing.Point(0, 0);
            this.TargetPictureBox.Name = "TargetPictureBox";
            this.TargetPictureBox.Size = new System.Drawing.Size(538, 443);
            this.TargetPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.TargetPictureBox.TabIndex = 0;
            this.TargetPictureBox.TabStop = false;
            // 
            // EstimatedYearButton
            // 
            this.EstimatedYearButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.EstimatedYearButton.Location = new System.Drawing.Point(686, 32);
            this.EstimatedYearButton.Name = "EstimatedYearButton";
            this.EstimatedYearButton.Size = new System.Drawing.Size(101, 20);
            this.EstimatedYearButton.TabIndex = 7;
            this.EstimatedYearButton.Text = "Estimated Year";
            this.EstimatedYearButton.UseVisualStyleBackColor = true;
            this.EstimatedYearButton.Click += new System.EventHandler(this.EstimatedYearButton_Click);
            // 
            // EstimateYearMonthButton
            // 
            this.EstimateYearMonthButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.EstimateYearMonthButton.Location = new System.Drawing.Point(793, 32);
            this.EstimateYearMonthButton.Name = "EstimateYearMonthButton";
            this.EstimateYearMonthButton.Size = new System.Drawing.Size(128, 20);
            this.EstimateYearMonthButton.TabIndex = 6;
            this.EstimateYearMonthButton.Text = "Estimated Year-Month";
            this.EstimateYearMonthButton.UseVisualStyleBackColor = true;
            this.EstimateYearMonthButton.Click += new System.EventHandler(this.EstimateYearMonthButton_Click);
            // 
            // NewReferenceButton
            // 
            this.NewReferenceButton.Location = new System.Drawing.Point(12, 2);
            this.NewReferenceButton.Name = "NewReferenceButton";
            this.NewReferenceButton.Size = new System.Drawing.Size(106, 23);
            this.NewReferenceButton.TabIndex = 5;
            this.NewReferenceButton.Text = "New Reference";
            this.NewReferenceButton.UseVisualStyleBackColor = true;
            this.NewReferenceButton.Click += new System.EventHandler(this.NewReferenceButton_Click);
            // 
            // DateTimePicker
            // 
            this.DateTimePicker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateTimePicker.Location = new System.Drawing.Point(462, 32);
            this.DateTimePicker.Name = "DateTimePicker";
            this.DateTimePicker.ShowCheckBox = true;
            this.DateTimePicker.Size = new System.Drawing.Size(218, 20);
            this.DateTimePicker.TabIndex = 4;
            // 
            // ConfirmDateButton
            // 
            this.ConfirmDateButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ConfirmDateButton.Location = new System.Drawing.Point(927, 32);
            this.ConfirmDateButton.Name = "ConfirmDateButton";
            this.ConfirmDateButton.Size = new System.Drawing.Size(93, 20);
            this.ConfirmDateButton.TabIndex = 3;
            this.ConfirmDateButton.Text = "Confirm Date";
            this.ConfirmDateButton.UseVisualStyleBackColor = true;
            this.ConfirmDateButton.Click += new System.EventHandler(this.ConfirmDateButton_Click);
            // 
            // OlderButton
            // 
            this.OlderButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.OlderButton.Location = new System.Drawing.Point(828, 3);
            this.OlderButton.Name = "OlderButton";
            this.OlderButton.Size = new System.Drawing.Size(93, 23);
            this.OlderButton.TabIndex = 2;
            this.OlderButton.Text = "Older";
            this.OlderButton.UseVisualStyleBackColor = true;
            this.OlderButton.Click += new System.EventHandler(this.OlderButton_Click);
            // 
            // NewerButton
            // 
            this.NewerButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.NewerButton.Location = new System.Drawing.Point(927, 3);
            this.NewerButton.Name = "NewerButton";
            this.NewerButton.Size = new System.Drawing.Size(93, 23);
            this.NewerButton.TabIndex = 1;
            this.NewerButton.Text = "Newer";
            this.NewerButton.UseVisualStyleBackColor = true;
            this.NewerButton.Click += new System.EventHandler(this.NewerButton_Click);
            // 
            // PhotoSortForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1032, 643);
            this.Controls.Add(this.TopContainer);
            this.Name = "PhotoSortForm";
            this.Text = "Photo Sort";
            this.Resize += new System.EventHandler(this.PhotoSortForm_Resize);
            this.TopContainer.Panel1.ResumeLayout(false);
            this.TopContainer.Panel1.PerformLayout();
            this.TopContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TopContainer)).EndInit();
            this.TopContainer.ResumeLayout(false);
            this.BottomContainer.Panel1.ResumeLayout(false);
            this.BottomContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BottomContainer)).EndInit();
            this.BottomContainer.ResumeLayout(false);
            this.PhotoContainer.Panel1.ResumeLayout(false);
            this.PhotoContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PhotoContainer)).EndInit();
            this.PhotoContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ReferencePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TargetPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer TopContainer;
        private System.Windows.Forms.SplitContainer BottomContainer;
        private System.Windows.Forms.SplitContainer PhotoContainer;
        private System.Windows.Forms.PictureBox ReferencePictureBox;
        private System.Windows.Forms.PictureBox TargetPictureBox;
        private System.Windows.Forms.Button NewReferenceButton;
        private System.Windows.Forms.DateTimePicker DateTimePicker;
        private System.Windows.Forms.Button ConfirmDateButton;
        private System.Windows.Forms.Button OlderButton;
        private System.Windows.Forms.Button NewerButton;
        private System.Windows.Forms.Button EstimatedYearButton;
        private System.Windows.Forms.Button EstimateYearMonthButton;
        private System.Windows.Forms.TextBox StatsTextBox;
    }
}

