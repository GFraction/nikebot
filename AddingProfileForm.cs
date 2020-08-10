using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;

using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace nikebot
{
    public partial class AddingProfileForm : Form
    {
        SqlConnection sqlConnection;

        public AddingProfileForm(SqlConnection sqlConnection)
        {
            this.sqlConnection = sqlConnection;
            InitializeComponent();
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void SaveBtn_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("INSERT INTO [ProfileTable] (Name)VALUES(@Name)", sqlConnection);
            command.Parameters.AddWithValue("Name", NameInput.Text);
            await command.ExecuteNonQueryAsync();
            this.Close();
            
        }

        private async void AddingProfileForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            ProfilesListForm.listBox1.Items.Clear();
            SqlDataReader sqlDataReader = null;
            SqlCommand command = new SqlCommand("SELECT * FROM [ProfileTable]", sqlConnection);
            try
            {
                sqlDataReader = await command.ExecuteReaderAsync();
                while (await sqlDataReader.ReadAsync())
                {
                    ProfilesListForm.listBox1.Items.Add(Convert.ToString(sqlDataReader["Id"]) + " " + Convert.ToString(sqlDataReader["Name"]));
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
    }
}
