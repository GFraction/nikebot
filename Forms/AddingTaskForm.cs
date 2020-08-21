using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace nikebot.Forms
{
    public partial class AddingTaskForm : Form
    {
        public AddingTaskForm()
        {
            InitializeComponent();
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void AddingTaskForm_Load(object sender, EventArgs e)
        {
            
            foreach(var profile in DataContext.profiles)
            {
                comboBox1.Items.Add(profile.Name);
            }
            comboBox1.SelectedIndex = 0;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            bool res = Uri.IsWellFormedUriString(textBox1.Text, UriKind.Absolute);
            if (res)
            {
                iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.Check;
            }
            else
            {
                iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.Times;
            }
        }
    }
}
