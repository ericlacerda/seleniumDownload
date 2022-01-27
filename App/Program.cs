using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace App
{
    public class Program
    {
        static void Main(string[] args)
        {


            using (WebClient cliente = new WebClient())
            {
                Console.WriteLine("Started");
                //pega o cookie da sesssão
                //string cookie = (string)((IJavaScriptExecutor)driver).ExecuteScript(@"var x = document.cookie; return x;");
                try
                {
                    string cookie = "";
                    for (int i = 2; i < args.Length; i++)
                    {
                        cookie += args[i].ToString();
                    }                    
                        cliente.Headers.Add(HttpRequestHeader.Cookie, cookie);

                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error Add Cookie");

                    Console.WriteLine(ex.Message);
                }



                try
                {
                    cliente.DownloadFile(args[0], args[1]);

                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error Get file");
                    Console.WriteLine(ex.Message);

                }
            }


        }
    }
}
