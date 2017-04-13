
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TODOList.Models
{
    public class TodoItem
    {
        public int Id;
        public DateTime Date { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Category Category { get; set; }
        public State StateItem { get; set;}
        public TodoItem()
        {
            StateItem = State.InProgress;
        }
    }

    public enum State
    {
        Done,
        InProgress,
        Deleted
    }
}
