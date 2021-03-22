using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms; // Needed for MessageBox

namespace Polymorphism
{
    class Dogs : Animal
    {
        // Field
        private string _name;

        // Constructor
        public Dogs(string name)
            : base("Dog")
        {
            _name = name;
        }

        // Name property
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        // MakeSound method
        public override void MakeSound()
        {
            MessageBox.Show("Woof! Woof!");
        }
    }
}
