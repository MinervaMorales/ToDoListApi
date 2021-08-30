using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ToDoList.Entitties;

namespace ToDoList.Services
{
    public class TodoDbContext: DbContext
    {
        public TodoDbContext(DbContextOptions options): base(options) { }

        public DbSet<ToDoItem> ToDoItems { get; set; }
    }
}
