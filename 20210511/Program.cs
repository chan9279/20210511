using System;
using System.Collections.Generic;

namespace _20210511
{
    class Program
    {
       
        static void Main(string[] args)
        {
            //어서오세요. 사토 보관가게입니다.
            Console.WriteLine("어서오세요. 보관가게 사토입니다.");
            //성함이 어찌되시나요?
            Console.WriteLine("성함이 어찌되시나요? : "); 
            List<string> names = new List<string>();
            List<string> kipnames = new List<string>();
            List<string> kipM = new List<string>();
            Dictionary<string, string> nameMap = new Dictionary<string, string>();
            string name1 = Console.ReadLine();
            names.Add(name1);
            //보관하신적 있으신가요?
            //for(int i = 1; i <= 20; i++)
            //{
            //    if (kipnames[i] == name1)
            //    {
            //        Console.WriteLine("보관하신 물건이 있습니다.");
                    
            //    }
            //    else
                    Console.WriteLine("보관하신 물건이 없습니다. 새 물건을 보관해드릴게요.");
            //}
            Console.WriteLine("어떤 물건을 보관해드릴까요?");
            string kip1 = Console.ReadLine();
            kipM.Add(kip1);
            kipnames.Add(name1);
            Console.WriteLine(kip1+"을 보관했습니다. 하루 보관 100엔입니다. ");

        }
    }
}
