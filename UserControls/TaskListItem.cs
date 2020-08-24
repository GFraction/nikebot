using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace nikebot.UserControls
{
    public partial class TaskListItem : UserControl
    {
        private Task task;
        private TasksForm form;
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
        }


    }
}
