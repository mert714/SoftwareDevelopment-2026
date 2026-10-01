using Microsoft.VisualBasic;
using System.Reflection.Metadata;
using System.Threading.Channels;

namespace Uprajnenie
{
    internal class Program
    {
        static void Main(string[] args)
        { }
           public string Title;
        public string Description;
        public DateTime DeadLine;
           public bool Completed;

        public MyTask(string title, string description, DateTime deadline, bool Completed)
        {
            Title = title;
            Description = description;
            DeadLine = deadline;
            Completed = false;

        }
        public void ShowTask(int number)
        {
            Console.WriteLine("Задача номер"+ number);
            Console.WriteLine("Заглавие" + Title);
            Console.WriteLine("Краен срок" + DeadLine );

            if (Completed)
                Console.WriteLine("Задачата е изпълнена");
            else
                Console.WriteLine("Задачата не е изпълнена");

        }

        class Program
        {
            static List<MyTask> tasks = new List <MyTask>();


            static void Main()
            {
                while (true)
                {
                    Console.WriteLine("Управление на задачи");
                    Console.WriteLine("1. Добави нова задача");
                    Console.WriteLine("2. Виж всички задачи");
                    Console.WriteLine("3. Маркирай задачата като изпълнена");
                    Console.WriteLine("4. Изтрий задачата");
                    Console.WriteLine("5. Изход");
                    string choice = Console.ReadLine();
                    if (choice == "1")
                    {
                        Console.WriteLine("Добави нова задача");
                    }
                    else if (choice == "2")
                    {
                        Console.WriteLine("Виж всички задачи");
                    }
                    else if (choice == "3")
                    {
                        Console.WriteLine("Маркирай задачата като изпълнена");

                    }
                    else if (choice == "4")
                    {
                        Console.WriteLine("Изтрий задачата");
                    }
                    else if (choice == "5")
                    {
                        Console.WriteLine("Програмата приключи");
                        break;
                    }
                    else
                    {
                        Console.WriteLine{"Невалидна опция"};
                    }


                }
            }

            static void AddTask()
            {
                Console.Write("Въведи заглавие");
                string title = Console.ReadLine();

                Console.Write("Въведи описание");
                string description = Console.ReadLine();

                Console.Write("Въведи краен срок");
                DateTime deadline= DateTime.Parse(Console.ReadLine());

                MyTask NewTask = new MyTask(title, description, deadline);

                tasks.Add(NewTask);
                Console.WriteLine("Задачата беше дошавена успешно");

            static ShowAllTasks()

                    if(tasks.Count == 0)
                {
                    Console.WriteLine("Няма въведени задачи");
                    return;
                }
                    for (int i = 0; i < tasks.Count; i++)
                {
                    tasks[i].ShowTask(i + 1);

                }

            
        }
        


        
        }
    }

