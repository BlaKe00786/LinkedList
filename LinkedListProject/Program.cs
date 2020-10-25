using System;

namespace LinkedListProject
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList list = new LinkedList();
            int choice = 0,data,position;
            do
            {
                Console.WriteLine("\n1.Add at last \n2.Add at particular position \n3.Display LinkedList \n4.Exit \nEnter Your choice");
                choice = Convert.ToInt32(Console.ReadLine());
                switch(choice)
                {
                    case 1:Console.WriteLine("Enter Value: ");
                        data = Convert.ToInt32(Console.ReadLine());
                        list.Add(data);
                        break;
                    case 2:
                        Console.WriteLine("Enter Value: ");
                        data = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter position: ");
                        position = Convert.ToInt32(Console.ReadLine());
                        list.InsertAtParticularPosition(position,data);
                        break;
                    case 3:list.Display();
                        break;
                    case 4:choice = 4;
                        break;
                }
            
            } while (choice != 4);
        }
    }
}
