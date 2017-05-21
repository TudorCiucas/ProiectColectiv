namespace WindowsFormsApplication2
{
    partial class HRForm
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
            this.logoutButton = new System.Windows.Forms.Button();
            this.pontajColectivButton = new System.Windows.Forms.Button();
            this.pontajPropriuButton = new System.Windows.Forms.Button();
            this.alerteButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // logoutButton
            // 
            this.logoutButton.Location = new System.Drawing.Point(13, 226);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(75, 23);
            this.logoutButton.TabIndex = 0;
            this.logoutButton.Text = "Log out";
            this.logoutButton.UseVisualStyleBackColor = true;
            this.logoutButton.Click += new System.EventHandler(this.logoutButton_Click);
            // 
            // pontajColectivButton
            // 
            this.pontajColectivButton.Location = new System.Drawing.Point(92, 49);
            this.pontajColectivButton.Name = "pontajColectivButton";
            this.pontajColectivButton.Size = new System.Drawing.Size(111, 23);
            this.pontajColectivButton.TabIndex = 2;
            this.pontajColectivButton.Text = "Pontaj Coelctiv";
            this.pontajColectivButton.UseVisualStyleBackColor = true;
            this.pontajColectivButton.Click += new System.EventHandler(this.pontajColectivButton_Click);
            // 
            // pontajPropriuButton
            // 
            this.pontajPropriuButton.Location = new System.Drawing.Point(92, 12);
            this.pontajPropriuButton.Name = "pontajPropriuButton";
            this.pontajPropriuButton.Size = new System.Drawing.Size(111, 23);
            this.pontajPropriuButton.TabIndex = 3;
            this.pontajPropriuButton.Text = "Pontaj Propriu";
            this.pontajPropriuButton.UseVisualStyleBackColor = true;
            this.pontajPropriuButton.Click += new System.EventHandler(this.pontajPropriuButton_Click);
            // 
            // alerteButton
            // 
            this.alerteButton.Location = new System.Drawing.Point(92, 87);
            this.alerteButton.Name = "alerteButton";
            this.alerteButton.Size = new System.Drawing.Size(111, 23);
            this.alerteButton.TabIndex = 4;
            this.alerteButton.Text = "Alerte";
            this.alerteButton.UseVisualStyleBackColor = true;
            this.alerteButton.Click += new System.EventHandler(this.alerteButton_Click);
            // 
            // HRForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.alerteButton);
            this.Controls.Add(this.pontajPropriuButton);
            this.Controls.Add(this.pontajColectivButton);
            this.Controls.Add(this.logoutButton);
            this.Name = "HRForm";
            this.Text = "HRForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button logoutButton;
        private System.Windows.Forms.Button pontajColectivButton;
        private System.Windows.Forms.Button pontajPropriuButton;
        private System.Windows.Forms.Button alerteButton;
    }
}