using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task.Models
{
    public abstract class BaseEntity:IBaseEntity
    {
        public int Id { get ; set ; }
        public string Name { get ; set ; }

        protected BaseEntity(int id,string name)
        {
            Id = id;
            Name = name;
        }
    }
}
