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
    public partial class ProfileListItem : UserControl
    {
        ProfilesListForm form;
        Profile profile;
        public ProfileListItem(Profile profile, ProfilesListForm form)
        {
            InitializeComponent();

            NameLabel.Text = profile.Name;
            SurnameLabel.Text = profile.Surname;
            this.form = form;
            this.profile = profile;
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            form.DeleteProfile(this, profile);
        }
    }
}
