// // task1
//         // // List<string> names = new List<string>(){ "Ali", "Madina", "Bob", "Anora", "Tom", "Farrukh" };

        
//         // // Console.WriteLine("Все имена с индексами:");
//         // // for (int i = 0; i < names.Count; i++)
//         // // {
//         // //     Console.WriteLine($"{i} - {names[i]}");
//         // // }

        
//         // // names.RemoveAll(name => name.Length < 4);

//         // // names.Sort();

       
//         // // foreach (string name in names)
//         // // {
//         // //     Console.WriteLine(name);
//         // // }

        
//         // // Console.Write("\nВведите имя: ");
//         // // string inputName = Console.ReadLine() ?? "";

//         // // if (names.Contains(inputName))
//         // // {
//         // //     Console.WriteLine("Это имя есть в списке.");
//         // // }
//         // // else
//         // // {
//         // //     Console.WriteLine("Этого имени нет в списке.");
//         // // }

      
//         // // int countA = names.Count(name => name.StartsWith("A"));

//         // // Console.WriteLine($"Количество имён, начинающихся с буквы A: {countA}");
 

// // task2
//         // List<int> numbers = new List<int>{ 5, -3, 12, 0, -7, 8, 15, -1, 20 };

       
//         // numbers.RemoveAll(n => n < 0);

       
//         // Console.WriteLine(string.Join(", ", numbers));

       
//         // Console.WriteLine( numbers.Count);

       
//         // int sum = 0;

//         // foreach (int n in numbers)
//         // {
//         //     sum += n;
//         // }

        

//         // Console.WriteLine("Сумма: " + sum);
       

        
//         // int max = numbers[0];

//         // foreach (int n in numbers)
//         // {
//         //     if (n > max)
//         //     {
//         //         max = n;
//         //     }
//         // }

//         // Console.WriteLine( "Max число "+ max);

        
//         // List<int> greaterThan10 = new List<int>();

//         // foreach (int n in numbers)
//         // {
//         //     if (n > 10)
//         //     {
//         //         greaterThan10.Add(n);
//         //     }
//         // }

//         // Console.WriteLine("Числа больше 10: " + string.Join(", ", greaterThan10));
  




// // task3

//         // Person person = new Person("Ali", 19);
//         // Student student = new Student("Hasan", 20, "201");

//         // person.Introduce();

//         // Console.WriteLine();

//         // student.Introduce();
  

// //   task4


//         List<Vehicle> vehicles = new List<Vehicle>
//         {
//             new Car("Toyota", 2018, 4),
//             new Car("BMW", 2014, 2),
//             new Truck("Volvo", 2020, 15.5),
//             new Truck("MAN", 2013, 20)
//         };

       

//         foreach (Vehicle vehicle in vehicles)
//         {
//             Console.WriteLine(vehicle.GetInfo());
//         }

//         Console.WriteLine("бади 2015 бромад инами тигро ");

//         foreach (Vehicle vehicle in vehicles)
//         {
//             if (vehicle.Year > 2015)
//             {
//                 Console.WriteLine(vehicle.GetInfo());
//             }
//         }
    // task5

  
        // List<Animal> animals = new List<Animal>
        // {
        //     new Dog("Dog"),
        //     new Bird("Bird"),
        //     new Fish("Nemo")
        // };

        // foreach (Animal animal in animals)
        // {
        //     animal.MakeSound();
        //     animal.Move();
        // }

        // Для Dog вызывается метод Move() из класса Animal, потому что Dog не переопределяет Move().
         
// task7

        // List<BankAccount> accounts = new List<BankAccount> {new BankAccount("Bilol", 800),new SavingsAccount("Hasan", 800),    new CreditAccount("Olim", 800) };

        // double amount = 1000;

        // foreach (BankAccount account in accounts)
        // {
        //     bool bomj = account.Withdraw(amount);

        //     string result = bomj ? "Успешно" : "Отказ";

        //     Console.WriteLine(account.Owner +$"   Результат: {result}, " +$"Баланс: {account.Balance:F2}");
        // }

        

        // task8

        // List<Transport> transports = new List<Transport> {new Taxi(),new Bus(), new Metro() };

        // Console.Write("чан км мерай гап за тез: ");

        // if (!double.TryParse(Console.ReadLine(), out double km) || km < 0)
        // {
        //     Console.WriteLine("илтимос ай 0 калон гап за брат.");
        //     return;
        // }

        // Console.WriteLine("Варианто барои ту бародааааааааааар");

        // Transport cheapest = transports[0];

        // foreach (Transport transport in transports)
        // {
        //     double fare = transport.CalculateFare(km);

        //     Console.WriteLine($"{transport.Name}: {fare:F2}");

        //     if (fare < cheapest.CalculateFare(km))
        //     {
        //         cheapest = transport;
        //     }
        // }

        // Console.WriteLine($"Вариани арзон барои ту бародаааааааааар: {cheapest.Name}");
        // Console.WriteLine($"чан сми хдт бти : {cheapest.CalculateFare(km):F2}");
  

//   task9


//         ShoppingCart cart = new ShoppingCart();

//         cart.AddProduct(new Product("Keyboard", 100));
//         cart.AddProduct(new Product("Mouse", 50));
//         cart.AddProduct(new DiscountedProduct("Monitor", 300, 10));
//         cart.AddProduct(new DiscountedProduct("Headphones", 120, 20));

       
//         cart.PrintAll();

//         Console.WriteLine("\nRemoving Mouse...");

//         bool removed = cart.RemoveProduct("Mouse");

//         Console.WriteLine(
//             removed ? "Product removed successfully." : "Product not found.");

//         Console.WriteLine();
//         cart.PrintAll();


// task10

        List<Employee> employees = new List<Employee>{ new Manager("Ali", 5000),  new Developer("Hasan", 4000, 10),  new Intern("Olim", 2000),  new Developer("Malika", 4500, 15) };

        Console.WriteLine("Коргарои ман ");
    

        double totalSalary = 0;
        Employee highestPaid = employees[0];

        foreach (Employee employee in employees)
        {
            employee.PrintInfo();

            double salary = employee.CalculateSalary();
            totalSalary += salary;

            if (salary > highestPaid.CalculateSalary())
            {
                highestPaid = employee;
            }
        }

        Console.WriteLine($"Общая сумма: {totalSalary:F2}");
        Console.Write( $"Богатый: {highestPaid.Name}");
        Console.Write($": {highestPaid.CalculateSalary():F2}");
  
