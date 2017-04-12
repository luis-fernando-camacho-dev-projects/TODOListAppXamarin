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
        public ListView ListViewCategories { get { return lvGroup; } }
        public MasterPage()
        {
            
            InitializeComponent();
            CategoryVM categories = new CategoryVM();
            lvGroup.ItemsSource = categories.Categories;
            lvSettings.ItemsSource = categories.Settings;
            lvContact.ItemsSource = categories.Others;
            
        }
    }
}
