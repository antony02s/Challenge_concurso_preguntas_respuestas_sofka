using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p_Juego_Preguntas_y_Respuestas.Clases
{
    class Juego
    {
        private string nombre_usr;
        private string nombre_jug;

        public Juego(string nombre_usr, string nombre_jug)
        {
            Nombre_usr = nombre_usr;
            Nombre_jug = nombre_jug;
        }

        public string Nombre_usr { get => nombre_usr; set => nombre_usr = value; }
        public string Nombre_jug { get => nombre_jug; set => nombre_jug = value; }


        //Metodos
        public void Iniciar()
        {
            Console.WriteLine("  /$$$$$$$  /$$$$$$$  /$$$$$$$$  /$$$$$$  /$$   /$$ /$$   /$$ /$$$$$$$$/$$$$$$  /$$$$$$$$/$$$$$$$$");
            Console.WriteLine(" | $$__  $$| $$__  $$| $$_____ / /$$__  $$| $$  | $$| $$$ | $$| __  $$__ /$$__  $$| __  $$__ / $$_____ /");
            Console.WriteLine(" | $$  \\ $$| $$  \\ $$| $$      | $$  \\__ /| $$  | $$| $$$$| $$   | $$ | $$  \\ $$   | $$  | $$  ");
            Console.WriteLine(" | $$$$$$$/| $$$$$$$/| $$$$$   | $$ /$$$$| $$  | $$| $$ $$ $$   | $$ | $$$$$$$$   | $$  | $$$$$ ");
            Console.WriteLine(" | $$____ / | $$__  $$| $$__ /   | $$| _  $$| $$  | $$| $$  $$$$   | $$ | $$__  $$   | $$  | $$__ /");
            Console.WriteLine(" | $$      | $$  \\ $$| $$      | $$  \\ $$| $$  | $$| $$\\  $$$   | $$ | $$  | $$   | $$  | $$      ");
            Console.WriteLine(" | $$      | $$  | $$| $$$$$$$$|  $$$$$$/|  $$$$$$/| $$ \\  $$   | $$ | $$  | $$   | $$  | $$$$$$$$ ");
            Console.WriteLine("| __/      |__/  |__/|________/ \\______/  \\______/ |__/  \\__/   |__/ |__/  |__/   |__/  |________/");

            Console.WriteLine(                    "Bienvenido al juego"                                    );
            Console.WriteLine(                      "1. Iniciar juego");
            Console.WriteLine(                      "2.Salir");
        }

        public void primera_pregunta(Usuario usr,int v)
        {
            //La primera pregunta será de la categoría Historia
            List<string> preg_historia = new List<string>();
            int count = 0;
            foreach(string element in usr.L_preguntas)
            {
                if (count < 5)
                {
                    preg_historia.Add(element);
                    count += 1;
                }
                  
            }
            // ahora necesitamos buscar las respuestas asociadas a la categoria historia
            List<string> respuestas_historia = new List<string>();
            count = 0;
            foreach(string element in usr.L_opciones_respuestas)
            {
                if (count < 20)
                {
                    respuestas_historia.Add(element);
                    count++;
                }
                
            }
            

            //Mostramos la pregunta al jugador
            Console.WriteLine(preg_historia[v]);

            // y mostramos las opciones de respuestas de la pregunta
            if (v == 0)
            {
                count = 0;
                int i = 1;
                foreach (string element in respuestas_historia)
                {
                    if (count < 4)
                    {
                        Console.WriteLine("{0}. {1}", i, element);
                        count++;
                        i++;
                    }
                }
                
            }
            if(v == 1)
            {
                count = 0;
                int i = 1;
                foreach (string element in respuestas_historia)
                {
                    if (count>= 4 && count<8)
                    {
                        Console.WriteLine("{0}. {1}", i, element);
                        count++;
                        i++;
                    }
                    else
                    {
                        count++;
                    }
                    
                }
            }
            if (v == 2)
            {
                count = 0;
                int i = 1;
                foreach (string element in respuestas_historia)
                {
                    if (count >= 8 && count < 12)
                    {
                        Console.WriteLine("{0}. {1}", i, element);
                        count++;
                        i++;
                    }
                    else
                    {
                        count++;
                    }

                }
            }
            if (v == 3)
            {
                count = 0;
                int i = 1;
                foreach (string element in respuestas_historia)
                {
                    if (count >= 12 && count < 16)
                    {
                        Console.WriteLine("{0}. {1}", i, element);
                        count++;
                        i++;
                    }
                    else
                    {
                        count++;
                    }

                }
            }
            if (v == 4)
            {
                count = 0;
                int i = 1;
                foreach (string element in respuestas_historia)
                {
                    if (count >= 16 && count < 20)
                    {
                        Console.WriteLine("{0}. {1}", i, element);
                        count++;
                        i++;
                    }
                    else
                    {
                        count++;
                    }

                }
            }
        }
        public void segunda_pregunta(Usuario usr, int v)
        {
            
            int count = 0;
            //Mostramos la pregunta al jugador
            Console.WriteLine(usr.L_preguntas[v]);
            Console.WriteLine(v);

            // y mostramos las opciones de respuestas de la pregunta
            if (v == 5)
            {
                count = 0;
                int i = 1;
                foreach (string element in usr.L_opciones_respuestas)
                {
                    if (count>=20 && count<24)
                    {
                        Console.WriteLine("{0}. {1}", i, element);
                        count++;
                        i++;
                    }
                    else
                    {
                        count++;
                    }
                }

            }
            if (v == 6)
            {
                count = 0;
                int i = 1;
                foreach (string element in usr.L_opciones_respuestas)
                {
                    if (count >= 24 && count < 28)
                    {
                        Console.WriteLine("{0}. {1}", i, element);
                        count++;
                        i++;
                    }
                    else
                    {
                        count++;
                    }

                }
            }
            if (v == 7)
            {
                count = 0;
                int i = 1;
                foreach (string element in usr.L_opciones_respuestas)
                {
                    if (count >= 28 && count < 32)
                    {
                        Console.WriteLine("{0}. {1}", i, element);
                        count++;
                        i++;
                    }
                    else
                    {
                        count++;
                    }

                }
            }
            if (v == 8)
            {
                count = 0;
                int i = 1;
                foreach (string element in usr.L_opciones_respuestas)
                {
                    if (count >= 32 && count < 36)
                    {
                        Console.WriteLine("{0}. {1}", i, element);
                        count++;
                        i++;
                    }
                    else
                    {
                        count++;
                    }

                }
            }
            if (v == 9)
            {
                count = 0;
                int i = 1;
                foreach (string element in usr.L_opciones_respuestas)
                {
                    if (count >= 36 && count < 40)
                    {
                        Console.WriteLine("{0}. {1}", i, element);
                        count++;
                        i++;
                    }
                    else
                    {
                        count++;
                    }

                }
            }
        }
        public void tercera_pregunta(Usuario usr, int v)
        {
            int count = 0;
            //Mostramos la pregunta al jugador
            Console.WriteLine(usr.L_preguntas[v]);

            // y mostramos las opciones de respuestas de la pregunta
            if (v == 10)
            {
                count = 0;
                int i = 1;
                foreach (string element in usr.L_opciones_respuestas)
                {
                    if (count >= 40 && count < 44)
                    {
                        Console.WriteLine("{0}. {1}", i, element);
                        count++;
                        i++;
                    }
                    else
                    {
                        count++;
                    }
                }

            }
            if (v == 11)
            {
                count = 0;
                int i = 1;
                foreach (string element in usr.L_opciones_respuestas)
                {
                    if (count >= 44 && count < 48)
                    {
                        Console.WriteLine("{0}. {1}", i, element);
                        count++;
                        i++;
                    }
                    else
                    {
                        count++;
                    }

                }
            }
            if (v == 12)
            {
                count = 0;
                int i = 1;
                foreach (string element in usr.L_opciones_respuestas)
                {
                    if (count >= 48 && count < 52)
                    {
                        Console.WriteLine("{0}. {1}", i, element);
                        count++;
                        i++;
                    }
                    else
                    {
                        count++;
                    }

                }
            }
            if (v == 13)
            {
                count = 0;
                int i = 1;
                foreach (string element in usr.L_opciones_respuestas)
                {
                    if (count >= 52 && count < 56)
                    {
                        Console.WriteLine("{0}. {1}", i, element);
                        count++;
                        i++;
                    }
                    else
                    {
                        count++;
                    }

                }
            }
            if (v == 14)
            {
                count = 0;
                int i = 1;
                foreach (string element in usr.L_opciones_respuestas)
                {
                    if (count >= 56 && count < 60)
                    {
                        Console.WriteLine("{0}. {1}", i, element);
                        count++;
                        i++;
                    }
                    else
                    {
                        count++;
                    }

                }
            }
        }
        public void cuarta_pregunta(Usuario usr, int v)
        {
            int count = 0;
            //Mostramos la pregunta al jugador
            Console.WriteLine(usr.L_preguntas[v]);

            // y mostramos las opciones de respuestas de la pregunta
            if (v == 15)
            {
                count = 0;
                int i = 1;
                foreach (string element in usr.L_opciones_respuestas)
                {
                    if (count >= 60 && count < 64)
                    {
                        Console.WriteLine("{0}. {1}", i, element);
                        count++;
                        i++;
                    }
                    else
                    {
                        count++;
                    }
                }

            }
            if (v == 16)
            {
                count = 0;
                int i = 1;
                foreach (string element in usr.L_opciones_respuestas)
                {
                    if (count >= 64 && count < 68)
                    {
                        Console.WriteLine("{0}. {1}", i, element);
                        count++;
                        i++;
                    }
                    else
                    {
                        count++;
                    }

                }
            }
            if (v == 17)
            {
                count = 0;
                int i = 1;
                foreach (string element in usr.L_opciones_respuestas)
                {
                    if (count >= 68 && count < 72)
                    {
                        Console.WriteLine("{0}. {1}", i, element);
                        count++;
                        i++;
                    }
                    else
                    {
                        count++;
                    }

                }
            }
            if (v == 18)
            {
                count = 0;
                int i = 1;
                foreach (string element in usr.L_opciones_respuestas)
                {
                    if (count >= 72 && count < 76)
                    {
                        Console.WriteLine("{0}. {1}", i, element);
                        count++;
                        i++;
                    }
                    else
                    {
                        count++;
                    }

                }
            }
            if (v == 19)
            {
                count = 0;
                int i = 1;
                foreach (string element in usr.L_opciones_respuestas)
                {
                    if (count >= 76 && count < 80)
                    {
                        Console.WriteLine("{0}. {1}", i, element);
                        count++;
                        i++;
                    }
                    else
                    {
                        count++;
                    }

                }
            }
        }
        public void quinta_pregunta(Usuario usr, int v)
        {
            int count = 0;
            //Mostramos la pregunta al jugador
            Console.WriteLine(usr.L_preguntas[v]);

            // y mostramos las opciones de respuestas de la pregunta
            if (v == 20)
            {
                count = 0;
                int i = 1;
                foreach (string element in usr.L_opciones_respuestas)
                {
                    if (count >= 80 && count < 84)
                    {
                        Console.WriteLine("{0}. {1}", i, element);
                        count++;
                        i++;
                    }
                    else
                    {
                        count++;
                    }
                }

            }
            if (v == 21)
            {
                count = 0;
                int i = 1;
                foreach (string element in usr.L_opciones_respuestas)
                {
                    if (count >= 84 && count < 88)
                    {
                        Console.WriteLine("{0}. {1}", i, element);
                        count++;
                        i++;
                    }
                    else
                    {
                        count++;
                    }

                }
            }
            if (v == 22)
            {
                count = 0;
                int i = 1;
                foreach (string element in usr.L_opciones_respuestas)
                {
                    if (count >= 88 && count < 92)
                    {
                        Console.WriteLine("{0}. {1}", i, element);
                        count++;
                        i++;
                    }
                    else
                    {
                        count++;
                    }

                }
            }
            if (v == 23)
            {
                count = 0;
                int i = 1;
                foreach (string element in usr.L_opciones_respuestas)
                {
                    if (count >= 92 && count < 96)
                    {
                        Console.WriteLine("{0}. {1}", i, element);
                        count++;
                        i++;
                    }
                    else
                    {
                        count++;
                    }

                }
            }
            if (v == 24)
            {
                count = 0;
                int i = 1;
                foreach (string element in usr.L_opciones_respuestas)
                {
                    if (count >= 96 && count < 100)
                    {
                        Console.WriteLine("{0}. {1}", i, element);
                        count++;
                        i++;
                    }
                    else
                    {
                        count++;
                    }

                }
            }
        }
    }
}
