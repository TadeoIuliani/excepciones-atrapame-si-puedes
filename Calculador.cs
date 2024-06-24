using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtrapameEntidades
{
    public static class Calculador
    {
        public static float Calcular(int a, int b)
        {
            try
            {
                return a / b;
            }
            catch(Exception e)
            {
                throw e;
            }
        }
    }
}
