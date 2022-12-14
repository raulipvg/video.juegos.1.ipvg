using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    int objetosDestruidos;
    static int ultimoDestruidos;
    [SerializeField]
    [Range(1,3)]
    private int dificultad = 1;
    private static int vidasEnemigos;                            //Que sea est?tico y se asigne el valor por Inspector permite que Enemigos pueda obtener el valor
    void Start()
    {
        vidasEnemigos = dificultad;
        objetosDestruidos = 0;
        Debug.Log("?ltima puntuaci?n: " + ultimoDestruidos);    // Muestra el record de la sesi?n
        InvokeRepeating("ImprimeDestruidos", 1f, 3f);           // Ejecuta el m?todo imprimeDesturidos desde el segundo 1 de ejecuci?n y lo repite cada 3 segundos

    }

    /// <summary>
    /// Imprime los elementos destruidos en la consola de debug.
    /// </summary>
    void ImprimeDestruidos()
    {
        Debug.Log("Enemigos destruidos: " + objetosDestruidos);
    }

    /// <summary>
    /// Aumenta el valor de los objetos destru?dos, y adem?s, guarda la cantidad de objetos destru?dos para el momento de reiniciar el juego.
    /// </summary>
    public void Destruye()
    {
        objetosDestruidos++;
        ultimoDestruidos = objetosDestruidos;

        if (objetosDestruidos == 5)
        {
            Debug.Log("Juego Terminado, Todos los enemigos eliminados!");
            Debug.Log("JUEGO REINICIADO");
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);         //Recarga la escena activa
        }
    }

    public static int getVidaEnemigos() { return vidasEnemigos; }

}
