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
            lvGroup.ItemsSource = CategoryVM.Instance.Categories;
            lvSettings.ItemsSource = SettingVM.Instance.Settings;
            lvContact.ItemsSource = SettingVM.Instance.Others;
        }
    }
}
