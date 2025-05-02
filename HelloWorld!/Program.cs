using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace HelloWorld_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List <Employee> employees = new List <Employee> ();

            bool isOpen = true;
            while (isOpen)
            {
                DrawInterface();

                Console.SetCursorPosition(0, 14);
                Console.Write("Вы выбрали: ");
                int choosenElementOfMenu;
                bool trueParsing = int.TryParse(Console.ReadLine(), out choosenElementOfMenu);

                Console.SetCursorPosition(1, 2);
                if (trueParsing )
                {
                    if (choosenElementOfMenu == 1)
                    {
                        MakeANewEmployeer(ref employees);
                    }
                    else if (choosenElementOfMenu == 2)
                    {
                        ShowAllEmployeers(ref employees);
                    }
                    else if(choosenElementOfMenu == 3)
                    {
                        Console.SetCursorPosition (1, 12);
                        Console.Write("Введите номер сотрудника: ");

                        bool indexIsCorrect = int.TryParse(Console.ReadLine(), out int index);
                        if (indexIsCorrect)
                        {
                            employees.RemoveAt(index - 1);
                            Console.SetCursorPosition(1, 8);
                            Console.WriteLine("Сотрудник удалён!");
                            Thread.Sleep(2000);
                        }
                        else { Console.WriteLine("Введите корректные данные!"); }
                    }
                    else if (choosenElementOfMenu ==4)
                    {
                        isOpen = false;
                    }
                    else
                    {
                        Console.SetCursorPosition(5, 3);
                        Console.WriteLine("Введите число из списка элементов меню!!!");
                    }
                }
                else
                {
                    Console.SetCursorPosition(5, 3);
                    Console.WriteLine("Введите число из списка элементов меню!!!");
                }
                Thread.Sleep (2000);
                Console.Clear();
                 
            }
        }
        static void DrawInterface()
        {
            Console.WriteLine("########################################################################################################################");
            for (int i = 0; i < 15; i++)
            {
                Console.WriteLine("");
            }
            Console.WriteLine("########################################################################################################################");

            Console.WriteLine("\nМеню взаимодействия с программой:\n\n" +
                    "1. Добавить сотрудника\n\n" +
                    "2. Просмотр списка сотрудников\n\n" +
                    "3. Удалить сотрудника\n\n" +
                    "4. Выйти из программы");
        }
        static void MakeANewEmployeer (ref List<Employee> employees)
        {
            Employee employeere = new Employee();
            Console.Write("Введите ФИО нового сотрудника: ");
            employeere.Name = Console.ReadLine();
            Console.SetCursorPosition(1, 4);
            Console.Write("Введите специальность нового сотрудника: ");
            employeere.Speciality = Console.ReadLine();
            Console.SetCursorPosition(1, 6);
            Console.Write("Введите З/П нового сотрудника: ");
            bool salaryIsCorrect = int.TryParse(Console.ReadLine(), out int salary);
            if (salaryIsCorrect)
            {
                employeere.Salary = salary;
                employees.Add(employeere);
                Console.SetCursorPosition(1, 8);
                Console.WriteLine("Сотрудник добавлен!");
                Thread.Sleep(2000);
            }
            else { Console.WriteLine("Введите корректные данные!"); }
        }
        static void ShowAllEmployeers (ref List<Employee> employees)
        {
            Console.SetCursorPosition(1, 2);
            Console.WriteLine("Список сотрудников:");
            for (int i = 0; i < employees.Count(); i++)
            {
                Console.WriteLine($"Сотрудник № {i + 1}: Имя: {employees[i].Name} Специальность: {employees[i].Speciality} З/П: {employees[i].Salary}");
            }
            Console.ReadLine();
        }
    }
}
