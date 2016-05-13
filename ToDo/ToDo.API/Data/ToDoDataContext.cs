using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using ToDo.API.Models;

namespace ToDo.API.Data
{
    //1. Create class that inherits from DbContext
    public class ToDoDataContext : DbContext
    {
        //2. Setup Constructor
        public ToDoDataContext() : base("ToDoList")
        {

        }

        //3. Describe our Tables
        public IDbSet<ToDoEntry> ToDoEntries { get; set; }

    }
}