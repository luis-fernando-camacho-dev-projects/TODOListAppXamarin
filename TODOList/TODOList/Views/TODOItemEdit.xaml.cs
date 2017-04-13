using System.Threading.Tasks;
using TODOList.Models;
using Xamarin.Forms;

namespace TODOList.Views
{
    public partial class TODOItemEdit : ContentPage
    {
        private TodoItem currentTodoItem;
        public TODOItemEdit(TodoItem source, string category)
        {   
            InitializeComponent();
            currentTodoItem = source;
            if (currentTodoItem != null)
            {
                txtTitle.Text = currentTodoItem.Name;
                txtDescription.Text = currentTodoItem.Description;
            }
            if (category != null)
            {
                Title = category;
            }
            btnCheck.Clicked += BtnCheck_Clicked;
        }

        private void BtnCheck_Clicked(object sender, System.EventArgs e)
        {
            btnCheck.Image = "checked2.png";
            Task.Delay(3000);
            Navigation.PopAsync();
        }
    }
}
