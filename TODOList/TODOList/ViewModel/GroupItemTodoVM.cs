using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TODOList.Models;

namespace TODOList.ViewModel
{
    public class GroupItemTodoVM 
    {
        public ObservableCollection<GroupItemTodo> groupedTodoItems { get; set; }
        private static readonly Lazy<GroupItemTodoVM> GroupInstance = new Lazy<GroupItemTodoVM>(() => new GroupItemTodoVM());
        
        public static GroupItemTodoVM Instance
        {
            get
            {
                return GroupInstance.Value;
            }
        }


        private GroupItemTodoVM()
        {
            groupedTodoItems = new ObservableCollection<GroupItemTodo>();
        }

        public void Reload()
        {
            Init();
        }

        private void Init()
        {
            groupedTodoItems.Clear();
            foreach (Category category in CategoryVM.Instance.Categories)
            {
                if (category.Name.ToLower().Equals("all"))
                {
                    continue;
                }
                var categoryGroup = new GroupItemTodo(category.Name, category.Description);
                foreach (TodoItem item in category.TodoItems)
                {
                    categoryGroup.Add(item);
                }
                groupedTodoItems.Add(categoryGroup);
            }
        }
    }
}
