using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nullable__Delegate__Exceptions_Homework
{
    internal class Factoriall
    {
        public void Num(int n)

        {
            try
            {
                int multiple = 1;
                if (n>0)
                {
                    for (int i = 1; i <= n; i++) 
                    {
                        multiple *= i;
                    }
                    Console.WriteLine(multiple);
                }
                else
                {
                    throw new Exception("data not found");
                }
               
                
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
        }
    }
}
