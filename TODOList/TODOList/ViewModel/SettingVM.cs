using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TODOList.Models;

namespace TODOList.ViewModel
{
    public class SettingVM
    {
        private static readonly Lazy<SettingVM> instance = new Lazy<SettingVM>(() => new SettingVM());

        public List<Setting> Settings
        {
            get;
            set;
        }

        public List<Setting> Others
        {
            get;
            set;
        }

        public static SettingVM Instance
        {
            get
            {
                return instance.Value;
            }
        }

        private SettingVM()
        {
            Settings = new List<Setting>();
            Others = new List<Setting>();
            Init();
        }

        private void Init()
        {
            Settings.Add(new Setting() { Name = "Edit Lists",  Icon = "pencil.png" });
            Settings.Add(new Setting() { Name = "Edit Notebooks", Icon = "pencil.png" });
            Settings.Add(new Setting() { Name = "Change Notebook", Icon = "folder.png" });
            Settings.Add(new Setting() { Name = "Change Account", Icon = "account.png" });

            Others.Add(new Setting() { Name = "Settings",  Icon = "setting.png" });
            Others.Add(new Setting() { Name = "Contact Developer",  Icon = "mail.png" });
            Others.Add(new Setting() { Name = "Rate and Share",  Icon = "rate.png" });
        }
    }
}
