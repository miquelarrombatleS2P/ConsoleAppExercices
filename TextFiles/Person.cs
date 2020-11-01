using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextFiles
{
    class Person
    {
        public string firtsName { get; set; }
        public string lastName { get; set; }
        public int years { get; set; }
        public bool islive { get; set; }

        public string putText
        {
            get
            {
                string live = "is dead";
                if (islive == true)
                {
                    live = "is Alive";
                }

                return $"{firtsName}{lastName} is {years} and {live}";
            }

        }
    }
}
