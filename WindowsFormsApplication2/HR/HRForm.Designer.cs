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
            this.reportGenButton = new System.Windows.Forms.Button();
            this.pontajAngajatiButton = new System.Windows.Forms.Button();
            this.requestsButton = new System.Windows.Forms.Button();
            this.alertButton = new System.Windows.Forms.Button();
            this.historyButton = new System.Windows.Forms.Button();
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
            // reportGenButton
            // 
            this.reportGenButton.Location = new System.Drawing.Point(92, 97);
            this.reportGenButton.Name = "reportGenButton";
            this.reportGenButton.Size = new System.Drawing.Size(111, 23);
            this.reportGenButton.TabIndex = 1;
            this.reportGenButton.Text = "Generare Raport";
            this.reportGenButton.UseVisualStyleBackColor = true;
            this.reportGenButton.Click += new System.EventHandler(this.reportGenButton_Click);
            // 
            // pontajAngajatiButton
            // 
            this.pontajAngajatiButton.Location = new System.Drawing.Point(92, 55);
            this.pontajAngajatiButton.Name = "pontajAngajatiButton";
            this.pontajAngajatiButton.Size = new System.Drawing.Size(111, 23);
            this.pontajAngajatiButton.TabIndex = 2;
            this.pontajAngajatiButton.Text = "Pontaj Angajati";
            this.pontajAngajatiButton.UseVisualStyleBackColor = true;
            // 
            // requestsButton
            // 
            this.requestsButton.Location = new System.Drawing.Point(92, 12);
            this.requestsButton.Name = "requestsButton";
            this.requestsButton.Size = new System.Drawing.Size(111, 23);
            this.requestsButton.TabIndex = 3;
            this.requestsButton.Text = "Vizualizare Cereri";
            this.requestsButton.UseVisualStyleBackColor = true;
            // 
            // alertButton
            // 
            this.alertButton.Location = new System.Drawing.Point(92, 140);
            this.alertButton.Name = "alertButton";
            this.alertButton.Size = new System.Drawing.Size(111, 23);
            this.alertButton.TabIndex = 4;
            this.alertButton.Text = "Alerta";
            this.alertButton.UseVisualStyleBackColor = true;
            // 
            // historyButton
            // 
            this.historyButton.Location = new System.Drawing.Point(92, 181);
            this.historyButton.Name = "historyButton";
            this.historyButton.Size = new System.Drawing.Size(111, 23);
            this.historyButton.TabIndex = 5;
            this.historyButton.Text = "Istoric";
            this.historyButton.UseVisualStyleBackColor = true;
            // 
            // HRForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.historyButton);
            this.Controls.Add(this.alertButton);
            this.Controls.Add(this.requestsButton);
            this.Controls.Add(this.pontajAngajatiButton);
            this.Controls.Add(this.reportGenButton);
            this.Controls.Add(this.logoutButton);
            this.Name = "HRForm";
            this.Text = "HRForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button logoutButton;
        private System.Windows.Forms.Button reportGenButton;
        private System.Windows.Forms.Button pontajAngajatiButton;
        private System.Windows.Forms.Button requestsButton;
        private System.Windows.Forms.Button alertButton;
        private System.Windows.Forms.Button historyButton;
    }
}