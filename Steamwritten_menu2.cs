using Data2;
using System;
using System.ComponentModel.Design;


class Program
{
    static void Main()
    {
        List<Product> products = new List<Product>();
        string desktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop); bool running = true;
        string fileName = "";
        string fullPath = "";
       
        while (running)
        {
            Console.WriteLine("\n======== MENU ========");
            Console.WriteLine("|1. Enter File Name     |");
            Console.WriteLine("|2. Enter Text and Save |");
            Console.WriteLine("|3. Display File Content|");
            Console.WriteLine("|4.Exit                 |");       
            Console.Write("|Choose: ");
            string choice = Console.ReadLine();                              

            switch (choice)
            {

                case "1":

                      Console.WriteLine("Enterfilename: ");

                        fileName = Console.ReadLine() + ".txt";
                    fullPath = Path.Combine(desktop, fileName);

                        {
                            Console.WriteLine("User created this file and please check your desktop.");
                        }
                    

                    break;

                case "2":
                    if (fullPath == "")
                    {
                        Console.WriteLine("Please create/select file first!");
                    }

                    else
                    {
                        Console.Write("Enter Name: ");
                        string name = Console.ReadLine();


                        Console.Write("Enter Grade: ");
                        if (!int.TryParse(Console.ReadLine(), out int grade)
                             || grade < 50
                             || grade > 100)

                            {
                               Console.WriteLine("Invalid please try again");
                            }
                        else
                        {

                            Console.WriteLine("Invalid grade enetered!");
                        }




                            Product p = new Product
                            {
                                Name = name,
                                Grade = grade,
                                CreatedDate = DateTime.Now
                            };
                        products.Clear();
                        products.Add(p);
                      
                      using (StreamWriter writer = new StreamWriter(fullPath, true))  
                      {


                            foreach (var product in products)
                            {
                              writer.Write($"\n|Name:{product.Name}    |\n" +
                                             $"|Grade:{product.Grade}  |\n" +                                
                                             $"|CreatedDate:{product.CreatedDate.ToShortDateString()}|\n");


                        }


                      }
                    }
                  Console.WriteLine($"Saved successfully!" );
                    break;

                case "3":
                    if (fullPath == "")
                      {
                         Console.WriteLine("Please create/select file first!");
                      }

                    else if (File.Exists(fullPath))

                        {
                        Console.WriteLine(File.ReadAllText(fullPath));
                         }


                        else
                        {
                            Console.WriteLine("File does not exist yet.");
                        }
                    
                    
                    break;

                case "4":
                    running = false;
                    Console.WriteLine("Exiting program...");
                    break;

                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }
        }
    }
}