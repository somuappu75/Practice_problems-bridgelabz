using System;
using System.Collections.Generic;
using System.Text;

namespace Practice_problems
{
     public class DatePro
    {
        public void Getdate()
        {
            //Using Date Command In Visual Studio 
            DateTime dt1 = new DateTime();
            Console.WriteLine(dt1);
        }
        public void GetYear()
        {
            DateTime dt2 = new DateTime(2015, 12, 31);
            Console.WriteLine(dt2);
        }
        public void getstring()
        {
            string str1 = "hello";
            Console.WriteLine(str1);
        }
         
        
           
    }
}
