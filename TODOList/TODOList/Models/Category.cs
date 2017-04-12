using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TODOList.Models
{
    public class Category
    {
        public string Icon { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public List<TodoItem> Tasks { get; set; }
    }
}
