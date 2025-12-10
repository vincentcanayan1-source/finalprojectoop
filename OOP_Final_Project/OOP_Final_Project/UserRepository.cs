using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;

namespace OOP_Final_Project
{
    public class UserRepository
    {
            
        private readonly ISQLiteConnection _connection;

        public UserRepository()
        {
            var databasePath = Path.Combine(
                Environment.GetFolderPath(
                    Environment.SpecialFolder.MyDocuments),
                "userdata.db");


            _connection = new SQLiteConnection(databasePath);
            _connection.CreateTable<User>();


        }
        public bool Add(User user)
        {

            _connection.Insert(user);
            return true;
        }
        public bool Update(User user)
        {
            try
            {
                using (var connection = new SQLiteConnection("userdata.db"))
                {
                    // Update the "IsReturned" field for the specific user
                    var result = connection.Execute(
                        "UPDATE users SET IsReturned = ? WHERE Id = ?",
                        user.Returned ? 1 : 0,  // Store 1 for true, 0 for false
                        user.Id
                    );

                    return result > 0;  // Return true if one row was updated
                }
            }
            catch (Exception ex)
            {
                // Handle exception (log it or show message)
                Console.WriteLine(ex.Message);
                return false;
            }
        }

        public List<User> GetAll()
        {

            return _connection.Table<User>().ToList();
        }

        public User Get(int id)
        {
            return _connection.Find<User>(id);
        }


    }
}
