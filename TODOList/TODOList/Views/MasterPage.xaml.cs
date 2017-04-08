using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TODOList.ViewModel;
using Xamarin.Forms;

namespace TODOList.Views
{
    public partial class MasterPage : ContentPage
    {
        public string Image { get; set; }

        public MasterPage()
        {

           

            InitializeComponent();
            Image = "https://upload.wikimedia.org/wikipedia/commons/5/55/Tamarin_portrait.JPG";
            CategoryVM categories = new CategoryVM();
            lvGroup.ItemsSource = categories.Categories;
            lvSettings.ItemsSource = categories.Settings;
            lvContact.ItemsSource = categories.Others;
        }
    }
}
