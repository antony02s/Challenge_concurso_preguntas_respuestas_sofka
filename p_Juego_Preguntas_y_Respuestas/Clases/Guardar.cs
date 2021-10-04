using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p_Juego_Preguntas_y_Respuestas.Clases
{
    class Guardar
    {
        private Jugador jugador;

        public Guardar(Jugador jugador)
        {
            Jugador = jugador;
        }

        internal Jugador Jugador { get => jugador; set => jugador = value; }

        public void Guardar_historico(Jugador jugador)
        {
            //Guardado de datos
            
            StreamWriter sw = new StreamWriter("C:\\Users\\Antony Sanchez\\source\\repos\\p_Juego_Preguntas_y_Respuestas\\historico.txt");
            
            sw.WriteLine(jugador.Nombre + "," + jugador.Edad + "," + jugador.Ciudad + "," + jugador.Puntaje);
            sw.Close();
        }
    }

    
}
