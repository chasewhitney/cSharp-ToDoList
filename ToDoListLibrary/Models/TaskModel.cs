﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoListLibrary.Models
{
    public class TaskModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool Completed { get; set; }
        
    }
}
