using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace OOP_Final_Project
{
    public partial class Return : Form
    {
        private int selectedRowID = -1;

        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                // Ensure that the clicked row index is valid (not the header row)
                if (e.RowIndex >= 0)
                {
                    selectedRowID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["id"].Value);
                    // Get the clicked row
                    DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                    // Populate the textboxes with data from the clicked row
                    textBoxUsername.Text = row.Cells["Name"].Value.ToString();
                    TextBoxQuantity.Text = row.Cells["Quantity"].Value.ToString();
                    comboBox1.Text = row.Cells["Item"].Value.ToString();
                    dateTimePicker1.Text = row.Cells["Date"].Value.ToString();

                }
            }
            catch (Exception ex)
            {
                // Display an error message in case of failure
                MessageBox.Show(ex.Message);
            }
        }
        UserRepository repository = new UserRepository();
        public Return()
        {
            InitializeComponent();
            LoadUzerToDataGridView();
        }

        private void LoadUzerToDataGridView()
        {
            List<User> users = repository.GetAll();
            dataGridView1.DataSource = users;

        }

        private void ListUsersForm_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Welcome to user manager",
                "Greetings",

               MessageBoxButtons.OK,
               MessageBoxIcon.Information);




        }

        private void button6_Click(object sender, EventArgs e)
        {
            Selection form2 = new Selection();
            form2.Show();
            this.Hide();
            form2.FormClosed += (s, args) => this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Selection form2 = new Selection();
            form2.Show();
            this.Hide();
            form2.FormClosed += (s, args) => this.Close();
        }



        private void buttonReturn_Click(object sender, EventArgs e)
        {


            if (selectedRowID >= 0)
            {
                // Create the user object with updated information
                var user = new User
                {
                    Id = selectedRowID,  // Use the selected row's ID
                    IsReturned = true     // Mark the item as returned
                };
                

            }
        }
    }
}

