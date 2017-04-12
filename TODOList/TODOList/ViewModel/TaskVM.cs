using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TODOList.Models;

namespace TODOList.ViewModel
{
    public class TaskVM
    {
        public List<TodoItem> TodoItems { get; set; }
        public TaskVM(Category category)
        {
            TodoItems = new List<TodoItem>();
            // query based in the id to get task;
            if (category.Name.Equals("family"))
            {
                TodoItems.Add(new TodoItem() { Name = "buy clothes", Date = DateTime.Now, Description = "description about to buy clothes for sprint." });
                TodoItems.Add(new TodoItem() { Name = "buy food Saturday", Date = DateTime.Now, Description = "description about to buy food." });
                TodoItems.Add(new TodoItem() { Name = "buy fruit sunday", Date = DateTime.Now, Description = "description about to buy fruit." });
            }
            else if (category.Name.Equals("Trabajo"))
            {
                TodoItems.Add(new TodoItem() { Name = "write daily report", Date = DateTime.Now, Description = "description daily report." });
                TodoItems.Add(new TodoItem() { Name = "correct code review observations", Date = DateTime.Now, Description = "description about correct code review observations." });
                TodoItems.Add(new TodoItem() { Name = "implement fix for EMC Adapter", Date = DateTime.Now, Description = "description about EMC Adapter." });
            }
            else
            {
                TodoItems.Add(new TodoItem() { Name = "watch angular Videos", Date = DateTime.Now, Description = "Watch videos in Pluralsight." });
                TodoItems.Add(new TodoItem() { Name = "watch ccs3 videos", Date = DateTime.Now, Description = "Watch videos in the WinIntellecNow." });
                TodoItems.Add(new TodoItem() { Name = "read book Dependency Injection", Date = DateTime.Now, Description = "read books about dependency Injection." });
            }
        }
    }
}
