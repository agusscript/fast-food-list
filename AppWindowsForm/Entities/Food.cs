using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppWindowsForm.Entities
{
    internal class Food
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public List<string> ingredientes { get; set; }
        public int tiempo { get; set; }
        public int precio { get; set; }
        public int calorias { get; set; }
        public bool vegana { get; set; }
    }
}
