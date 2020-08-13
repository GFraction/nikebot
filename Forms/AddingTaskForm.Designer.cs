namespace nikebot.Forms
{
    partial class AddingTaskForm
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
            this.HoldPanel = new System.Windows.Forms.Panel();
            this.CloseBtn = new FontAwesome.Sharp.IconButton();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.AddTskBtn = new FontAwesome.Sharp.IconButton();
            this.CancelBtn = new FontAwesome.Sharp.IconButton();
            this.HoldPanel.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // HoldPanel
            // 
            this.HoldPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.HoldPanel.Controls.Add(this.CloseBtn);
            this.HoldPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.HoldPanel.Location = new System.Drawing.Point(0, 0);
            this.HoldPanel.Name = "HoldPanel";
            this.HoldPanel.Size = new System.Drawing.Size(800, 39);
            this.HoldPanel.TabIndex = 1;
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
            this.CloseBtn.Location = new System.Drawing.Point(764, 0);
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.Rotation = 0D;
            this.CloseBtn.Size = new System.Drawing.Size(36, 39);
            this.CloseBtn.TabIndex = 0;
            this.CloseBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.CloseBtn.UseVisualStyleBackColor = false;
            this.CloseBtn.Click += new System.EventHandler(this.CloseBtn_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.AddTskBtn, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.CancelBtn, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 39);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 89.2944F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.7056F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 411);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // AddTskBtn
            // 
            this.AddTskBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.AddTskBtn.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.AddTskBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AddTskBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddTskBtn.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.AddTskBtn.ForeColor = System.Drawing.Color.Gainsboro;
            this.AddTskBtn.IconChar = FontAwesome.Sharp.IconChar.None;
            this.AddTskBtn.IconColor = System.Drawing.Color.Black;
            this.AddTskBtn.IconSize = 16;
            this.AddTskBtn.Location = new System.Drawing.Point(403, 369);
            this.AddTskBtn.Name = "AddTskBtn";
            this.AddTskBtn.Rotation = 0D;
            this.AddTskBtn.Size = new System.Drawing.Size(394, 39);
            this.AddTskBtn.TabIndex = 0;
            this.AddTskBtn.Text = "Add";
            this.AddTskBtn.UseVisualStyleBackColor = false;
            // 
            // CancelBtn
            // 
            this.CancelBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.CancelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CancelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CancelBtn.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.CancelBtn.ForeColor = System.Drawing.Color.Gainsboro;
            this.CancelBtn.IconChar = FontAwesome.Sharp.IconChar.None;
            this.CancelBtn.IconColor = System.Drawing.Color.Black;
            this.CancelBtn.IconSize = 16;
            this.CancelBtn.Location = new System.Drawing.Point(3, 369);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Rotation = 0D;
            this.CancelBtn.Size = new System.Drawing.Size(394, 39);
            this.CancelBtn.TabIndex = 1;
            this.CancelBtn.Text = "Cancel";
            this.CancelBtn.UseVisualStyleBackColor = false;
            // 
            // AddingTaskForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.HoldPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddingTaskForm";
            this.Text = "AddingTaskForm";
            this.HoldPanel.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel HoldPanel;
        private FontAwesome.Sharp.IconButton CloseBtn;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private FontAwesome.Sharp.IconButton AddTskBtn;
        private FontAwesome.Sharp.IconButton CancelBtn;
    }
}