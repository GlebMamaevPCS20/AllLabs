using AllLabsProject;
using System.Reflection;

namespace AllLabsProject;
class AllLabs
{
    private static List<ILabs> _labs = new List<ILabs>();

    /// <summary>
    /// Метод получения списка уроков из dll библиотеки классов
    /// </summary>
    private static void LoadLabsList()
    {
        Assembly asm = Assembly.LoadFrom("LabsLib.dll");                         // создание сборки из библиотеки классов
        Type[] types = asm.GetTypes();                                              // выгрузка классов в массив
        foreach (Type type in types)                                                // перебираем классы и интерфейсы
        {
            if ((type.IsInterface == false) && (type.IsAbstract == false))          // не добавляем абстрактные классы и интерфейсы
            {
                foreach (var method in type.GetMethods())                           // перебираем методы класса
                {
                    if (method.ToString().Contains("Demo"))                         // если среди методов класса содержится Demo
                    {
                        ILabs lab = (ILabs)Activator.CreateInstance(type);
                        _labs.Add(lab);                                       // подгружаем этот класс в список уроков
                    }
                }
            }
        }
    }
    static void Main()
    {
        LoadLabsList();

        Methods.LabsInfo(_labs);

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
                    Methods.LabsInfo(_labs);
                    break;
                case "help":
                    Methods.Help();
                    break;
                case "exit":
                    running = false;
                    break;
                default:
                    {
                        Methods.Demo(_labs, command);
                    }
                    break;
            }
        }
    }

}