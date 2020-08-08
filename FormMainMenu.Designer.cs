namespace nikebot
{
    partial class FormMainMenu
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

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.ProxyBtn = new FontAwesome.Sharp.IconButton();
            this.SettingsBtn = new FontAwesome.Sharp.IconButton();
            this.TasksBtn = new FontAwesome.Sharp.IconButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.CloseBtn = new FontAwesome.Sharp.IconButton();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.panel1.Controls.Add(this.iconButton1);
            this.panel1.Controls.Add(this.ProxyBtn);
            this.panel1.Controls.Add(this.SettingsBtn);
            this.panel1.Controls.Add(this.TasksBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(163, 450);
            this.panel1.TabIndex = 0;
            // 
            // iconButton1
            // 
            this.iconButton1.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButton1.Font = new System.Drawing.Font("HelvLight", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton1.ForeColor = System.Drawing.Color.Gainsboro;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.Users;
            this.iconButton1.IconColor = System.Drawing.Color.Gainsboro;
            this.iconButton1.IconSize = 25;
            this.iconButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton1.Location = new System.Drawing.Point(0, 135);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.iconButton1.Rotation = 0D;
            this.iconButton1.Size = new System.Drawing.Size(163, 45);
            this.iconButton1.TabIndex = 5;
            this.iconButton1.Text = "Profiles";
            this.iconButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton1.UseVisualStyleBackColor = true;
            // 
            // ProxyBtn
            // 
            this.ProxyBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.ProxyBtn.FlatAppearance.BorderSize = 0;
            this.ProxyBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ProxyBtn.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.ProxyBtn.Font = new System.Drawing.Font("HelvLight", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProxyBtn.ForeColor = System.Drawing.Color.Gainsboro;
            this.ProxyBtn.IconChar = FontAwesome.Sharp.IconChar.Server;
            this.ProxyBtn.IconColor = System.Drawing.Color.Gainsboro;
            this.ProxyBtn.IconSize = 25;
            this.ProxyBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ProxyBtn.Location = new System.Drawing.Point(0, 90);
            this.ProxyBtn.Name = "ProxyBtn";
            this.ProxyBtn.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.ProxyBtn.Rotation = 0D;
            this.ProxyBtn.Size = new System.Drawing.Size(163, 45);
            this.ProxyBtn.TabIndex = 4;
            this.ProxyBtn.Text = "Proxy";
            this.ProxyBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ProxyBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ProxyBtn.UseVisualStyleBackColor = true;
            // 
            // SettingsBtn
            // 
            this.SettingsBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.SettingsBtn.FlatAppearance.BorderSize = 0;
            this.SettingsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SettingsBtn.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.SettingsBtn.Font = new System.Drawing.Font("HelvLight", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SettingsBtn.ForeColor = System.Drawing.Color.Gainsboro;
            this.SettingsBtn.IconChar = FontAwesome.Sharp.IconChar.Cog;
            this.SettingsBtn.IconColor = System.Drawing.Color.Gainsboro;
            this.SettingsBtn.IconSize = 25;
            this.SettingsBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SettingsBtn.Location = new System.Drawing.Point(0, 45);
            this.SettingsBtn.Name = "SettingsBtn";
            this.SettingsBtn.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.SettingsBtn.Rotation = 0D;
            this.SettingsBtn.Size = new System.Drawing.Size(163, 45);
            this.SettingsBtn.TabIndex = 3;
            this.SettingsBtn.Text = "Settings";
            this.SettingsBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SettingsBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.SettingsBtn.UseVisualStyleBackColor = true;
            // 
            // TasksBtn
            // 
            this.TasksBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.TasksBtn.FlatAppearance.BorderSize = 0;
            this.TasksBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TasksBtn.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.TasksBtn.Font = new System.Drawing.Font("HelvLight", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TasksBtn.ForeColor = System.Drawing.Color.Gainsboro;
            this.TasksBtn.IconChar = FontAwesome.Sharp.IconChar.Tasks;
            this.TasksBtn.IconColor = System.Drawing.Color.Gainsboro;
            this.TasksBtn.IconSize = 25;
            this.TasksBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.TasksBtn.Location = new System.Drawing.Point(0, 0);
            this.TasksBtn.Name = "TasksBtn";
            this.TasksBtn.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.TasksBtn.Rotation = 0D;
            this.TasksBtn.Size = new System.Drawing.Size(163, 45);
            this.TasksBtn.TabIndex = 1;
            this.TasksBtn.Text = "Tasks";
            this.TasksBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.TasksBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.TasksBtn.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(163, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(637, 450);
            this.panel2.TabIndex = 1;
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseDown);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.panel3.Controls.Add(this.CloseBtn);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(637, 39);
            this.panel3.TabIndex = 0;
            // 
            // CloseBtn
            // 
            this.CloseBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(24)))), ((int)(((byte)(28)))));
            this.CloseBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.CloseBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseBtn.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.CloseBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(24)))), ((int)(((byte)(28)))));
            this.CloseBtn.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.CloseBtn.IconColor = System.Drawing.Color.Gainsboro;
            this.CloseBtn.IconSize = 16;
            this.CloseBtn.Location = new System.Drawing.Point(601, 0);
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.Rotation = 0D;
            this.CloseBtn.Size = new System.Drawing.Size(36, 39);
            this.CloseBtn.TabIndex = 0;
            this.CloseBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.CloseBtn.UseVisualStyleBackColor = false;
            this.CloseBtn.Click += new System.EventHandler(this.CloseBtn_Click);
            // 
            // FormMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormMainMenu";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton TasksBtn;
        private FontAwesome.Sharp.IconButton SettingsBtn;
        private FontAwesome.Sharp.IconButton ProxyBtn;
        private FontAwesome.Sharp.IconButton iconButton1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private FontAwesome.Sharp.IconButton CloseBtn;
    }
}

