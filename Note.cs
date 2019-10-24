using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace NoteProject.Models
{
    public class Note
    {
        int NoteID { get; set; }
        string Title { get; set; }
        string Description { get; set; }

        [ForeignKey("UserID")]
        public User User { get; set; }
        public int UserID{ get; set; }
    }
}
