using System;
using System.Threading.Tasks;
using TODOList.Models;
using Xamarin.Forms;

namespace TODOList.Views
{
    public partial class TODOItemEdit : ContentPage
    {
        private TodoItem currentTodoItem;
        private Category category;
        public TODOItemEdit(Category category, TodoItem source, string categoryTitle)
        {   
            InitializeComponent();
            currentTodoItem = source;
            this.category = category;
            if (currentTodoItem != null)
            {
                txtTitle.Text = currentTodoItem.Name;
                txtDescription.Text = currentTodoItem.Description;
            }
            if (categoryTitle != null)
            {
                Title = categoryTitle;
            }
            btnCheck.Clicked += BtnCheck_Clicked;
        }

        private void BtnCheck_Clicked(object sender, System.EventArgs e)
        {
            btnCheck.Image = "checked2.png";
            Task.Delay(3000);
            Navigation.PopAsync();
        }

        private async void MISave_Clicked(object sender, System.EventArgs e)
        {

            

            if (currentTodoItem != null)
            {
                TodoItem newTodoItem = new TodoItem();
                newTodoItem.StateItem = currentTodoItem.StateItem;
                newTodoItem.Category = category;
                newTodoItem.Date = currentTodoItem.Date;
                newTodoItem.Name = txtTitle.Text;
                newTodoItem.Description = txtDescription.Text;

                category.TodoItems.Remove(currentTodoItem);
                currentTodoItem = null;
                category.TodoItems.Add(newTodoItem);

            }
            else
            {
                TodoItem newTodoItem = new TodoItem();
                newTodoItem.Category = category;
                newTodoItem.Name = txtTitle.Text;
                newTodoItem.Description = txtDescription.Text;
                newTodoItem.Date = DateTime.Now;
                category.TodoItems.Add(newTodoItem);

            }

            
            
            await Navigation.PopAsync();

        }

        private  async void MIDelete_Clicked(object sender, EventArgs e)
        {
            category.TodoItems.Remove(currentTodoItem);
            await Navigation.PopAsync();
        }
    }
}
