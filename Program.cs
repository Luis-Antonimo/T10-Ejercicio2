using System;

namespace T10_Ejercicio2
{

    class Program
    {
        public static void Main(string[] args)
        {
            
            Console.WriteLine("Escriba el nombre: ");
            string nombre = Console.ReadLine();
            Console.WriteLine("Escriba la edad: ");
            int edad = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Escriba el sexo (H/M): ");
            //Le indico que coja solo el primer carácter
            char sexo = Console.ReadLine()[0];
            Console.WriteLine("Escriba el peso en Kilos: ");
            double peso = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Escriba la altura (punto para separar m. de cm.): ");
            double altura = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();

            Program public1 = new Program();
            Program public2 = new Program();

            Persona objeto1 = new Persona(nombre, edad, sexo, peso, altura);
            Console.WriteLine(objeto1);
            Console.WriteLine(public1.mayorDeEdad(objeto1.esMayorDeEdad(), nombre));
            Console.WriteLine(public2.pesoIdeal(objeto1.calcularIMC(), nombre));
            Console.WriteLine();

            Console.WriteLine("Escriba el nombre: ");
            nombre = Console.ReadLine();
            Console.WriteLine("Escriba la edad: ");
            edad = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Escriba el sexo (H/M): ");
            sexo = Console.ReadLine()[0];
            Console.WriteLine();

            Persona objeto2 = new Persona(nombre, edad, sexo);
            Console.WriteLine(objeto2);
            Console.WriteLine(public1.mayorDeEdad(objeto2.esMayorDeEdad(), nombre));
            Console.WriteLine();

            Persona objeto3 = new Persona();
            Console.WriteLine(objeto3);
            Console.WriteLine();
        }

        public string mayorDeEdad(bool validador, string _nombre)
        {
            if (validador)
            {
                return _nombre + " es mayor de edad.";
            }
            else
            {
                return _nombre + " no es mayor de edad.";
            }
        }

        public string pesoIdeal(int valor, string _nombre)
        {
            switch (valor)
            {
                case -1:
                    return _nombre + " tiene un peso ideal";
                case 0:
                    return _nombre + " tiene un peso inferior al adecuado.";
                case 1:
                    return _nombre + " tiene sobrepeso.";
            }
            return "";
        }
    }
}
