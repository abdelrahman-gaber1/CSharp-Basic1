using Assignment2.Inhertinace;
using Common;

namespace Assignment2
{
    
    internal class Program
    {
        static void Main()
        {
            phoneBook phoneBook = new phoneBook(3);

            phoneBook.addPerson(0, "Abdo", 0111111);
            phoneBook.addPerson(1, "Ahmed", 0111112);
            phoneBook.addPerson(2, "Mohamed", 0111113);
            phoneBook.GetNumber("Abdo");
            phoneBook.SetNumber("Abdo", 01244545);
            Console.WriteLine(phoneBook["Abdo"]);
            phoneBook["Abdo"]= 0154654;

            for (int i = 0;i <phoneBook.Size; i++)
            {
                Console.WriteLine(phoneBook[i]);
            }


            Car car = new Car(10 , "BMW" , 360);
            Console.WriteLine(car.ToString());

            Parent parent1 = new Parent(10, 20);
            Console.WriteLine(parent1.proudct());
            Console.WriteLine(parent1.ToString());

            Child child = new Child(10 , 20 , 30);
            Console.WriteLine(child.proudct());
            Console.WriteLine(child.ToString());

            TypeA typeA = new TypeA();


        }
    }
}
