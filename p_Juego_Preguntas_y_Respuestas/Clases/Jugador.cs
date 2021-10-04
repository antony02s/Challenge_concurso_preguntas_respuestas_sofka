using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p_Juego_Preguntas_y_Respuestas.Clases
{
    class Jugador
    {
        private string nombre;
        private int edad;
        private string ciudad;
        private float puntaje = 0;

        public Jugador(string nombre, int edad, string ciudad, float puntaje = 0)
        {

            Nombre = nombre;
            Edad = edad;
            Ciudad = ciudad;
            Puntaje= puntaje;
        }

        public string Nombre
        {
            get => nombre;
            set
            {
                if (string.IsNullOrEmpty(value) == true || string.IsNullOrWhiteSpace(value) == true)
                {
                    throw new Exception("Error al ingresar el nombre");
                }
                else
                {
                    nombre = value;
                }
            }
        }
        public int Edad
        {
            get => edad;
            set
            {
                if (value < 0)
                {
                    throw new Exception("Error al ingresar la edad");
                }
                else
                {
                    edad = value;
                }
            }
        }
        public string Ciudad
        {
            get => ciudad;
            set
            {
                if (string.IsNullOrEmpty(value) == true || string.IsNullOrWhiteSpace(value) == true)
                {
                    throw new Exception("Error al ingresar la ciudad");
                }
                else
                {
                    ciudad = value;
                }
            }
        }

        public float Puntaje { get => puntaje; set => puntaje = value; }
    }
}
