using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TODOList.Models;
using TODOList.ViewModel;
using Xamarin.Forms;

namespace TODOList.Views
{
    public partial class TodayTodoItems : ContentPage
    {
        public TodayTodoItems()
        {
            InitializeComponent();
            TaskVM instance =  TaskVM.Instance;
            GroupItemTodoVM.Instance.Reload();
             lvTodoItemsToday.ItemsSource = GroupItemTodoVM.Instance.groupedTodoItems;
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            b.Image = "checked2.png";
            await Task.Delay(1000);
            string category;
            TodoItem todoItem = null;
            GroupItemTodo groupToFindItem = null;
            foreach (GroupItemTodo groupItem in GroupItemTodoVM.Instance.groupedTodoItems)
            {
                foreach (TodoItem item in groupItem)
                {
                    if (b.Text.Equals(item.Name))
                    {
                        groupToFindItem = groupItem;
                        todoItem = item;
                        category = groupItem.CategoryTitle;
                        TaskVM.Instance.RemoveTask(category, b.Text);
                        break;
                    }
                }
                if (todoItem != null)
                {
                    break;
                }
            }
            if (groupToFindItem != null && todoItem != null)
            {
                groupToFindItem.Remove(todoItem);
            }
            GroupItemTodoVM.Instance.Reload();
            lvTodoItemsToday.ItemsSource = null;
            lvTodoItemsToday.ItemsSource = GroupItemTodoVM.Instance.groupedTodoItems;
            //await Task.Delay(1000);



        }

        private async void lvTodoItemsToday_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            TodoItem item = (TodoItem)e.Item;
            await Navigation.PushAsync(new TODOItemEdit(item.Category, item, item.Category.Name));
        }
    }
}
