using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NoteProject.Models
{
    public class User
    {
        int UserID { get; set; }
        string Name { get; set; }
        string LastName { get; set; }
        string Login { get; set; }
        string Password { get; set; }
        Boolean ADM { get; set;  }


    }
}
