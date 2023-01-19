namespace OOPInheritance
{
    internal class MainEntrance
    {

        static void Main(string[] args)
        {

            Employee[] employees = new Employee[]
            {
            new Chairman("Lasha", "Kvachadze", 01001154689, "Male", 44, "Head of the Department", 2500, 2, 2),
            new Chairman("Ani", "Aniashvili", 01001154689, "Female", 20, "Head of the Department", 2500, 1, 2),
            new Engineer("Tsotne", "Mamaladze", 45008073456, "Male", 25, "Senior Engineer", 2000, "master"),
            };

            foreach (Employee item in employees)
            {
                item.GetEmployeeData();
                Console.WriteLine();
            }
            // გამართოთ კოდი
            // შევქმნათ ორივე კლასში (დეპარტამენტის ხელმძღვანელი და ინჟინერი დამახასიათებელი მეთოდი
            // გამოვიყვანო ყველა თანამშრომელი და თითოეული თანამდებობისთვის დამახასიათებელი მეთოდი.
        }
    }
}