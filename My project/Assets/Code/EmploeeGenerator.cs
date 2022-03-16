using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace global
{
    public static class EmploeeGenerator
    {
        public static Emploee Next()
        {
            return new Emploee();
        }
    }
}
