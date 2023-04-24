using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JWTValidations
{
    public class Payload
    {
        public String Fingerprint = default!;
        public Payload() { }
        public Payload(String F)
        {
            Fingerprint = F;
        }

    }
}
