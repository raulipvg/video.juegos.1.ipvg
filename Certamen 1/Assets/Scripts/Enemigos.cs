using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemigos : MonoBehaviour
{
    [Range(1,3)]
    [SerializeField]
    public int vidas;
    // Start is called before the first frame update
    void Start()
    {
        vidas = 2;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        vidas--;
        if (SinVidas())
        {
            FindObjectOfType<GameController>().Destruye();
            Destroy(gameObject);        //Destruye al enemigo que fue colisionado por la bala
        }
        Destroy(other.gameObject);      //Destruye la bala que colisionó al enemigo.
    }
    /// <summary>
    /// Retorna falso si aún quedan vidas. True si no.
    /// </summary>
    /// <returns>true si no hay vidas</returns>
    public bool SinVidas()
    {
        return vidas <= 0;  //Utiliza <= ya que puede recibir dos balas contínuas que no alcance a calcular, lo que podría dar un falso negativo a ==0
    }

}
