using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefaultProperties
{
    public class MyClass
    {
        public int Age { get; set; } = default!;
        public string Name { get; set; } = default!;
        public string CityOfBirth { get; set; } = default!;
        public MyClass()
        {

        }
    }
}
