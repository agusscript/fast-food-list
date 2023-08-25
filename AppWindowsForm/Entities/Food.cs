using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppWindowsForm
{
    internal class Food
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Time { get; set; }
        public int Price { get; set; }
        public int Calories { get; set; }
        public bool Vegan { get; set; }
    }
}
