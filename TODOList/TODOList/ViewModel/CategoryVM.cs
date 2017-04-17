using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TODOList.Models;

namespace TODOList.ViewModel
{
    public class CategoryVM
    {
        public ObservableCollection<Category> Categories
        {
            get;
        }
        private static readonly Lazy<CategoryVM> instance = new Lazy<CategoryVM>(() => new CategoryVM());
        private CategoryVM()
        {
            Categories = new ObservableCollection<Category>();
            Init();
        }

        
        private void Init()
        {
            Categories.Add(new Category() { Name = "All", Description = "All Categories", Icon = "hamburger3.png" });
            Categories.Add(new Category() { Name = "family", Description = "family description", Icon = "hamburger3.png" });
            Categories.Add(new Category() { Name = "Work", Description = "Work description", Icon = "hamburger3.png" });
            Categories.Add(new Category() { Name = "Learning", Description = "Skill Study description", Icon = "hamburger3.png" });
        }

        [STAThread]
        public void AddCategory(Category category)
        {
            Categories.Add(category);
        }

        [STAThread]
        public Category FindCategory(string name)
        {
            return Categories.FirstOrDefault(ct => ct.Name.ToLower().Equals(name));
        }

       
        public static CategoryVM Instance
        {
            get
            {
                return instance.Value;
            }
        }
    }
}
