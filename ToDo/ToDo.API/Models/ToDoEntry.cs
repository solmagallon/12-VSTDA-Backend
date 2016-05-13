using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ToDo.API.Models
{
    public class ToDoEntry
    {
        //Primary Key
        public int ToDoEntryId { get; set; }

        //Foriegn Key
        
        //User Data
        public string Name { get; set; }
        public string Text { get; set; }
        public DateTime CreatedDate { get; set; }

     }
}