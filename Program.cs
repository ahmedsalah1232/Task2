namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();
            char selection= ' ';
            do
            {
                Console.WriteLine("P - Print numbers");
                Console.WriteLine("A - Add number");
                Console.WriteLine("M - Display the mean of the number");
                Console.WriteLine("S - Display the smallest number");
                Console.WriteLine("l - Display the largest number");
                Console.WriteLine("Q - Quit");
                Console.Write("enter your selection :");
                selection = Convert.ToChar(Console.ReadLine().ToLower());
                switch (selection)
                {
                    case 'p':
                        if (list.Count == 0)
                        {
                            Console.WriteLine("[]");
                        }
                        else
                        {
                            Console.Write("[ ");
                            for (int i = 0; i < list.Count; i++)
                            {
                                Console.Write(list[i] + " ");
                            }
                            Console.WriteLine("]");
                        }
                        break;
                    case 'a':
                        int value;
                        Console.Write("enter your value :");
                        value = Convert.ToInt32(Console.ReadLine());
                        list.Add(value);
                        Console.WriteLine($"the value {value} is added");
                        break;
                    case 'm':
                        int sum = 0;
                        for (int i = 0; i < list.Count; i++)
                        {
                            sum += list[i];
                        }
                        Console.WriteLine($"the mean of the list is {(double)sum / list.Count}");
                        break;
                    case 's':
                        int mn = int.MaxValue;
                        for (int i = 0;i < list.Count; i++)
                        {
                            if(list[i] < mn)
                                mn= list[i];
                        }
                        Console.WriteLine($"the smallest value of the list is {mn}");
                        break;
                    case 'l':
                        int mx = int.MinValue;
                        for (int i = 0; i < list.Count; i++)
                        {
                            if (list[i] > mx)
                                mx= list[i];
                        }
                        Console.WriteLine($"the largest value of the list is {mx}");
                        break;
                    case 'q':
                        Console.WriteLine("Goodbye");
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("unknown selection,please try again");
                        break;
                }
            }while (selection!='q');
        }
    }
}
