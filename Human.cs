using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capsulation_task
{
    public class Human
    {
        public string FullName { get; set; }
        public double PhoneNumber { get; set; }
        private byte _age;

        public byte Age
        {
            get
            {
                return _age;
            }
            set
            {
                if (value > 0 && value < 150)
                {
                    _age = value;
                }
            }
        }
            public string Name (string word1,string word2)
        {
            return word1 + word2;
        }
        

       
    }
}
