using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.CompilerServices;

namespace nikebot.UserControls
{
    public partial class TaskListItem : UserControl
    {
        private Task task;
        private TasksForm form;
        private bool active;
        public TaskListItem(Task task, TasksForm form)
        {
            InitializeComponent();
            label1.Text = task.Profile.Name;
            label2.Text = task.Profile.Surname;
            label3.Text = task.Profile.Email;
            label4.Text = task.Profile.Phone;
            label5.Text = task.Size;
            this.task = task;
            this.form = form;
            active = false;
        }

        public void StartTaskBtn_Click(object sender, EventArgs e)
        {
            active = !active;
            if (active)
            {
                StartTaskBtn.IconChar = FontAwesome.Sharp.IconChar.Pause;
                StartTaskBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            }
            else
            {
                StartTaskBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
                StartTaskBtn.IconChar = FontAwesome.Sharp.IconChar.Play;
            }
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            form.DeleteTask(this, task);
        }
    }
}
