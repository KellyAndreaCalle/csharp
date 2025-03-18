namespace HelloWork{

    class Program{
        static void  Main(){

            DateOnly dateConverted= new DateOnly();
            string nameInput;
            string birthdayInput; 
            Console.WriteLine("Hola, bienvenid@ al calculador de edad!");
            Console.WriteLine("Escribe tu nombre: ");
             nameInput = Console.ReadLine();
            Console.WriteLine($"Un gusto en conocerte {nameInput} ");
            Console.WriteLine("Escribe tu fecha de nacimiento en formato dd/mm/yy: ");
             birthdayInput = Console.ReadLine();
             bool isDataValid=DateOnly.TryParse(birthdayInput,out dateConverted);
             if(isDataValid==false) Console.WriteLine($"La fecha de nacimiento es invalida, usted nos envio este dato erroneo {birthdayInput}");
             var person= new Person{
                name=nameInput,
                Birthday=dateConverted,
                Age = DateTime.Now.Year - dateConverted.Year

             };
            Console.WriteLine($"Tu nombre: {person.name}");
            Console.WriteLine($"Tu fecha de nacimiento: {person.Birthday}");
            Console.WriteLine($"Tu edad es: {person.Age} años");

            Console.WriteLine();
        }
    }
  
    public class Person{
        public string name {get; set;}
        public DateOnly Birthday {get; set;}
        public int Age {get; set;}
    }
}