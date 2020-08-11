namespace nikebot
{
    partial class ProfilesListForm
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.AddNewProfileBtn = new FontAwesome.Sharp.IconButton();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.listBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox1.Font = new System.Drawing.Font("HelvLight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.ForeColor = System.Drawing.Color.Gainsboro;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(3, 53);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(794, 394);
            this.listBox1.TabIndex = 0;
            // 
            // AddNewProfileBtn
            // 
            this.AddNewProfileBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AddNewProfileBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddNewProfileBtn.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.AddNewProfileBtn.Font = new System.Drawing.Font("HelvLight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddNewProfileBtn.IconChar = FontAwesome.Sharp.IconChar.UserPlus;
            this.AddNewProfileBtn.IconColor = System.Drawing.Color.Black;
            this.AddNewProfileBtn.IconSize = 16;
            this.AddNewProfileBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AddNewProfileBtn.Location = new System.Drawing.Point(3, 3);
            this.AddNewProfileBtn.Name = "AddNewProfileBtn";
            this.AddNewProfileBtn.Rotation = 0D;
            this.AddNewProfileBtn.Size = new System.Drawing.Size(794, 44);
            this.AddNewProfileBtn.TabIndex = 1;
            this.AddNewProfileBtn.Text = "Add New Profile";
            this.AddNewProfileBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.AddNewProfileBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.AddNewProfileBtn.UseVisualStyleBackColor = true;
            this.AddNewProfileBtn.Click += new System.EventHandler(this.AddNewProfileBtn_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.AddNewProfileBtn, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.listBox1, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 88.66666F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // ProfilesListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ProfilesListForm";
            this.Text = "ProfilesListForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ProfilesListForm_FormClosing);
            this.Load += new System.EventHandler(this.ProfilesListForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private FontAwesome.Sharp.IconButton AddNewProfileBtn;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ListBox listBox1;
    }
}