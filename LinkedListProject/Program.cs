using System;

namespace LinkedListProject
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList list = new LinkedList();
            int choice = 0,data,position,key,output;
            do
            {
                Console.WriteLine("\n1.Add at last \n2.Add at particular position \n3.Delete First \n4.Delete Last \n5.Search \n6.exit\nEnter Your choice");
                choice = Convert.ToInt32(Console.ReadLine());
                switch(choice)
                {
                    case 1:Console.WriteLine("Enter Value: ");
                        data = Convert.ToInt32(Console.ReadLine());
                        list.Add(data);
                        list.Display();
                        break;
                    case 2:Console.WriteLine("Enter Value: ");
                        data = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter position: ");
                        position = Convert.ToInt32(Console.ReadLine());
                        list.InsertAtParticularPosition(position,data);
                        list.Display();
                        break;
                    case 3:list.pop();
                        list.Display();
                        break;
                    case 4:list.popLast();
                        list.Display();
                        break;
                    case 5:Console.WriteLine("Enter Value to be searched: ");
                        key = Convert.ToInt32(Console.ReadLine());
                        output=list.Search(key);
                        if(output!=-1)
                        {
                            Console.WriteLine("Found:" + output);
                        }
                        else
                        {
                            Console.WriteLine("not found");
                        }
                        break;
                    case 6:choice = 6;
                        break;
                }
            } while (choice != 6);
        }
    }
}
