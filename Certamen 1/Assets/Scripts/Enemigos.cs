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
        vidas = GameController.vidasEnemigos;       // Obtiene la cantidad de vidas seg�n el nivel de dificultad
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        vidas--;
        if (vidas <=0)                                      //Utiliza <= ya que puede recibir dos balas cont�nuas que no alcance a calcular, lo que podr�a dar un falso negativo a ==0
        {
            FindObjectOfType<GameController>().Destruye();  //Llama la funci�n de GameController para aumentar el contador de enemigos destru�dos
            Destroy(gameObject);                            //Destruye al enemigo que fue colisionado por la bala
        }

        Destroy(other.gameObject);                          //Destruye la bala que colision� al enemigo.
    }

}
