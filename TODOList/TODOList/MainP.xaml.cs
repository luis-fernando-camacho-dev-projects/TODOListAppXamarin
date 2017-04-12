using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TODOList.Models;
using TODOList.Views;
using Xamarin.Forms;

namespace TODOList
{
    public partial class MainP : MasterDetailPage
    {
        public MainP()
        {
            InitializeComponent();
            masterPage.ListViewCategories.ItemSelected += LvContant_ItemSelected;
        }

        private void LvContant_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var item = e.SelectedItem as Category;
            if (item != null)
            {
                Detail = new NavigationPage(new ListTodoItemsPage(item));
                IsPresented = false;
            }
        }
    }
}
