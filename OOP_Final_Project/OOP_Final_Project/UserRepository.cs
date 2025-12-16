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
                    var result = connection.Execute(
                        "UPDATE users SET IsReturned = ? WHERE Id = ?",
                        user.Returned ? 1 : 0,  
                        user.Id
                    );

                    return result > 0;  
                }
            }
            catch (Exception ex)
            {      
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
        public void Delete(int id)
        {
            _connection.Delete<User>(id);
        }



    }
}
