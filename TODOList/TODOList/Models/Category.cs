using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TODOList.Models
{
    public class Category
    {
        public string Icon { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public ObservableCollection<TodoItem> TodoItems { get; set; }

        public Category()
        {
            TodoItems = new ObservableCollection<TodoItem>();
        }
    }

    public class GroupItemTodo : ObservableCollection<TodoItem>
    {
        public string CategoryTitle { get; set; }
        public string CategoryDescription { get; set; }

        public GroupItemTodo(string title, string description)
        {
            CategoryTitle = title;
            CategoryDescription = description;
        }
    }
}
