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
        Debug.Log("�ltima puntuaci�n: " + ultimoDestruidos);    // Muestra el record de la sesi�n
        InvokeRepeating("ImprimeDestruidos", 3f, 3f);           // Ejecuta cada 3 segundos el m�todo imprimeDesturidos
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
    /// Aumenta el valor de los objetos destru�dos, y adem�s, guarda la cantidad de objetos destru�dos para el momento de reiniciar el juego.
    /// </summary>
    public void Destruye()
    {
        objetosDestruidos++;
        ultimoDestruidos = objetosDestruidos;
    }

}
