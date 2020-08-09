using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using cef;
using CefSharp;
using CefSharp.WinForms;

namespace nikebot
{
    public partial class Form1 : Form
    {
        public static ChromiumWebBrowser chrome; // test comment
        

        public Form1()
        {
            InitializeComponent();
            InitBrowser();
        }

        private static void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        public void InitBrowser()
        {
            //Cef.Initialize(new CefSettings());
            chrome = new ChromiumWebBrowser();
            this.ChromePanel.Controls.Add(chrome);
            chrome.Dock = DockStyle.Fill;
        }

        private void UrlAdress_TextChanged(object sender, EventArgs e)
        {

        }
        private void UrlAdress_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                chrome.Load(UrlAdress.Text);
            }
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
