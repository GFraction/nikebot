using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
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
            StatusLabel.Text = "Добавление таска...";
            AddingTaskForm form = new AddingTaskForm();
            DialogResult result = form.ShowDialog(this);
            if (result == DialogResult.Cancel)
            {
                StatusLabel.Text = "...";
                return;
            }
            Task task = new Task()
            {
                Profile = DataContext.profiles.Find(profile => profile.ID == form.comboBox1.SelectedIndex),
                Size = form.comboBox2.Text,
                Proxy = form.proxyCheck.Checked,
                Url = form.textBox1.Text
            };
            DataContext.tasks.Add(task);
            using (FileStream fs = new FileStream("tasks.xml", FileMode.Open))
            {
                DataContext.taskFormatter.Serialize(fs, DataContext.tasks);
                StatusLabel.Text = "Таск сохранен!";
            }
            TaskListItem item = new TaskListItem(task, this);
            TasksLayoutPanel.Controls.Add(item);

        }

        private void TasksForm_Load(object sender, EventArgs e)
        {
            DataContext.tasks = new List<Task>();
            DataContext.profiles = new List<Profile>();
            using (FileStream fs = new FileStream("tasks.xml", FileMode.OpenOrCreate))
            {
                try
                {
                    DataContext.tasks = (List<Task>)DataContext.taskFormatter.Deserialize(fs);
                    foreach (var task in DataContext.tasks)
                    {
                        TaskListItem item = new TaskListItem(task, this);
                        TasksLayoutPanel.Controls.Add(item);
                    }
                }
                catch
                {
                    StatusLabel.Text = "...";
                }
                
            }
            using (FileStream fs = new FileStream("profiles.xml", FileMode.OpenOrCreate))
            {
                try
                {
                    DataContext.profiles = (List<Profile>)DataContext.profileFormatter.Deserialize(fs);
                }
                catch
                {
                    StatusLabel.Text = "Добавьте профили.";
                }
            }
            
        }
        public void DeleteTask(TaskListItem item, Task task)
        {
            TasksLayoutPanel.Controls.Remove(item);
            DataContext.tasks.Remove(task);

            using (FileStream fs = new FileStream("tasks.xml", FileMode.Create))
            {

                DataContext.taskFormatter.Serialize(fs, DataContext.tasks);

                StatusLabel.Text = $"Таск с именем {task.Profile.Name} удален.";
            }
        }

        private void StartAllBtn_Click(object sender, EventArgs e)
        {
            foreach(TaskListItem item in TasksLayoutPanel.Controls)
            {
                item.StartTaskBtn_Click( sender, e);
            }
        }
    }
}
