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
        public TaskListItem(string title)
        {
            InitializeComponent();
            label1.Text = title;

        }


    }
}
