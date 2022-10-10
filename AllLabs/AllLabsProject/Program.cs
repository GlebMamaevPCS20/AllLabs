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
        Console.WriteLine("Доступны следующие лабораторные: ");
        foreach (ILabs lab in labs)
        {
            Console.WriteLine(lab.Id());
        }
        Console.WriteLine("Введите номер лабораторной: ");
        int num = Convert.ToInt32(Console.ReadLine());
        for (int i = 0; i < labs.Count; i++)
        {
            if (labs[i].Id() == num)
            {
                labs[i].Demo();
            }
        }

    }
}