using SQLite;
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

namespace OOP_Final_Project
{
    public partial class History : Form
    {
        UserRepository repository = new UserRepository();
        public History()
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


        private void Ok_Click(object sender, EventArgs e)
        {

            Selection form2 = new Selection();
            form2.Show();
            this.Hide();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
       
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a row to delete.");
                return;
            }

            var result = MessageBox.Show(
                "Are you sure you want to delete this record?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (result != DialogResult.Yes)
                return;


            var selectedUser = (User)dataGridView1.SelectedRows[0].DataBoundItem;

            repository.Delete(selectedUser.Id);


            dataGridView1.DataSource = repository.GetAll();


        }
    }
}
