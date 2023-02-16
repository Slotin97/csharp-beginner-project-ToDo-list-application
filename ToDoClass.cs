using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace todolistapplication
{
    public class TodoItems
    {
        public string title;
        public string description;
        public DateTime dueDate;

        public TodoItems(string titles, string descriptions, DateTime dueDate)
        {
            this.title = titles;
            this.description = descriptions;
            this.dueDate = dueDate;
        }

    }
    
}
