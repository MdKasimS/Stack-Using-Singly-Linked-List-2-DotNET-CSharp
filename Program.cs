using DSA;

internal class Program
{
    public static SLLStack stack = new SLLStack();

    private static void ContinueTest()
    {
        Console.WriteLine("Press any key to continue...");
        Console.ReadKey();
    }
    private static void Main(string[] args)
    {
        Console.Clear();
        Console.WriteLine("This is Singly Linked List Based Stack Implementation\n");
        Console.WriteLine("Press any key to continue...");
        Console.ReadKey();

        Console.Clear();
        int choice;
        string[] MenuItems = { "Push", "Pop", "Top", "Print Stack", "Is Empty", "Stack Size", "Exit" };
        int data;

        do
        {
            Console.WriteLine("Menu : ");
            Console.WriteLine("----------------------------------");
            for (int i = 0; i < MenuItems.Length; ++i)
            {
                Console.WriteLine($"{i + 1} {MenuItems[i]}");
            }
            Console.Write("Enter Your Choice : ");
            int.TryParse(Console.ReadLine(), out choice);

            switch (choice)
            {
                case 1:
                    Console.Clear();
                    Console.WriteLine($"---[{MenuItems[0]}]---");

                    Console.Write("Enter Data : ");
                    int.TryParse(Console.ReadLine(), out data);
                    stack.Push(data);

                    Console.Clear();
                    break;

                case 2:
                    Console.Clear();
                    Console.WriteLine($"---[{MenuItems[1]}]---");

                    Console.WriteLine($"Data popped : {stack.Peek()}");
                    stack.Pop();

                    Console.WriteLine("Press any key to continue...");
                    Console.ReadKey();
                    Console.Clear();
                    break;

                case 3:
                    Console.Clear();
                    Console.WriteLine($"---[{MenuItems[2]}]---");

                    Console.WriteLine($"Stack Top Data Is : {stack.Peek()}");

                    Console.WriteLine("Press any key to continue...");
                    Console.ReadKey();
                    Console.Clear();
                    break;

                case 4:
                    Console.Clear();
                    Console.WriteLine($"---[{MenuItems[3]}]---");

                    stack.PrintStack();

                    Console.WriteLine("Press any key to continue...");
                    Console.ReadKey();
                    Console.Clear();
                    break;

                case 5:
                    Console.Clear();
                    Console.WriteLine($"---[{MenuItems[4]}]---");

                    Console.WriteLine($"Stack Status : {stack.IsEmpty()}");

                    Console.WriteLine("Press any key to continue...");
                    Console.ReadKey();
                    Console.Clear();
                    break;


                case 6:
                    Console.Clear();
                    Console.WriteLine($"---[{MenuItems[2]}]---");

                    Console.WriteLine($"Total Stack Size Is : {stack.Size()}");

                    Console.WriteLine("Press any key to continue...");
                    Console.ReadKey();
                    Console.Clear();
                    break;

                case 7:
                    Console.Clear();
                    Console.WriteLine("Application Exited...");
                    Console.WriteLine("Press any key to continue...");
                    Console.ReadKey();
                    Console.Clear();
                    break;

                case 79: //It is hidden and only used for testing purpose. You can write your custom tests here. Take help ContinueTest() method see cler and neat output on console.
                    Console.Clear();
                    Console.WriteLine("Running Tests.....");

                    break;

                default:
                    Console.Clear();
                    Console.WriteLine("Please Enter Valid Choice");
                    Console.WriteLine("Press any key to continue...");
                    Console.ReadKey();
                    Console.Clear();
                    break;
            }
        } while (choice != 7);
    }
}