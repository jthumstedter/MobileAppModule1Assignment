using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Module1Assignement
{
    internal class Dog : Pet, ITalkable
    {
        public bool Friendly { get; set; }
        public Dog(string name, bool friendly) : base(name)
        {
            Friendly = friendly;
        }

        public string GetName()
        {
            return Name;
        }

        public string Talk()
        {
            return "Bark";
        }
        public override string ToString()
        {
            return "Dog: " + "name = " + Name + " friendly = " + Friendly;
        }
    }
}
