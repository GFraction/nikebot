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
using nikebot.Forms;
using nikebot.UserControls;

namespace nikebot
{
    public partial class TasksForm : Form
    {
        public TasksForm()
        {
            InitializeComponent();
        }
        private void AddTaskBtn_Click(object sender, EventArgs e)
        {
            AddingTaskForm form = new AddingTaskForm();
            DialogResult result = form.ShowDialog(this);
            if (result == DialogResult.Cancel) return;
            TaskListItem item = new TaskListItem("Hekko");
            TasksLayoutPanel.Controls.Add(item);
        }

    }
}
