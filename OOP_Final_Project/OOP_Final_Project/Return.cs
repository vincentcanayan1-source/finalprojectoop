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
            try { 
            var name = textBoxUsername.Text;
            var item= comboBox1.Text;
            int quantity= int.Parse(TextBoxQuantity.Text);
            var date= DateTime.Now;

            var db = new SQLiteConnection(Path.Combine(
                Environment.GetFolderPath(
                    Environment.SpecialFolder.MyDocuments),
                "userdata.db"));

            var comparecolumn = db.Table<User>()
              .FirstOrDefault(x => x.Username == name);

                var rowId = comparecolumn.Id;
            var comparerow = db.Find<User>(rowId);
                if (rowId == comparecolumn.Id)
                {
                    if (item != null)
                    {
                        if (comparerow.BorrowedItems == item)
                        {
                            if (comparerow.BorrowNumber >= quantity)
                            {
                                int unreturned = comparerow.BorrowNumber - quantity;
                                MessageBox.Show("you have a remaining " + unreturned + " " + comparerow.BorrowedItems + " unreturned");
                                comparerow.BorrowNumber = unreturned;
                                if (unreturned == 0)
                                {

                                    comparerow.Returned = true;
                                    db.Update(comparerow);
                                }
                            }
                            else
                            {
                                MessageBox.Show("your returning more than what you borrowed!! try again.");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Please fill up the form correctly");
                        }

                    }
                }
                else
                {
                    MessageBox.Show("there is no data about you");
                }
                   
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

