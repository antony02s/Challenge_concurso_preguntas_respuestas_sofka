using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p_Juego_Preguntas_y_Respuestas.Clases
{
    class Ronda
    {
        private Usuario user;
        private Jugador jugador;
        private Juego juego;

        public Ronda(Usuario user, Jugador jugador, Juego juego)
        {
            User = user;
            Jugador = jugador;
            Juego = juego;
        }

        internal Usuario User { get => user; set => user = value; }
        internal Jugador Jugador { get => jugador; set => jugador = value; }
        internal Juego Juego { get => juego; set => juego = value; }


        public void round_(Juego juego,Usuario user,Jugador jugador)
        {
            try
            {
                Guardar guardar = new Guardar(jugador);
                //ronda 1
                Random r = new Random();
                int v_1 = r.Next(0, 4);
                juego.primera_pregunta(user, v_1);
                string eleccion_1;
                //se le pide al jugador que ingrese una eleccion
                Console.Write("Elige una opcion: ");
                eleccion_1 = Console.ReadLine();
                if (eleccion_1 == user.L_respuestas[v_1])
                {
                    Console.WriteLine("Respuesta Correcta, ganas 10 puntos y pasas a la siguiente ronda");
                    jugador.Puntaje += 10;
                }
                else
                {
                    guardar.Guardar_historico(jugador);
                    throw new Exception("Respuesta incorrecta en la pregunta, el juego se termina");
                }
                //ronda 2
                int v_2 = r.Next(5, 9);
                juego.segunda_pregunta(user, v_2);
                string eleccion_2;
                Console.Write("Elige una opcion: ");
                //se le pide al jugador que ingrese una eleccion
                eleccion_2 = Console.ReadLine();
                if (eleccion_2 == user.L_respuestas[v_2])
                {
                    Console.WriteLine("Respuesta Correcta, ganas 20 puntos y pasas a la siguiente ronda");
                    jugador.Puntaje += 20;
                }else if (eleccion_2 == "retirada")
                {
                    guardar.Guardar_historico(jugador);
                    throw new Exception("El usuairo ha decidido retirarse");
                }
                else
                {
                    jugador.Puntaje = 0;
                    guardar.Guardar_historico(jugador);
                    throw new Exception("Respuesta incorrecta en la pregunta, el juego se termina y pierdes todos tus puntos");
                }

                //ronda 3
                int v_3 = r.Next(10, 14);
                juego.tercera_pregunta(user, v_3);
                string eleccion_3;
                //se le pide al jugador que ingrese una eleccion
                Console.Write("Elige una opcion: ");
                eleccion_3 = Console.ReadLine();
                
                if (eleccion_3 == user.L_respuestas[v_3])
                {
                    Console.WriteLine("Respuesta Correcta, ganas 30 puntos y pasas a la siguiente ronda");
                    jugador.Puntaje += 30;
                }
                else if (eleccion_3 == "retirada")
                {
                    guardar.Guardar_historico(jugador);
                    throw new Exception("El usuairo ha decidido retirarse");
                }
                else
                {
                    jugador.Puntaje = 0;
                    guardar.Guardar_historico(jugador);
                    throw new Exception("Respuesta incorrecta en la pregunta, el juego se termina y pierdes todos tus puntos");
                }

                //Ronda 4
                int v_4 = r.Next(15, 19);
                juego.cuarta_pregunta(user, v_4);
                string eleccion_4;
                //se le pide al jugador que ingrese una eleccion
                Console.Write("Elige una opcion: ");
                eleccion_4 = Console.ReadLine();
                if (eleccion_4 == user.L_respuestas[v_4])
                {
                    Console.WriteLine("Respuesta Correcta, ganas 40 puntos y pasas a la siguiente ronda");
                    jugador.Puntaje += 40;
                }
                else if (eleccion_4 == "retirada")
                {
                    guardar.Guardar_historico(jugador);
                    throw new Exception("El usuairo ha decidido retirarse");
                }
                else
                {
                    jugador.Puntaje = 0;
                    guardar.Guardar_historico(jugador);
                    throw new Exception("Respuesta incorrecta en la pregunta, el juego se termina y pierdes todos tus puntos");
                }

                //ronda 5
                int v_5 = r.Next(20, 24);
                juego.quinta_pregunta(user, v_5);
                string eleccion_5;
                //se le pide al jugador que ingrese una eleccion
                Console.Write("Elige una opcion: ");
                eleccion_5 = Console.ReadLine();
                if (eleccion_5 == user.L_respuestas[v_5])
                {
                    Console.WriteLine("Respuesta Correcta, ganas 50 puntos y pasas a la siguiente ronda");
                    jugador.Puntaje += 50;
                }
                else if (eleccion_5 == "retirada")
                {
                    guardar.Guardar_historico(jugador);
                    throw new Exception("El usuairo ha decidido retirarse");
                }
                else
                {
                    jugador.Puntaje = 0;
                    throw new Exception("Respuesta incorrecta en la pregunta, el juego se termina y pierdes todos tus puntos");
                }

                
                // se guarda la información del historico si el jugador pasa todas las rondas
                guardar.Guardar_historico(jugador);
            }
            catch (Exception error)
            {
                Console.WriteLine(error);
            }
        } 
    }
}
