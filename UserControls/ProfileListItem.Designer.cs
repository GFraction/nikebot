namespace nikebot.UserControls
{
    partial class ProfileListItem
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.NameLabel = new System.Windows.Forms.Label();
            this.SurnameLabel = new System.Windows.Forms.Label();
            this.DeleteBtn = new FontAwesome.Sharp.IconButton();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.panel1.Controls.Add(this.DeleteBtn);
            this.panel1.Controls.Add(this.SurnameLabel);
            this.panel1.Controls.Add(this.NameLabel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(852, 43);
            this.panel1.TabIndex = 0;
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.ForeColor = System.Drawing.Color.Gainsboro;
            this.NameLabel.Location = new System.Drawing.Point(34, 14);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(35, 13);
            this.NameLabel.TabIndex = 0;
            this.NameLabel.Text = "Name";
            // 
            // SurnameLabel
            // 
            this.SurnameLabel.AutoSize = true;
            this.SurnameLabel.ForeColor = System.Drawing.Color.Gainsboro;
            this.SurnameLabel.Location = new System.Drawing.Point(105, 14);
            this.SurnameLabel.Name = "SurnameLabel";
            this.SurnameLabel.Size = new System.Drawing.Size(49, 13);
            this.SurnameLabel.TabIndex = 1;
            this.SurnameLabel.Text = "Surname";
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DeleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteBtn.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.DeleteBtn.ForeColor = System.Drawing.Color.Gainsboro;
            this.DeleteBtn.IconChar = FontAwesome.Sharp.IconChar.None;
            this.DeleteBtn.IconColor = System.Drawing.Color.Black;
            this.DeleteBtn.IconSize = 16;
            this.DeleteBtn.Location = new System.Drawing.Point(765, 9);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Rotation = 0D;
            this.DeleteBtn.Size = new System.Drawing.Size(75, 23);
            this.DeleteBtn.TabIndex = 2;
            this.DeleteBtn.Text = "Delete";
            this.DeleteBtn.UseVisualStyleBackColor = true;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // ProfileListItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.panel1);
            this.Name = "ProfileListItem";
            this.Size = new System.Drawing.Size(852, 43);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label SurnameLabel;
        private System.Windows.Forms.Label NameLabel;
        private FontAwesome.Sharp.IconButton DeleteBtn;
    }
}
