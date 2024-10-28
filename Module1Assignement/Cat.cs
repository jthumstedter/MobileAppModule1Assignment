using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace Module1Assignement
{
    internal class Cat : Pet, ITalkable
    {
        public int MousesKilled { get; set; }

        public Cat(string name, int mousesKilled) : base(name)
        {
            this.MousesKilled = mousesKilled;
        }

        public void AddMouse()
        {
            MousesKilled++;
        }

        public string GetName()
        {
            return Name;
        }

        public string Talk()
        {
            return "Meow";
        }

        public override string ToString()
        {
            return "Cat: " + " name = " + Name + " mousesKilled = " + MousesKilled;
        }
    }
}
