﻿using System;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace nikebot
{
    public partial class FormMainMenu : Form
    {
        //Constructor
        public FormMainMenu()
        {
            InitializeComponent();
            openChildForm(new TasksForm());
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            if(activeForm != null)
            {
                activeForm.Close();

            }
            this.Close();
        }
       

        private void TasksBtn_Click(object sender, EventArgs e)
        {
            openChildForm(new TasksForm());
        }
        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            childForm.BringToFront();
            childForm.Show();
        }

        private void ProfilesBtn_Click(object sender, EventArgs e)
        {
            openChildForm(new ProfilesListForm());
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void HoldPanel_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void ProxyBtn_Click(object sender, EventArgs e)
        {
            openChildForm(new ProxyForm());

        }
        //Structs

    }
}