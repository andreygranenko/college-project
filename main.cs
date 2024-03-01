
using System;
class MainProgram {
  static void Main(string[] args)
    {
        try
        {
            // Создаем экземпляр работника с начальными данными
            Worker worker1 = new Worker("Ivan", 30, 2000, "Programmer");
            Console.WriteLine("Employee information:");
            Console.WriteLine(worker1.GetWorkerInfo()); // Вывод информации о работнике

            // Увеличиваем заработную плату на 10%
            worker1.IncreaseSalary(10);
            Console.WriteLine("\nInformation about the employee after a salary increase of 10%:");
            Console.WriteLine(worker1.GetWorkerInfo()); // Вывод информации о работнике

            // Уменьшаем заработную плату на 10%
            worker1.DecreaseSalary(10);
            Console.WriteLine("\nInformation about the employee after a salary decrease of 10%:");
            Console.WriteLine(worker1.GetWorkerInfo()); // Вывод информации о работнике

            // Меняем должность работника
            worker1.ChangePosition("Tester");
            Console.WriteLine("\nInformation about the employee after a change of position:");
            Console.WriteLine(worker1.GetWorkerInfo()); // Вывод информации о работнике
            
            // Создаем экземпляр работника с большей зарплатой для проверки вычета налогов
            Worker worker2 = new Worker("Andrew", 20, 80000, "Artist");
            Console.WriteLine("\nSecond employee information:");
            Console.WriteLine(worker2.GetWorkerInfo()); // Вывод информации о работнике
            
            // Увеличиваем заработную плату на 30%
            worker2.IncreaseSalary(30);
            Console.WriteLine("\nInformation about the second employee after a salary increase of 30%:");
            Console.WriteLine(worker2.GetWorkerInfo()); // Вывод информации о работнике

            // Уменьшаем заработную плату на 10%
            worker2.DecreaseSalary(10);
            Console.WriteLine("\nInformation about the second employee after a salary decrease of 10%:");
            Console.WriteLine(worker2.GetWorkerInfo()); // Вывод информации о работнике

            // Меняем должность работника
            worker2.ChangePosition("Cleaner");
            Console.WriteLine("\nInformation about the second employee after a change of position:");
            Console.WriteLine(worker2.GetWorkerInfo()); // Вывод информации о работнике
            
            // Вывод информации о работнике после увольнения
            worker2.DismissalEmployee();
            Console.WriteLine("\nInformation about the employee after dismissal:");
            Console.WriteLine(worker2.GetWorkerInfo()); // Здесь информация будет пустой
            
            Console.WriteLine(Worker.Counter);
            Console.ReadLine(); // Для работы программы
            
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }
}