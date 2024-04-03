using Library_04;
namespace task4
{
    class Program
    {
        static void Main(string[] args)
        {
            Virus grandparentVirus = new Virus(1.5, 5, "Grandparent Virus", "Type A");
            Virus parentVirus = new Virus(1.2, 3, "Parent Virus", "Type B");
            Virus childVirus1 = new Virus(0.8, 1, "Child Virus 1", "Type C");
            Virus childVirus2 = new Virus(0.7, 1, "Child Virus 2", "Type C");
            grandparentVirus.Children.Add(parentVirus);
            parentVirus.Children.Add(childVirus1);
            parentVirus.Children.Add(childVirus2);
            Virus clonedGrandparentVirus = (Virus)grandparentVirus.Clone();
            Console.WriteLine("Cloned Grandparent Virus Info:");
            clonedGrandparentVirus.PrintInfo();
            foreach (var child in clonedGrandparentVirus.Children)
            {
                Console.WriteLine("Child Info:");
                child.PrintInfo();
            }
        }
    }
}