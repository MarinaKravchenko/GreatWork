using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    class Song
    {
        private int _id;

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }
        
        private string _name;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        private Singer _singer;

        public Singer Singer
        {
            get { return _singer; }
            set { _singer = value; }
        }

    }
}
