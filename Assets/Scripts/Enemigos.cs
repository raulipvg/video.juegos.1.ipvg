using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemigos : MonoBehaviour
{
    [Range(1,3)]
    [SerializeField]
    int vidas;

    // Start is called before the first frame update
    void Start()
    {
        vidas = GameController.getVidaEnemigos();       // Obtiene la cantidad de vidas según el nivel de dificultad
    }
    private void OnTriggerEnter(Collider other)
    {
        // Debug.Log("Choque con otro trigger");
        if (other.gameObject.CompareTag("Bala"))     // Identifica mediante la etiqueta si la colisión fue por una bala
        {
            vidas--;
            if (vidas <= 0)                                      //Utiliza <= ya que puede recibir dos balas contínuas que no alcance a calcular, lo que podría dar un falso negativo a ==0
            {
                FindObjectOfType<GameController>().Destruye();  //Llama la función de GameController para aumentar el contador de enemigos destruídos
                Destroy(gameObject);                            //Destruye al enemigo que fue colisionado por la bala
            }

            Destroy(other.gameObject); //Destruye la bala que colisionó al enemigo.
        }
    }

}
