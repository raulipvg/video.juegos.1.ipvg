# Trabajo 1 - Parte 1, Réplica Battle City Tank 3D

## Descripción del Juego
<br>Proyecto para la asignatura Taller de Videojuegos del Instituto Profesional Virginio Gómez. Consiste en replicar el juego Battle City Tank versión 3D, usando el motor gráfico de Unity en 3D, junto con C# como lenguaje para los scripts. El proyecto incluye la creación del laberinto, posicionar elementos en él y que tengan movimiento, trabajar las colisiones, almacenar los elementos destruidos como puntuación, modificar la dificultad (disparos para destruir un enemigo), y recargar la escena al quedar sin enemigos.

<br>Para el personaje del usuario se usó un cilindro rojo, mientras que los enemigos tienen forma de esfera o cubo, con distintos colores. Las balas son esferas rojas de menor tamaño.
<br>

### Índice
- [Teclas](#teclas)
- [Notas de versión](#notas-de-versión)
<br>

## Teclas
- Flecha arriba/abajo: Avanzar/retroceder
- Flecha izquierda/derecha: Girar a la izquierda/derecha
- Barra espaciadora: Disparar
<br>

## Sobre el Codigo
GameController: Se setea la dificultad en el Inspector con variables 1,2,3. Que corresponde a la vida de los enemigos.
EnemigosStart: Se asignan de manera publica los 5 enemigos y 5 caminos respectivos para asociarlos al Iniciar.cs. 



## Notas de versión

### 1.04
- Se le asigna orden de ejecucion a los scripts para que no existan conflictos. (En edit->Project Settings)
- GameController.cs: Se modifica la condicion de finalizacion del juego de update() a destruye()
- GameController.cs: Se crea metodo getVidaEnemigos(). Con el objtivo que sea mas orientado a objetos
- Iniciar.cs: Se reescribe el codigo de inicializacion de enemigos en su posicion y recorrido. Se hace el codigo mas legible y O.O
- Enemigo1...5.cs: Se reescribe el codigo y se crea la funcion Start() para realizar las llamadas a la clase Iniciar.cs
- Se comenta mas el codigo 

### V1.03
- Se modifica el radio del collider de Personaje para evitar el cruzar paredes en las uniones.
- Bala movida a carpeta Prefab
- La dificultad se administra desde GameController en la ventana de Inspector.
- Las vidas de cada enemigo depende de la dificultad: Ahora cada enemigo tiene la cantidad de vidas según la dificultad seleccionada en el Inspector de GameController.
- Objeto 'cubo' eliminado: No cumplía ninguna función.
- **Funciona el conteo de enemigos destruidos y la dificultad/vidas de los enemigos por Inspector.**
<br>

### V1.02
- El error del personaje persistía. Se había cargado dos veces el script Personaje, por ende, las velocidades se sumaban y eso hizo que el personaje cruzara la pared. Anteriormente se había quitado pero durante la ejecución. Ahora los cambios están guardados.
### Falta:
- Modificar las vidas de los enemigos según el nivel de dificultad. Actualmente se puede hacer pero de manera individual.
<br>

### V1.01
- Error en V1.0 arreglado: el personaje cruzaba paredes al chocar con ellas por un período de tiempo. Solucionado.
- **Ahora se dispara con la barra espaciadora.**
- La bala inicial fue eliminada, ahora cada vez que se dispara se crea una bala. Esto soluciona el error de V0.9 en que al destruir la bala inicial al chocar con una pared, donde se salía del cuerpo, arrojaba un NullPointerException. Ahora, la bala prefab se elimina del mapa, dejando solo como un objeto a instanciar. Así, al momento de disparar se instancia la bala. También, se asignó Personaje como padre de las balas disparadas.
- Al destruir los 5 enemigos la escena se reinicia (Punto 7). 
- Al cambiar de escena, muestra la última puntuación como la cantidad de enemigos destruidos en la escena anterior
<br>

### V1.0
- Agregado script Enemigos: detecta la colisión de la bala con el cuerpo, la destruye, después de 2 aciertos destruye el cuerpo. Además, lleva el control de vidas del cuerpo. Se modificó la función DanoVida por SinVidas, esta función devuelve true si las vidas son <=0 (condición que puede ocurrir cuando recibe dos o más balas y no alcanza a calcular la resta). Este script se agregó a todos los enemigos. Cada enemigo mantiene su script. Quizás se puede agregar las funciones de iniciar enemigo para unificar en un archivo las posiciones y movimientos. La variable de vidas se puede editar desde Unity, entiendo que se cambia el nombre por dificultad y listo el punto 6.
- Agregado script Paredes: análogo al script Enemigos, pero con los muros.
- Quitado script Balazo: los script anteriores ayudaron a eliminar el switch, por ende, no es necesario que la bala tenga esos controles.
- Agregado script GameController: Por ahora, guarda la cantidad de enemigos destruidos y muestra cada 3 segundos. Al iniciar el juego, muestra la última puntuación.
<br>

### V0.9
- Hay un error de que pierde la bala inicial (por colisión) y se queda sin balas, por lo cual tira un error en null. Favor Arreglar.
- Creé a cada enemigo una variable vida que esta seteada en 2 por ahora.
- Pero accedo a esas variables de forma no óptima (un switch en Balazo.cs).
- Falta el punto 5.
- Falta el punto 6.
- Falta el punto 7.
- Falta el punto 8.

<br>Version Editor 2020.3.37f1
<br>Desarrollo para la Asignatura de Videojuegos IPVG Evaluacion 1
<br> git config --global core.autocrlf false
