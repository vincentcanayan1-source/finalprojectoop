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
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace OOP_Final_Project
{
    public partial class Return : Form
    {
        public Return()
        {
            InitializeComponent();
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
            try
            {
                var name = textBoxUsername.Text;
                var item = comboBox1.Text;

                if (!int.TryParse(TextBoxQuantity.Text, out int quantity))
                {
                    MessageBox.Show("Invalid quantity");
                    return;
                }

                var db = new SQLiteConnection(Path.Combine(
                    Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments),
                    "userdata.db"));

                var user = db.Table<User>()
                             .FirstOrDefault(x => x.Username == name);

                if (user == null)
                {
                    MessageBox.Show("There is no data about you");
                    return;
                }

                if (string.IsNullOrWhiteSpace(item))
                {
                    MessageBox.Show("Please select an item");
                    return;
                }

                if (user.BorrowedItems != item)
                {
                    MessageBox.Show("Please fill up the form correctly");
                    return;
                }

                if (user.BorrowNumber < quantity)
                {
                    MessageBox.Show("You're returning more than what you borrowed!");
                    return;
                }

                int unreturned = user.BorrowNumber - quantity;
                user.BorrowNumber = unreturned;
                user.Returned = (unreturned == 0);

                db.Update(user);

                MessageBox.Show(
                    $"You have {unreturned} {user.BorrowedItems} unreturned"
                );
            }
            catch (SQLiteException ex)
            {
                MessageBox.Show("Database error: " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
           



        }
    }
}

