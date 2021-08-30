using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ToDoList.Entitties.Attributes;

namespace ToDoList.Entitties
{
    public class ToDoItem
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public ToDoItemStatus Status { get; set; }
    }
}
