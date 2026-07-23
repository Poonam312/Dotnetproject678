
using System.IO;

class Program
{
    static void Main()
    {
        string filee = "Student.txt";

        while (true)
        {
            Console.WriteLine("\n====== FILE HANDLING MENU ======");
            Console.WriteLine("1. Create/Write File");
            Console.WriteLine("2. Read File");
            Console.WriteLine("3. Append Data");
            Console.WriteLine("4. Check File Exists");
            Console.WriteLine("5. Copy File");
            Console.WriteLine("6. Move/Rename File");
            Console.WriteLine("7. Delete File");
            Console.WriteLine("8. Exit");

            Console.Write("Enter your choice: ");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.Write("Enter data to write: ");
                    string data = Console.ReadLine();

                    File.WriteAllText(filee, data);

                    Console.WriteLine("File created successfully.");
                    break;

                case 2:
                    if (File.Exists(filee))
                    {
                        string content = File.ReadAllText(filee);
                        Console.WriteLine("\nFile Content:");
                        Console.WriteLine(content);
                    }
                    else
                    {
                        Console.WriteLine("File does not exist.");
                    }
                    break;

                case 3:
                    Console.Write("Enter data to append: ");
                    string appendData = Console.ReadLine();

                    File.AppendAllText(filee, "\n" + appendData);

                    Console.WriteLine("Data appended successfully.");
                    break;

                case 4:
                    if (File.Exists(filee))
                        Console.WriteLine("File Exists.");
                    else
                        Console.WriteLine("File Does Not Exist.");

                    break;

                case 5:
                    if (File.Exists(filee))
                    {
                        File.Copy(filee, "StudentCopy.txt", true);
                        Console.WriteLine("File copied successfully.");
                    }
                    else
                    {
                        Console.WriteLine("File not found.");
                    }

                    break;

                case 6:
                    if (File.Exists(filee))
                    {
                        if (File.Exists("NewStudent.txt"))
                        {
                            File.Delete("NewStudent.txt");
                        }

                        File.Move(filee, "NewStudent.txt");

                        Console.WriteLine("File renamed to NewStudent.txt");
                    }
                    else
                    {
                        Console.WriteLine("File not found.");
                    }

                    break;

                case 7:
                    if (File.Exists(filee))
                    {
                        File.Delete(filee);
                        Console.WriteLine("File deleted successfully.");
                    }
                    else if (File.Exists("NewStudent.txt"))
                    {
                        File.Delete("NewStudent.txt");
                        Console.WriteLine("NewStudent.txt deleted.");
                    }
                    else
                    {
                        Console.WriteLine("No file found.");
                    }

                    break;

                case 8:
                    Console.WriteLine("Thank You!");
                    return;

                default:
                    Console.WriteLine("Invalid Choice.");
                    break;
            }
        }
    }
}