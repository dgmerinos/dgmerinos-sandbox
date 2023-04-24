using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefaultProperties
{
    public class MyInitializedClass
    {
        public int Age { get; set; } = 0;
        public string Name { get; set; } = "NAME_PLACEHOLDER";
        public string CityOfBirth { get; set; } = "CITY_OF_BIRTH_PLACEHOLDER"!;
        public MyInitializedClass()
        {

        }
    }
}
