# Notas de versión - Certamen 1

## V1.03
- Se modifica el radio del collider de Personaje para evitar el cruzar paredes en las uniones.
- Bala movida a carpeta Prefab
- La dificultad se administra desde GameController en la ventana de Inspector.
- Las vidas de cada enemigo depende de la dificultad: Ahora cada enemigo tiene la cantidad de vidas según la dificultad seleccionada en el Inspector de GameController.
- Objeto 'cubo' eliminado: No cumplía ninguna función.
- **Funciona el conteo de enemigos destruidos y la dificultad/vidas de los enemigos por Inspector.**

## V1.02
- El error del personaje persistía. Se había cargado dos veces el script Personaje, por ende, las velocidades se sumaban y eso hizo que el personaje cruzara la pared. Anteriormente se había quitado pero durante la ejecución. Ahora los cambios están guardados.
### Falta:
- Modificar las vidas de los enemigos según el nivel de dificultad. Actualmente se puede hacer pero de manera individual.

## V1.01
- Error en V1.0 arreglado: el personaje cruzaba paredes al chocar con ellas por un período de tiempo. Solucionado.
- **Ahora se dispara con la barra espaciadora.**
- La bala inicial fue eliminada, ahora cada vez que se dispara se crea una bala. Esto soluciona el error de V0.9 en que al destruir la bala inicial al chocar con una pared, donde se salía del cuerpo, arrojaba un NullPointerException. Ahora, la bala prefab se elimina del mapa, dejando solo como un objeto a instanciar. Así, al momento de disparar se instancia la bala. También, se asignó Personaje como padre de las balas disparadas.
- Al destruir los 5 enemigos la escena se reinicia (Punto 7). 
- Al cambiar de escena, muestra la última puntuación como la cantidad de enemigos destruidos en la escena anterior

## V1.0
- Agregado script Enemigos: detecta la colisión de la bala con el cuerpo, la destruye, después de 2 aciertos destruye el cuerpo. Además, lleva el control de vidas del cuerpo. Se modificó la función DanoVida por SinVidas, esta función devuelve true si las vidas son <=0 (condición que puede ocurrir cuando recibe dos o más balas y no alcanza a calcular la resta). Este script se agregó a todos los enemigos. Cada enemigo mantiene su script. Quizás se puede agregar las funciones de iniciar enemigo para unificar en un archivo las posiciones y movimientos. La variable de vidas se puede editar desde Unity, entiendo que se cambia el nombre por dificultad y listo el punto 6.
- Agregado script Paredes: análogo al script Enemigos, pero con los muros.
- Quitado script Balazo: los script anteriores ayudaron a eliminar el switch, por ende, no es necesario que la bala tenga esos controles.
- Agregado script GameController: Por ahora, guarda la cantidad de enemigos destruidos y muestra cada 3 segundos. Al iniciar el juego, muestra la última puntuación.

## V0.9
- hay un error de que pierde la bala inicial (por colisión) y se queda sin balas, por lo cual tira un error en null. Favor Arreglar
- Cree a cada enemigo una variable vida que esta seteada en 2 por ahora
- Pero accedo a esas variables de forma no óptima (un switch en Balazo.cs).
- Falta el punto 5. Que debe ser una basura.
- Falta el punto 6. Pero ya esta avanzado el tema de la vida 
- Falta el punto 7. Que no tiene mucha complejidad
- Falta el punto 8. Documentar con calidad

 
 Version Editor 2020.3.37f1 <br>
 Edicion de Raul <br>
 Desarrollo para la Asignatura de Videojuegos IPVG Evaluacion 1 <br>
