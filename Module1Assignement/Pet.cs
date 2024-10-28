using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module1Assignement
{
    internal abstract class Pet
    {
        protected string Name { get; }

        public Pet(string name)
        {
            this.Name = name;
        }

    }
}
