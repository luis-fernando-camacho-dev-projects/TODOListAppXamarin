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
        private Category category;
        public ListTodoItemsPage(Category category)
        {
            InitializeComponent();
            Title = category.Name;
            this.category = category;
            lvTodoItems.ItemsSource = TaskVM.Instance.GetTodoItems(category.Name);
            var tapImage = new TapGestureRecognizer();
            tapImage.Tapped += NewTodoItem_Tapped;
            img.GestureRecognizers.Add(tapImage);
        }

        private async void NewTodoItem_Tapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new TODOItemEdit(category, null, Title));
        }

        async void Done_Clicked(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            b.Image = "checked2.png";
            await Task.Delay(1000);
            TaskVM.Instance.RemoveTask(category.Name, b.Text);
        }

        private async void SelectTodoItem_Tapped(object sender, ItemTappedEventArgs e)
        {
            TodoItem item = (TodoItem)e.Item;
            await Navigation.PushAsync(new TODOItemEdit(category, item, Title));
        }
    }
}
