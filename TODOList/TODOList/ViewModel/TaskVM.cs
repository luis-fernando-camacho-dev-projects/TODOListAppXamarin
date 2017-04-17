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
        private static readonly Lazy<TaskVM> instance = new Lazy<TaskVM>( ()=> new TaskVM());

        public static TaskVM Instance
        {
            get
            {
                return instance.Value;
            }
        }

        private TaskVM()
        {
            Init();
        }

        private void Init()
        {
            CategoryVM instance = CategoryVM.Instance;
            foreach (Category cat in instance.Categories)
            {
                if (cat.Name.Equals("family"))
                {
                    cat.TodoItems.Add(new TodoItem() { Id = 100, Name = "buy clothes", Date = DateTime.Now, Description = "description about to buy clothes for sprint.", Category =cat });
                    cat.TodoItems.Add(new TodoItem() { Id = 101, Name = "buy food Saturday", Date = DateTime.Now, Description = "description about to buy food.", Category = cat });
                    cat.TodoItems.Add(new TodoItem() { Id = 102, Name = "buy fruit Sunday", Date = DateTime.Now, Description = "description about to buy fruit.", Category = cat });
                }
                else if (cat.Name.Equals("Work"))
                {
                    cat.TodoItems.Add(new TodoItem() { Id = 103, Name = "write daily report", Date = DateTime.Now, Description = "description daily report.", Category = cat });
                    cat.TodoItems.Add(new TodoItem() { Id = 104, Name = "correct code review observations", Date = DateTime.Now, Description = "description about correct code review observations." , Category = cat });
                    cat.TodoItems.Add(new TodoItem() { Id = 105, Name = "implement fix for EMC Adapter", Date = DateTime.Now, Description = "description about EMC Adapter." , Category = cat });
                }
                else if (cat.Name.Equals("Learning"))
                {
                    cat.TodoItems.Add(new TodoItem() { Id = 106, Name = "watch angular Videos", Date = DateTime.Now, Description = "Watch videos in Pluralsight.", Category = cat });
                    cat.TodoItems.Add(new TodoItem() { Id = 107, Name = "watch ccs3 videos", Date = DateTime.Now, Description = "Watch videos in the WinIntellecNow.", Category = cat });
                    cat.TodoItems.Add(new TodoItem() { Id = 108, Name = "read book Dependency Injection", Date = DateTime.Now, Description = "read books about dependency Injection.", Category = cat });
                }
            }
        }

        public void RemoveTask(string categoryName, string todoItemName)
        {
            Category owner = CategoryVM.Instance.Categories.FirstOrDefault(ct => ct.Name.ToLower().Equals(categoryName));
            if (owner != null)
            {
                TodoItem todoItem = owner.TodoItems.FirstOrDefault(todo => todo.Name.ToLower().Equals(todoItemName.ToLower()));
                if (todoItem != null)
                {
                    owner.TodoItems.Remove(todoItem);
                }
            }
        }

        public void AddTodoItem(string categoryName, TodoItem newTodoItem)
        {
            Category owner = CategoryVM.Instance.Categories.FirstOrDefault(ct => ct.Name.ToLower().Equals(categoryName));
            owner.TodoItems.Add(newTodoItem);
        }

        public ObservableCollection<TodoItem> GetTodoItems(string category)
        {
            Category owner = CategoryVM.Instance.Categories.FirstOrDefault(ct => ct.Name.ToLower().Equals(category.ToLower()));
            return owner.TodoItems;
        }
    }
}
