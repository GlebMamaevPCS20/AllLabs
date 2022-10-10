using AllLabsProject;

class AllLabs
{
    static void Main()
    {
        List<ILabs> labs = new List<ILabs>();
        labs.Add(new Lab1());
        labs.Add(new Lab2());
        labs.Add(new Lab3());
        labs.Add(new Lab4());
        labs.Add(new Lab5());
        labs.Add(new Lab6());

        Methods.LabsInfo(labs);

        bool running = true;

        while (running)                // запускаем бесконечный цикл
        {
            Console.Write("Введите ID лабораторной: ");
            string command = Console.ReadLine();

            switch (command)
            {
                case "clear":
                    Methods.Clear();
                    break;
                case "info":
                    Methods.LabsInfo(labs);
                    break;
                case "help":
                    Methods.Help();
                    break;
                case "exit":
                    running = false;
                    break;
                default:
                    {
                        Methods.Demo(labs, command);
                    }
                    break;
            }
        }
    }

}