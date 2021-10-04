# Challenge_concurso_preguntas_respuestas_sofka
## Funcionamiento del juego
### El juego consta de 5 clases: Guardar, Juego, Jugador, Ronda, Usuario.

#### La clase Usuario, es la encargada de configurar o pasar la innformación del juego, estas son las preguntas,las categorias, las respuestas y las opciones de respuesta que se mostraran al usuario mientras está jugando.

#### La clase Jugador, representa toda la información que se captura del jugador y la cual es la que se guardará luego en el historico para obtener la persistencia de los datos.

#### La clase Juego, representa el funcionamiento del juego en cuanto a mostrar y las preguntas y las opciones de respuesta al jugador para que este puede apreciarlas y en su momento hacer la correspondiente elección. La elección de la pregunta la hace de forma aleatoria.

#### La clase Ronda, es la que se encarga de hacer posible que el juador elija una respuesta y dependiendo de si está correcta o no, ir sumando los puntos que el jugador va ganando a medida que el juego avanza. Tambien da la opción de la retirada voluntaria al jugador y en caso de equivocarse en la respuesta termina el juego.

#### La clase Guardar es la encarga de de hacer como tal la persistencia de los datos, esta guarda la informacion del jugador en un archivo de texto y lo separa con comas.

### A medida que el jugador avance la complejidad de las preguntas irá aumentando e irá cambiando la categoría de las preguntas, en este caso existen 5 categorias como se puede apreciar, cada una en aumento de complejidad.

## Los archivos tienen una ruta preconfigurada, se recomienda cambiar las rutas para poder ejecutar el programa de forma correcta. Al momento de descargar los archivos del repo, coopiar la ruta de los archivos de texto que este contiene y modificarlos en el codigo para que funcione.