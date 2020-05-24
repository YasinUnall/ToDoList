using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ToDoList.Models
{
    public class ToDo
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public bool IsDone { get; set; }

        //Defines a user. Used for figuring out that which list belongs to who
        public virtual ApplicationUser User { get; set; }
    }
}