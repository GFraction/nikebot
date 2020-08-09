namespace nikebot
{
    partial class Form1
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
            this.ChromePanel = new System.Windows.Forms.Panel();
            this.UrlAdress = new System.Windows.Forms.TextBox();
            this.Exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ChromePanel
            // 
            this.ChromePanel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ChromePanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ChromePanel.Location = new System.Drawing.Point(0, 40);
            this.ChromePanel.Name = "ChromePanel";
            this.ChromePanel.Size = new System.Drawing.Size(775, 548);
            this.ChromePanel.TabIndex = 0;
            this.ChromePanel.Paint += new System.Windows.Forms.PaintEventHandler(Panel1_Paint);
            // 
            // UrlAdress
            // 
            this.UrlAdress.Dock = System.Windows.Forms.DockStyle.Top;
            this.UrlAdress.Location = new System.Drawing.Point(0, 0);
            this.UrlAdress.Name = "UrlAdress";
            this.UrlAdress.Size = new System.Drawing.Size(775, 20);
            this.UrlAdress.TabIndex = 1;
            this.UrlAdress.TextChanged += new System.EventHandler(this.UrlAdress_TextChanged);
            this.UrlAdress.KeyDown += new System.Windows.Forms.KeyEventHandler(this.UrlAdress_KeyDown);
            // 
            // Exit
            // 
            this.Exit.Dock = System.Windows.Forms.DockStyle.Left;
            this.Exit.Location = new System.Drawing.Point(0, 20);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(93, 20);
            this.Exit.TabIndex = 2;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(775, 588);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.UrlAdress);
            this.Controls.Add(this.ChromePanel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Panel ChromePanel;
        private System.Windows.Forms.TextBox UrlAdress;
        private System.Windows.Forms.Button Exit;
    }
}