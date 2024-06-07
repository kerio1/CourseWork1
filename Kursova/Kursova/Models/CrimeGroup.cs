using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kursova.Models
{
    public class CrimeGroup
    {
        private int id;
        private string name;
        //private List<string> criminals;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        //public List<string> Criminals
        //{
        //    get { return criminals; }
        //    set { criminals = value; }
        //}

        //public CrimeGroup(string name, List<string> criminals)
        //{
        //    this.name = name;
        //    this.criminals = criminals;
        //}

        public CrimeGroup(int id, string name)
        {
            this.id = id;
            this.name = name;
        }
    }
}
