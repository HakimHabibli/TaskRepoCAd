using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task.Models
{
    public class Category:IEntity
    {
        private static int _id;
        public int Id { get; set; }
        public string CategoryName { get; set; }    
        public string Description { get; set; }
        public Category()
        {
            _id = Id;
            _id++;
        }
    }
}
