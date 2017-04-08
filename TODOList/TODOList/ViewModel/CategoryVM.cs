using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TODOList.Models;

namespace TODOList.ViewModel
{
    public class CategoryVM
    {
        public List<Category> Categories
        {
            get;
            set;
        }

        public List<Category> Settings
        {
            get;
            set;
        }

        public List<Category> Others
        {
            get;
            set;
        }

        public CategoryVM()
        {
            Categories = new List<Category>();
            Settings = new List<Category>();
            Others = new List<Category>();
            Init();
        }

        private void Init()
        {
            Categories.Add(new Category() { Name = "family", Description = "family description", Icon = "icon.png" });
            Categories.Add(new Category() { Name = "Trabajo", Description = "Work description", Icon = "icon.png" });
            Categories.Add(new Category() { Name = "Estudio", Description = "Skill Study description", Icon = "icon.png" });

            Settings.Add(new Category() { Name = "Edit Lists", Description = "family description", Icon = "icon.png" });
            Settings.Add(new Category() { Name = "Edit Notebooks", Description = "Work description", Icon = "icon.png" });
            Settings.Add(new Category() { Name = "Change Notebook", Description = "Skill Study description", Icon = "icon.png" });
            Settings.Add(new Category() { Name = "Change Account", Description = "Skill Study description", Icon = "icon.png" });

            Others.Add(new Category() { Name = "Settings", Description = "family description", Icon = "hamburger.png" });
            Others.Add(new Category() { Name = "Contact Developer", Description = "Work description", Icon = "icon.png" });
            Others.Add(new Category() { Name = "Rate and Share", Description = "Skill Study description", Icon = "icon.png" });



        }
    }
}
