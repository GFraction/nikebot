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
            this.components = new System.ComponentModel.Container();
            this.AddNewProfileBtn = new FontAwesome.Sharp.IconButton();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.StatusLabel = new System.Windows.Forms.Label();
            this.profileBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.profileBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // AddNewProfileBtn
            // 
            this.AddNewProfileBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AddNewProfileBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddNewProfileBtn.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.AddNewProfileBtn.Font = new System.Drawing.Font("HelvLight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddNewProfileBtn.ForeColor = System.Drawing.Color.Gainsboro;
            this.AddNewProfileBtn.IconChar = FontAwesome.Sharp.IconChar.UserPlus;
            this.AddNewProfileBtn.IconColor = System.Drawing.Color.Gainsboro;
            this.AddNewProfileBtn.IconSize = 16;
            this.AddNewProfileBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AddNewProfileBtn.Location = new System.Drawing.Point(3, 3);
            this.AddNewProfileBtn.Name = "AddNewProfileBtn";
            this.AddNewProfileBtn.Rotation = 0D;
            this.AddNewProfileBtn.Size = new System.Drawing.Size(794, 42);
            this.AddNewProfileBtn.TabIndex = 1;
            this.AddNewProfileBtn.Text = "Add New Profile";
            this.AddNewProfileBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.AddNewProfileBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.AddNewProfileBtn.UseVisualStyleBackColor = true;
            this.AddNewProfileBtn.Click += new System.EventHandler(this.AddNewProfileBtn_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.AddNewProfileBtn, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.StatusLabel, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 88.66666F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 51);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(794, 0);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // StatusLabel
            // 
            this.StatusLabel.AutoSize = true;
            this.StatusLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(24)))), ((int)(((byte)(28)))));
            this.StatusLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StatusLabel.ForeColor = System.Drawing.Color.Gainsboro;
            this.StatusLabel.Location = new System.Drawing.Point(3, 429);
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(794, 21);
            this.StatusLabel.TabIndex = 3;
            this.StatusLabel.Text = "...";
            // 
            // profileBindingSource
            // 
            this.profileBindingSource.DataSource = typeof(nikebot.Profile);
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
            this.Load += new System.EventHandler(this.ProfilesListForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.profileBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private FontAwesome.Sharp.IconButton AddNewProfileBtn;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.BindingSource profileBindingSource;
        private System.Windows.Forms.Label StatusLabel;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}