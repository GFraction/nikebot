using System;
using System.Windows.Forms;
using System.Data.Entity;

namespace nikebot
{
    public partial class ProfilesListForm : Form
    {
        ModelContext db;
        public ProfilesListForm()
        {
            InitializeComponent();
            db = new ModelContext();
            db.ProfList.Load();
            dataGridView1.DataSource = db.ProfList.Local.ToBindingList();

        }
        private void AddNewProfileBtn_Click(object sender, EventArgs e)
        {
            AddingProfileForm addingProfileForm = new AddingProfileForm();
           
            DialogResult result = addingProfileForm.ShowDialog(this);
            if (result == DialogResult.Cancel) return;
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
            db.ProfList.Add(prof);
            db.SaveChanges();
            
        }
    }
}
