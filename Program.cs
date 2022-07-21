using System;

namespace T10_Ejercicio2
{
    class Persona
    {
        private string nombre;
        private int edad;
        private string dni;
        private char sexo;
        private double peso;
        private double altura;

        private const int pesoIdeal = -1;
        private const int pesoBajo = 0;
        private const int pesoAlto = 1;


        public Persona()
        {
            nombre="";
            edad=0;
            sexo='H';
            peso=0;
            altura=0;
        }

        public Persona(string nombre, int edad, char sexo)
        {
            this.nombre = nombre;
            this.edad = edad;
            this.sexo = sexo;
            peso = 0;
            altura = 0;
        }

        public Persona(string nombre, int edad, char sexo, double peso, double altura)
        {
            this.nombre = nombre;
            this.edad = edad;
            this.sexo = sexo;
            this.peso = peso;
            this.altura = altura;
            generaDNI();
        }

        public String getNombre()
        {
            return this.nombre;
        }

        public void setNombre(string nombre)
        {
            this.nombre = nombre;
        }

        public int getEdad()
        {
            return this.edad;
        }

        public void setEdad(int edad)
        {
            this.edad = edad;
        }

        public Char getSexo()
        {
            return this.sexo;
        }

        public void setSexo(char sexo)
        {
            this.sexo = sexo;
        }

        public Double getPeso()
        {
            return this.peso;
        }

        public void setPeso(double peso)
        {
            this.peso = peso;
        }

        public Double getAltura()
        {
            return this.altura;
        }

        public void setAltura(double altura)
        {
            this.altura = altura;
        }

        public override string ToString()
        {
            return "Nombre: " + nombre + "\nPeso: " + peso + "\nEdad: " + edad + "\nAltura: " + altura + "\nSexo: " + sexo + "\nDNI: " + dni + "\n";
        }

        public int calcularIMC(double peso, double altura)
        {

            double ideal = peso / (altura * altura);


            if (ideal<20)
            {
                return pesoIdeal;
            }
            else if (ideal>=20 & ideal<=25)
            {
                return pesoBajo;
            }
            else
            {
                return pesoAlto;
            }
        }

        public bool esMayorDeEdad(int edad)
        {
            if (edad>=18)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private char comprobarSexo(char sexo)
        {
            if (sexo != 'H' || sexo != 'H')
            {
                return 'H';
            }
            else
            {
                return sexo;
            }
        }

        private void generaDNI()
        {
            string dni = "";
            //Las letras del DNI siguen este orden establecido y están relacionadas con el resto de la división
            //del número del DNI/23. El resto resultante es la posición de la letra según esta lista.
            string[] letra = { "T", "R", "W", "A", "G", "M", "Y", "F", "P", "D", "X", "B", "N", "J", "Z",
                "S", "Q", "V", "H", "L", "C", "K", "E" };

            Random random = new Random();
            int clave;

            for (int i = 0; i < 8; i++)
            {
                clave = random.Next(0, 9);
                Convert.ToChar(clave);
                dni += clave;
            }

            int dni2 = Convert.ToInt32(dni);
            int posicion = dni2 % 23;
            this.dni = dni + letra[posicion];            
        }

        public string getDNI()
        {
            generaDNI();
            return dni;
        }

    }

    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Escriba el nombre: ");
            string nombre = Console.ReadLine();
            Console.WriteLine("Escriba la edad: ");
            int edad = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Escriba el sexo: ");
            //Le indico que coja solo el primer carácter
            char sexo = Console.ReadLine()[0];            
            Console.WriteLine("Escriba el peso: ");
            double peso = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Escriba la altura: ");
            double altura = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();

            Persona objeto1 = new Persona(nombre, edad, sexo, peso, altura);
            Console.WriteLine(objeto1);

            Persona objeto2 = new Persona(nombre, edad, sexo);
            Console.WriteLine(objeto2);

            Persona objeto3 = new Persona();
            Console.WriteLine(objeto3);

            //Persona objeto2 = new Persona();
            //objeto1.setNombre(nombreNew);
            //objeto1.setEdad(edadNew);
            //objeto1.setSexo(sexoNew);            
            //objeto1.getDNI();

            //Persona objeto3 = new Persona();            
            //objeto1.getDNI();

        }
    }
}
