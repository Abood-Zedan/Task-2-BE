using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    abstract class AbstractPerson
    {
        public AbstractPerson(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public AbstractPerson() { }

        public int Id { get; set; }
        public string Name { get; set; }
        public abstract string DisplayInfo();
    }
}
