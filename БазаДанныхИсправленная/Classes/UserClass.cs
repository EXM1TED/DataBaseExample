using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace БазаДанныхИсправленная.Classes
{
    [Table("Users")]
    public class User
    {
        [Column("Id")]
        public int Id { get; set; }
        [Column("Login")]
        public string Login { get; set; }
        [Column("Password")]
        public string Password { get; set; }
        [Column("Number_of_class_id")]
        public int NumberOfClassId { get; set; }

        public User()
        {
            Login = string.Empty;
            Password = string.Empty;
        }

        public User(string login, string password)
        {
            Login = login;
            Password = password;
        }
    }
}
