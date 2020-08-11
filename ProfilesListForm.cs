using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace nikebot
{
    public partial class ProfilesListForm : Form
    {
        SqlConnection sqlConnection;
        public ProfilesListForm()
        {
            InitializeComponent();
        }
        

        private async void ProfilesListForm_Load(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Михаил\source\repos\nikebot\Database.mdf;Integrated Security=True";
            sqlConnection = new SqlConnection(connectionString);

            await sqlConnection.OpenAsync();
            ProfileList_Update();
        }
        private async void ProfileList_Update()
        {
            listBox1.Items.Clear();
            SqlDataReader sqlDataReader = null;
            SqlCommand command = new SqlCommand("SELECT * FROM [ProfileTable]", sqlConnection);
            try
            {
                sqlDataReader = await command.ExecuteReaderAsync();
                while (await sqlDataReader.ReadAsync())
                {
                    listBox1.Items.Add(Convert.ToString(sqlDataReader["Id"]) + " " + Convert.ToString(sqlDataReader["Name"]));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), ex.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (sqlDataReader != null)
                {
                    sqlDataReader.Close();
                }
            }
        }
        private void ProfilesListForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(sqlConnection != null && sqlConnection.State != ConnectionState.Closed)
            {
                sqlConnection.Close();
            }
        }

        private void AddNewProfileBtn_Click(object sender, EventArgs e)
        {
            AddingProfileForm addingProfileForm = new AddingProfileForm(sqlConnection, listBox1);
           
            addingProfileForm.Show();
            
        }
    }
}
