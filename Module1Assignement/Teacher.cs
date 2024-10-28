using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module1Assignement
{
    internal class Teacher : Person, ITalkable
    {
        public int Age { get; set; }
        public Teacher(string name, int age) : base(name)
        {
            Age = age;
        }

        public string GetName()
        {
            return Name;
        }

        public string Talk()
        {
            return "Don't forget to do the assigned reading!";
        }
    }
}
