using System;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.IO;
using System.Collections.Generic;
using nikebot.UserControls;

namespace nikebot
{
    public partial class ProfilesListForm : Form
    {
        
        public ProfilesListForm()
        {
            InitializeComponent();
        }
        private void AddNewProfileBtn_Click(object sender, EventArgs e)
        {
            StatusLabel.Text = "Добавление профиля...";

            AddingProfileForm addingProfileForm = new AddingProfileForm();
           
            DialogResult result = addingProfileForm.ShowDialog(this);
            if (result == DialogResult.Cancel) {
                StatusLabel.Text = "...";
                return;
            }
            Profile prof = new Profile()
            {
                Name = addingProfileForm.NameInput.Text,
                Surname = addingProfileForm.SurnameInput.Text,
                Patronymic = addingProfileForm.PatronymicInput.Text,
                Phone = addingProfileForm.PhoneInput.Text,
                CVV = addingProfileForm.CVVInput.Text,
                City = addingProfileForm.CityInput.Text,
                Street = addingProfileForm.StreetInput.Text,
                Apt = addingProfileForm.AptInput.Text,
                CreditCard  = addingProfileForm.CreditCardInput.Text,
                Email = addingProfileForm.EmailInput.Text
            };
            DataContext.profiles.Add(prof);
           
                using (FileStream fs = new FileStream("profiles.xml", FileMode.OpenOrCreate))
                {
                    DataContext.formatter.Serialize(fs, DataContext.profiles);

                    StatusLabel.Text = "Профиль сохранен!";
                }
            ProfileListItem item = new ProfileListItem(prof, this);
            flowLayoutPanel1.Controls.Add(item);
        }
        private void ProfilesListForm_Load(object sender, EventArgs e)

        {
            using (FileStream fs = new FileStream("profiles.xml", FileMode.Open))
            {
                
                foreach (var profile in DataContext.profiles)
                {
                       ProfileListItem item = new ProfileListItem(profile, this);
                       flowLayoutPanel1.Controls.Add(item);
                }
            }
        }
   
        public void DeleteProfile(ProfileListItem item, Profile profile)
        {
            flowLayoutPanel1.Controls.Remove(item);
            DataContext.profiles.Remove(profile);
            
            using (FileStream fs = new FileStream("profiles.xml", FileMode.Create))
            {

                DataContext.formatter.Serialize(fs, DataContext.profiles);

                StatusLabel.Text = $"Профиль с именем {profile.Name} удален.";
            }
        }

    }
}
