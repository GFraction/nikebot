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
            this.ProfilesBtn = new FontAwesome.Sharp.IconButton();
            this.ProxyBtn = new FontAwesome.Sharp.IconButton();
            this.SettingsBtn = new FontAwesome.Sharp.IconButton();
            this.TasksBtn = new FontAwesome.Sharp.IconButton();
            this.panelChildForm = new System.Windows.Forms.Panel();
            this.HoldPanel = new System.Windows.Forms.Panel();
            this.CloseBtn = new FontAwesome.Sharp.IconButton();
            this.panel1.SuspendLayout();
            this.panelChildForm.SuspendLayout();
            this.HoldPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.panel1.Controls.Add(this.ProfilesBtn);
            this.panel1.Controls.Add(this.ProxyBtn);
            this.panel1.Controls.Add(this.SettingsBtn);
            this.panel1.Controls.Add(this.TasksBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(163, 553);
            this.panel1.TabIndex = 0;
            // 
            // ProfilesBtn
            // 
            this.ProfilesBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.ProfilesBtn.FlatAppearance.BorderSize = 0;
            this.ProfilesBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ProfilesBtn.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.ProfilesBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProfilesBtn.ForeColor = System.Drawing.Color.Gainsboro;
            this.ProfilesBtn.IconChar = FontAwesome.Sharp.IconChar.Users;
            this.ProfilesBtn.IconColor = System.Drawing.Color.Gainsboro;
            this.ProfilesBtn.IconSize = 25;
            this.ProfilesBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ProfilesBtn.Location = new System.Drawing.Point(0, 414);
            this.ProfilesBtn.Name = "ProfilesBtn";
            this.ProfilesBtn.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.ProfilesBtn.Rotation = 0D;
            this.ProfilesBtn.Size = new System.Drawing.Size(163, 138);
            this.ProfilesBtn.TabIndex = 5;
            this.ProfilesBtn.Text = "Profiles";
            this.ProfilesBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ProfilesBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ProfilesBtn.UseVisualStyleBackColor = true;
            this.ProfilesBtn.Click += new System.EventHandler(this.ProfilesBtn_Click);
            // 
            // ProxyBtn
            // 
            this.ProxyBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.ProxyBtn.FlatAppearance.BorderSize = 0;
            this.ProxyBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ProxyBtn.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.ProxyBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProxyBtn.ForeColor = System.Drawing.Color.Gainsboro;
            this.ProxyBtn.IconChar = FontAwesome.Sharp.IconChar.Server;
            this.ProxyBtn.IconColor = System.Drawing.Color.Gainsboro;
            this.ProxyBtn.IconSize = 25;
            this.ProxyBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ProxyBtn.Location = new System.Drawing.Point(0, 276);
            this.ProxyBtn.Name = "ProxyBtn";
            this.ProxyBtn.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.ProxyBtn.Rotation = 0D;
            this.ProxyBtn.Size = new System.Drawing.Size(163, 138);
            this.ProxyBtn.TabIndex = 4;
            this.ProxyBtn.Text = "Proxy";
            this.ProxyBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ProxyBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ProxyBtn.UseVisualStyleBackColor = true;
            this.ProxyBtn.Click += new System.EventHandler(this.ProxyBtn_Click);
            // 
            // SettingsBtn
            // 
            this.SettingsBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.SettingsBtn.FlatAppearance.BorderSize = 0;
            this.SettingsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SettingsBtn.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.SettingsBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SettingsBtn.ForeColor = System.Drawing.Color.Gainsboro;
            this.SettingsBtn.IconChar = FontAwesome.Sharp.IconChar.Cog;
            this.SettingsBtn.IconColor = System.Drawing.Color.Gainsboro;
            this.SettingsBtn.IconSize = 25;
            this.SettingsBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SettingsBtn.Location = new System.Drawing.Point(0, 138);
            this.SettingsBtn.Name = "SettingsBtn";
            this.SettingsBtn.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.SettingsBtn.Rotation = 0D;
            this.SettingsBtn.Size = new System.Drawing.Size(163, 138);
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
            this.TasksBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TasksBtn.ForeColor = System.Drawing.Color.Gainsboro;
            this.TasksBtn.IconChar = FontAwesome.Sharp.IconChar.Tasks;
            this.TasksBtn.IconColor = System.Drawing.Color.Gainsboro;
            this.TasksBtn.IconSize = 25;
            this.TasksBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.TasksBtn.Location = new System.Drawing.Point(0, 0);
            this.TasksBtn.Name = "TasksBtn";
            this.TasksBtn.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.TasksBtn.Rotation = 0D;
            this.TasksBtn.Size = new System.Drawing.Size(163, 138);
            this.TasksBtn.TabIndex = 1;
            this.TasksBtn.Text = "Tasks";
            this.TasksBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.TasksBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.TasksBtn.UseVisualStyleBackColor = true;
            this.TasksBtn.Click += new System.EventHandler(this.TasksBtn_Click);
            // 
            // panelChildForm
            // 
            this.panelChildForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.panelChildForm.Controls.Add(this.HoldPanel);
            this.panelChildForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChildForm.Location = new System.Drawing.Point(163, 0);
            this.panelChildForm.Name = "panelChildForm";
            this.panelChildForm.Size = new System.Drawing.Size(864, 553);
            this.panelChildForm.TabIndex = 1;
            // 
            // HoldPanel
            // 
            this.HoldPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.HoldPanel.Controls.Add(this.CloseBtn);
            this.HoldPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.HoldPanel.Location = new System.Drawing.Point(0, 0);
            this.HoldPanel.Name = "HoldPanel";
            this.HoldPanel.Size = new System.Drawing.Size(864, 39);
            this.HoldPanel.TabIndex = 0;
            this.HoldPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.HoldPanel_MouseDown);
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
            this.CloseBtn.Location = new System.Drawing.Point(828, 0);
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
            this.ClientSize = new System.Drawing.Size(1027, 553);
            this.Controls.Add(this.panelChildForm);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormMainMenu";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panelChildForm.ResumeLayout(false);
            this.HoldPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton TasksBtn;
        private FontAwesome.Sharp.IconButton SettingsBtn;
        private FontAwesome.Sharp.IconButton ProxyBtn;
        private FontAwesome.Sharp.IconButton ProfilesBtn;
        private System.Windows.Forms.Panel panelChildForm;
        private System.Windows.Forms.Panel HoldPanel;
        private FontAwesome.Sharp.IconButton CloseBtn;
    }
}

