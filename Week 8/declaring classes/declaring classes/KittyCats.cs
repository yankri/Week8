using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace declaring_classes
{
    class KittyCats
    {
        string name;
        int age;
        string color;
        bool puked;

        public string Name
        {
          get { return this.name; }
          set { this.name = value; } //value is an implicit parameter whose type is the type of the property
        }

        public int Age
        {
            get { return this.age; }
            set { this.age = value; }
        }

        public string Color
        {
            get { return this.color; }
            set { this.color = value; }
        }

        public bool Puked
        {
            get { return this.puked; }
            set { this.puked = value; }
        }

        public KittyCats(string kittyName)
        {
            this.name = kittyName;
        }

        public KittyCats()
        {
            this.name = "Raven";
        }

    }
}
