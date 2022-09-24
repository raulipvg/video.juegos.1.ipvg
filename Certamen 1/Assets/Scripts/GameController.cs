using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    int objetosDestruidos;
    int ultimoDestruidos;
    [SerializeField]
    [Range(1,3)]
    public int dificultad = 1;
    void Start()
    {
        objetosDestruidos = 0;
        Debug.Log("Última puntuación: " + ultimoDestruidos);    // Muestra el record de la sesión
        InvokeRepeating("ImprimeDestruidos", 3f, 3f);           // Ejecuta cada 3 segundos el método imprimeDesturidos
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    /// <summary>
    /// Imprime los elementos destruidos en la consola de debug.
    /// </summary>
    void ImprimeDestruidos()
    {
        Debug.Log("Enemigos destruidos: " + objetosDestruidos);
    }

    /// <summary>
    /// Aumenta el valor de los objetos destruídos, y además, guarda la cantidad de objetos destruídos para el momento de reiniciar el juego.
    /// </summary>
    public void Destruye()
    {
        objetosDestruidos++;
        ultimoDestruidos = objetosDestruidos;
    }

}
