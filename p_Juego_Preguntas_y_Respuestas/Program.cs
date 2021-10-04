using System;
using System.Collections.Generic;
using System.IO;
using p_Juego_Preguntas_y_Respuestas.Clases;

namespace p_Juego_Preguntas_y_Respuestas
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                List<string> preguntas = new List<string>();
                List<string> opciones_respuestas = new List<string>();
                List<string> categorias = new List<string>();
                List<string> respuestas = new List<string>();

                StreamReader archivo_preguntas = new StreamReader("C:\\Users\\Antony Sanchez\\Desktop\\preguntas.txt");
                string linea;
                linea = archivo_preguntas.ReadLine();

                while (linea!=null)
                {
                    preguntas.Add(linea);

                    linea = archivo_preguntas.ReadLine();
                }
                StreamReader archivo_opciones_respuestas = new StreamReader("C:\\Users\\Antony Sanchez\\Desktop\\opciones_respuestas.txt");
                linea = archivo_opciones_respuestas.ReadLine();

                while (linea != null)
                {
                    opciones_respuestas.Add(linea);

                    linea = archivo_opciones_respuestas.ReadLine();
                }
                StreamReader archivo_respuestas = new StreamReader("C:\\Users\\Antony Sanchez\\Desktop\\respuestas.txt");
                linea = archivo_respuestas.ReadLine();

                while (linea != null)
                {
                    respuestas.Add(linea);

                    linea = archivo_respuestas.ReadLine();
                }

                categorias.Add("Historia");
                categorias.Add("Geografia");
                categorias.Add("Entretenimiento");
                categorias.Add("Arte y literatura");
                categorias.Add("Ciencia");


                Usuario creador = new Usuario(preguntas, categorias, opciones_respuestas, "Antony",respuestas);

                Jugador jug1 = new Jugador("javier", 21, "Monteria");

                
                Juego jueg1 = new Juego(creador.Nombre, jug1.Nombre);

                jueg1.Iniciar();


                
                Console.Write("Ingresa una de las opciones:");
                string texto = Console.ReadLine();

                if (texto == "1")
                {
                    Console.WriteLine("Muy bien, tendrás 5 preguntas, cada una con un nivel de complejidad mayor.");
                    Console.WriteLine("Después de que respondas bien la primera preguntas podrás retirarte con los puntos que tengas");
                    Console.WriteLine("Si te equivocas, perderás todos los puntos que tienes y el juego se acabará");

                    
                    Ronda rondas = new Ronda(creador, jug1, jueg1);

                    rondas.round_(jueg1, creador, jug1);



                }
                else
                {
                    Console.WriteLine("Has salido del juego, Saludos!!");
                }
            }
            catch(Exception error)
            {
                Console.WriteLine(error);
            }
            finally
            {
                Console.ReadKey();
            } 
        }
    }
}
