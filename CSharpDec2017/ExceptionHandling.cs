using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDec2017
{
    public class ExceptionHandling
    {
        public void Display()
        {
            try
            {
                try
                {
                    int z = 0;
                    int divide = 10 / z;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("nested exception handled");
                }
                finally
                {
                    Console.WriteLine("nested finally");
                }

                int[] num = new int[2];
                num[0] = 10;
                num[1] = 20;
                //num[2] = 30;

                foreach (var item in num)
                {
                    Console.WriteLine(item);
                }
            }
            //catch {
            //    Console.WriteLine("someting went wrong");
            //}

            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
                Console.WriteLine("sorry!! get back to you later!!");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
                Console.WriteLine("sorry!! get back to you later!!");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
                Console.WriteLine("sorry!! get back to you later!!");
            }
            finally
            {
                Console.WriteLine("this is finally block");
            }

        }

        public void ThrowException()
        {
            throw new NotImplementedException();
        }

        public void TryFinally()
        {
            try
            {
                int z = 0;
                int divide = 10 / z;
            }
            finally
            {
                Console.WriteLine("try finally ");
            }
        }
    }
}
