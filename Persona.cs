using System;

namespace T10_Ejercicio2
{
    class Persona
    {
        private string nombre;
        //Utilizo el método reducido de set/get propio de C#
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        private int edad;
        public int Edad
        {
            get { return edad; }
            set { edad = value; }
        }
        private string dni;
        public string Dni
        {
            get { generaDNI(); return dni; }
            set { dni = value; }
        }

        private char sexo;
        public char Sexo
        {
            get { return sexo; }
            set { sexo = value; }
        }
        private double peso;
        public double Peso
        {
            get { return peso; }
            set { peso = value; }
        }
        private double altura;
        public double Altura
        {
            get { return altura; }
            set { altura = value; }
        }



        private const int pesoIdeal = -1;
        private const int pesoBajo = 0;
        private const int pesoAlto = 1;


        public Persona()
        {
            nombre = "";
            edad = 0;
            sexo = 'H';
            peso = 0;
            altura = 0;
        }

        public Persona(string _nombre, int _edad, char _sexo)
        {
            this.nombre = _nombre;
            this.edad = _edad;
            this.sexo = comprobarSexo(_sexo);
            this.peso = 0;
            this.altura = 0;
        }

        public Persona(string _nombre, int _edad, char _sexo, double _peso, double _altura)
        {
            this.nombre = _nombre;
            this.edad = _edad;
            this.sexo = comprobarSexo(_sexo);
            this.peso = _peso;
            this.altura = _altura;
            generaDNI();
        }

        public override string ToString()
        {
            return "Nombre: " + nombre + "\nPeso: " + peso + "\nEdad: " + edad + "\nAltura: " + altura + "\nSexo: " + sexo + "\nDNI: " + dni;
        }

        public int calcularIMC()
        {
            double ideal = peso / (altura * altura);

            if (ideal < 20)
            {
                return pesoIdeal;
            }
            else if (ideal >= 20 & ideal <= 25)
            {
                return pesoBajo;
            }
            else
            {
                return pesoAlto;
            }
        }

        public bool esMayorDeEdad()
        {
            if (edad >= 18)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private char comprobarSexo(char _sexo)
        {
            //Lo escrito lo pongo en mayúscula para la condición del if
            _sexo = char.ToUpper(_sexo);
            if (_sexo != 'H' && _sexo != 'M')
            {
                return 'H';
            }
            else
            {
                return _sexo;
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
    }
}