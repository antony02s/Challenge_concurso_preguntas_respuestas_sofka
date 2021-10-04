using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p_Juego_Preguntas_y_Respuestas.Clases
{
    class Usuario
    {
        private List<string> l_preguntas;
        private List<string> l_categorias;
        private List<string> l_respuestas;
        private List<string> l_opciones_respuestas;
        private string nombre;

        public Usuario(List<string> l_preguntas, List<string> l_categorias, List<string> l_opciones_respuestas, string nombre, List<string> l_respuestas)
        {
            L_preguntas = l_preguntas;
            L_categorias = l_categorias;
            L_opciones_respuestas = l_opciones_respuestas;
            Nombre = nombre;
            L_respuestas = l_respuestas;
        }

        public List<string> L_preguntas
        {
            get => l_preguntas;
            set
            {
                if (value.Count < 25)
                {
                    throw new Exception("Error al ingresar la lista de preguntas");
                }
                else
                {
                    l_preguntas = value;
                }
            }
        }
        public List<string> L_categorias
        {
            get => l_categorias;
            set
            {
                if (value.Count < 5)
                {
                    throw new Exception("Error al ingresar la lista de categorias");
                }
                else
                {
                    l_categorias = value;
                }
            }
        }

        public List<string> L_opciones_respuestas
        {
            get => l_opciones_respuestas;
            set
            {
                if (value.Count < 100)
                {
                    throw new Exception("Error al ingresar la lista de las respuestas");
                }
                else
                {
                    l_opciones_respuestas = value;
                }
            }
        }

        public string Nombre { get => nombre;
            set 
            {
                if(string.IsNullOrEmpty(value)==true || string.IsNullOrWhiteSpace(value) == true)
                {
                    throw new Exception("Error al ingresar el nombre");
                }
                else
                {
                    nombre = value;
                }
            }
        }

        public List<string> L_respuestas { get => l_respuestas; set => l_respuestas = value; }
    }
}
