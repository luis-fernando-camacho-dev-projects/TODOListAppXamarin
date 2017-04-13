using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TODOList.Models;
using TODOList.ViewModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TODOList.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListTodoItemsPage : ContentPage
    {
        public TaskVM TaskViewModel { get; set; }

        public ListTodoItemsPage(Category category)
        {
            InitializeComponent();
            Title = category.Name;
            TaskViewModel = new TaskVM(category);
            lvTodoItems.ItemsSource = TaskViewModel.TodoItems;
            var tapImage = new TapGestureRecognizer();
            tapImage.Tapped += tapImage_Tapped;
            img.GestureRecognizers.Add(tapImage);
        }

        private async void  tapImage_Tapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new TODOItemEdit(null, Title));

        }

        async void todoItem_Clicked(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            b.Image = "checked2.png";
            await Task.Delay(1000);
            TaskViewModel.RemoveTask(b.Text);
        }

        private void img_Unfocused(object sender, FocusEventArgs e)
        {
            DisplayAlert("Alert", "This is an image button", "OK");
        }

        private void img_Focused(object sender, FocusEventArgs e)
        {
            DisplayAlert("Alert", "This is an image button", "OK");

        }

        private async void lvTodoItems_ItemTapped(object sender, SelectedItemChangedEventArgs e)
        {
            TodoItem item = (TodoItem) e.SelectedItem;
            await Navigation.PushAsync(new TODOItemEdit(item, Title));
        }
    }
}
