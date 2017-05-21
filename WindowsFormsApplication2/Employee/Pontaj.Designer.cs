namespace WindowsFormsApplication2.Employee
{
    partial class Pontaj
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
            this.checkInLabel = new System.Windows.Forms.Label();
            this.checkOutLabel = new System.Windows.Forms.Label();
            this.finishButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.checkInPicker = new System.Windows.Forms.DateTimePicker();
            this.checkOutPicker = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // checkInLabel
            // 
            this.checkInLabel.AutoSize = true;
            this.checkInLabel.Location = new System.Drawing.Point(38, 50);
            this.checkInLabel.Name = "checkInLabel";
            this.checkInLabel.Size = new System.Drawing.Size(50, 13);
            this.checkInLabel.TabIndex = 0;
            this.checkInLabel.Text = "Check-In";
            // 
            // checkOutLabel
            // 
            this.checkOutLabel.AutoSize = true;
            this.checkOutLabel.Location = new System.Drawing.Point(38, 109);
            this.checkOutLabel.Name = "checkOutLabel";
            this.checkOutLabel.Size = new System.Drawing.Size(58, 13);
            this.checkOutLabel.TabIndex = 1;
            this.checkOutLabel.Text = "Check-Out";
            // 
            // finishButton
            // 
            this.finishButton.Location = new System.Drawing.Point(197, 218);
            this.finishButton.Name = "finishButton";
            this.finishButton.Size = new System.Drawing.Size(75, 23);
            this.finishButton.TabIndex = 2;
            this.finishButton.Text = "Finish";
            this.finishButton.UseVisualStyleBackColor = true;
            this.finishButton.Click += new System.EventHandler(this.finishButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(13, 218);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 3;
            this.exitButton.Text = "Close";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // checkInPicker
            // 
            this.checkInPicker.Cursor = System.Windows.Forms.Cursors.Default;
            this.checkInPicker.CustomFormat = "\"hh:mm:ss\"";
            this.checkInPicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.checkInPicker.Location = new System.Drawing.Point(139, 50);
            this.checkInPicker.Name = "checkInPicker";
            this.checkInPicker.ShowUpDown = true;
            this.checkInPicker.Size = new System.Drawing.Size(83, 20);
            this.checkInPicker.TabIndex = 4;
            // 
            // checkOutPicker
            // 
            this.checkOutPicker.CustomFormat = "\"hh:mm:ss\"";
            this.checkOutPicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.checkOutPicker.Location = new System.Drawing.Point(139, 109);
            this.checkOutPicker.Name = "checkOutPicker";
            this.checkOutPicker.ShowUpDown = true;
            this.checkOutPicker.Size = new System.Drawing.Size(83, 20);
            this.checkOutPicker.TabIndex = 5;
            // 
            // Pontaj
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.checkOutPicker);
            this.Controls.Add(this.checkInPicker);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.finishButton);
            this.Controls.Add(this.checkOutLabel);
            this.Controls.Add(this.checkInLabel);
            this.Name = "Pontaj";
            this.Text = "Pontaj";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label checkInLabel;
        private System.Windows.Forms.Label checkOutLabel;
        private System.Windows.Forms.Button finishButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.DateTimePicker checkInPicker;
        private System.Windows.Forms.DateTimePicker checkOutPicker;
    }
}