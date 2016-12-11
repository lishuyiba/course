using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _60异常处理中德catch块代码
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int n = 10;
                int m = 0;
                int sum = n / m;
                Console.WriteLine(sum);

                //string s = null;
                //s.ToCharArray();
                //Console.WriteLine("======ok======");

            }

            //1.catch块的第一种写法：这种写法可以捕获所有的异常。
            //catch
            //{
            //    Console.WriteLine("异常了。");
            //}

            //2.catch块的第一种写法：如果参数类型是Exception 这种写法可以捕获所有的异常。
            //catch (Exception ex)
            //{
            //    Console.WriteLine("异常了。{0}", ex.Message);
            //}

            //3.catch块的第一种写法：如果参数类型是：NullReferenceException 表示只能捕获空指针异常。只能单独捕获制定异常
            catch(NullReferenceException ex)
            {
                Console.WriteLine("异常了。{0}",ex.Message);
            }
            //其实就是对不同的异常分别捕获，可以对不同的异常单独处理。
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("又异常了。{0}", ex.Message);
            }

            //捕获所有异常的catch不能写在具体异常前面。
            //Exception类是所有异常类的祖宗类。
            //Exception:1>SystemException 2>ApplicationException
            //catch (Exception ex)
            //{
            //    Console.WriteLine("异常了。{0}", ex.Message);
            //} 

            finally
            {
                Console.WriteLine("finally:程序执行完毕！");
            }
            Console.ReadKey();
        }
    }
}
