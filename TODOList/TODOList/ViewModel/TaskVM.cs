using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TODOList.Models;

namespace TODOList.ViewModel
{
    public class TaskVM
    {
        private Category category;

        public ObservableCollection<TodoItem> TodoItems
        {
            get
            {
                return category.TodoItems;
            }
            set
            {
                category.TodoItems = value;
            }
        }

        
        public TaskVM(Category category)
        {
            this.category = category;
            // query based in the id to get task;
            if (category.Name.Equals("family"))
            {
                category.TodoItems.Add(new TodoItem() { Id=100, Name = "buy clothes", Date = DateTime.Now, Description = "description about to buy clothes for sprint." });
                category.TodoItems.Add(new TodoItem() { Id=101, Name = "buy food Saturday", Date = DateTime.Now, Description = "description about to buy food." });
                category.TodoItems.Add(new TodoItem() { Id=102, Name = "buy fruit sunday", Date = DateTime.Now, Description = "description about to buy fruit." });
            }
            else if (category.Name.Equals("Trabajo"))
            {
                category.TodoItems.Add(new TodoItem() { Id=103, Name = "write daily report", Date = DateTime.Now, Description = "description daily report." });
                category.TodoItems.Add(new TodoItem() { Id = 104, Name = "correct code review observations", Date = DateTime.Now, Description = "description about correct code review observations." });
                category.TodoItems.Add(new TodoItem() { Id = 105, Name = "implement fix for EMC Adapter", Date = DateTime.Now, Description = "description about EMC Adapter." });
            }
            else
            {
                category.TodoItems.Add(new TodoItem() { Id = 106, Name = "watch angular Videos", Date = DateTime.Now, Description = "Watch videos in Pluralsight." });
                category.TodoItems.Add(new TodoItem() { Id = 107, Name = "watch ccs3 videos", Date = DateTime.Now, Description = "Watch videos in the WinIntellecNow." });
                category.TodoItems.Add(new TodoItem() { Id = 108, Name = "read book Dependency Injection", Date = DateTime.Now, Description = "read books about dependency Injection." });
            }
        }

        public void RemoveTask(string Name)
        {
            category.TodoItems.Remove(category.TodoItems.First(todo => todo.Name.Equals(Name)));
        }

        public void AddTodoItem(TodoItem newTodoItem)
        {
            category.TodoItems.Add(newTodoItem);
        }
    }
}
