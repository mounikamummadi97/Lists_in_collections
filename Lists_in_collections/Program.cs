using System;
namespace list
{
    class list
    {
        static void Main()
        {
            List<int> list = new List<int>();
            list.Add(10); list.Add(20); list.Add(30); list.Add(40); list.Add(50); list.Add(60);
            for (int i = 0; i < list.Count; i++)
            {
                Console.Write(list[i] + " ");
                Console.WriteLine();
                list.RemoveAt(0);
                list.Insert(2,25);
            

                foreach(int u in list) 
             
                    Console.WriteLine(u);
                Console.ReadLine();
                
            }
        }
    }
}