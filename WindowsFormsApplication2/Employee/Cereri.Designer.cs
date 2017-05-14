namespace WindowsFormsApplication2.Employee
{
    partial class Cereri
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
            this.exitButton = new System.Windows.Forms.Button();
            this.okButton = new System.Windows.Forms.Button();
            this.cereriComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(13, 226);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 0;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(197, 226);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 1;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // cereriComboBox
            // 
            this.cereriComboBox.FormattingEnabled = true;
            this.cereriComboBox.Items.AddRange(new object[] {
            "Adeverinte",
            "Concediu"});
            this.cereriComboBox.Location = new System.Drawing.Point(80, 89);
            this.cereriComboBox.Name = "cereriComboBox";
            this.cereriComboBox.Size = new System.Drawing.Size(121, 21);
            this.cereriComboBox.TabIndex = 2;
            // 
            // Cereri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(286, 253);
            this.Controls.Add(this.cereriComboBox);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.exitButton);
            this.Name = "Cereri";
            this.Text = "Cereri";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.ComboBox cereriComboBox;
    }
}