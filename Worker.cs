using System;

// Создаем класс Worker
public class Worker
{
    // Приватные поля для данных о работнике
    private string name; // Имя работника
    private int age; // Возраст работника
    private double salary; // Заработная плата работника
    private string position; // Должность работника
    static public int counter;
    
    // Свойство для доступа к должности работника
    public string Position
    {
        get { return position; }
        set 
        { 
            // Проверяем, что новая должность не пустая
            if (string.IsNullOrEmpty(value)) {
                throw new ArgumentException("The new employee position cannot be empty.");
            }
            position = value; 
            
        }
    }
    
    public static int Counter
    {
        get {return counter;}
    }
    
    public string Name
    {
        get { return name; }
        private set 
        { 
            // Проверяем, что переданное значение не пустое
            if (string.IsNullOrEmpty(value))
                throw new ArgumentException("The employee name cannot be empty.");
            name = value; 
        }
    }
    
    public int Age
    {
        get { return age; }
        private set 
        { 
            // Проверяем, что переданное значение не отрицательное
            if (value < 0)
                throw new ArgumentException("The employee's age cannot be negative.");
            age = value; 
        }
    }
    
    public double Salary
    {
        get { return salary; }
        private set 
        { 
            // Проверяем, что переданное значение не отрицательное
            if (value < 0)
                throw new ArgumentException("An employee's salary cannot be negative.");
            salary = value; 
        }
    }

    // Конструктор класса Worker для инициализации полей данных
    public Worker(string name, int age, double salary, string position)
    {
        // Проверяем, что переданные значения не пустые или отрицательные
        if (string.IsNullOrEmpty(name))
            throw new ArgumentException("The employee name cannot be empty.");
        if (age < 0)
            throw new ArgumentException("The employee's age cannot be negative.");
        if (salary < 0)
            throw new ArgumentException("An employee's salary cannot be negative.");
        if (string.IsNullOrEmpty(position)) {
            throw new ArgumentException("The employee's position cannot be empty");
        }
        // Инициализируем поля данных
        this.name = name; // Имя сотрудника
        this.age = age; // Возраст сотрудника
        this.salary = salary; // Зарплата сотрудника до вычета налогов
        this.position = position; // Позиция сотрудника
        counter++;
    }

    
    
    // Метод для увеличения заработной платы работника на указанный процент
    public void IncreaseSalary(double percentage)
    {
        // Проверяем, что процент не отрицательный
        if (percentage < 0)
            throw new ArgumentException("Процент увеличения заработной платы не может быть отрицательным.");

        // Вычисляем новую заработную плату
        double increaseAmount = salary * (percentage / 100);
        Salary += increaseAmount;
    }
    
    // Метод для уменьшения заработной платы работника на указанный процент
    public void DecreaseSalary(double percentage)
    {
        // Проверяем, что процент не отрицательный
        if (percentage < 0)
            throw new ArgumentException("The percentage of salary reduction cannot be negative.");
    
        // Вычисляем сумму уменьшения
        double decreaseAmount = Salary * (percentage / 100);
        Salary -= decreaseAmount;
    }

    // Метод для получения информации о работнике (имя, возраст, должность, заработная плата)
    public string GetWorkerInfo()
    {
        double taxAmount = CalculateTax();
        double netSalary = this.salary - taxAmount;
        return $"Name: {Name}, Age: {Age}, Position: {Position}, Salary: {Salary}, Tax: {taxAmount}, Net Salary: {netSalary}";
    }

    // Метод для смены должности работника
    public void ChangePosition(string newPosition)
    {
        // Обновляем должность работника, используя инкапсуляцию
        Position = newPosition;
    }
    
    // Метод для вычисления налога на доходы
    public double CalculateTax()
    {
        double taxRate;

        // Определяем ставку налога в зависимости от заработной платы в Латвии
        if (salary <= 20004)
            taxRate = 0.20; // 20%
        else if (salary <= 78100)
            taxRate = 0.23; // 23%
        else
            taxRate = 0.31; // 31%

        // Вычисляем сумму налога
        double taxAmount = salary * taxRate;

        return taxAmount;
    }
    
    public void DismissalEmployee()
{
    // Выполнение дополнительных действий при удалении сотрудника

    // Очистка  полей класса
    this.salary = 0;
    this.position = "unemployed";

}
}
