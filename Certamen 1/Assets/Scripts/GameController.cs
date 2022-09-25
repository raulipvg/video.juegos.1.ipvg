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
    public int dificultad;
    void Start()
    {
        objetosDestruidos = 0;
        Debug.Log("Última puntuación: " + ultimoDestruidos);    // Muestra el record de la sesión
        InvokeRepeating("ImprimeDestruidos", 3f, 3f);           // Ejecuta cada 3 segundos el método imprimeDesturidos
        /*switch (dificultad)
        {
            case 1:
                gameObject.GetComponent<Enemigos>().SendMessage("DificultadFacil");
                break;
            case 2:
                gameObject.GetComponent<Enemigos>().SendMessage("DificultadMedia");
                break;
            case 3:
                gameObject.GetComponent<Enemigos>().SendMessage("DificultadDificil");
                break;
        }*/
            
    }

    // Update is called once per frame
    void Update()
    {
        if(objetosDestruidos == 5)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);         //Recarga la escena activa
        }
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
