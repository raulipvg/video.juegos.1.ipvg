using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemigo1 : MonoBehaviour
{
    static Transform[] recorrido;
    static Vector3 siguientePosicion;
    [SerializeField]  float velocidad = 5.0f;
    [SerializeField]  float distanciaCambio = 0.5f;
    int nSiguientenPosicion = 0;
    // Start is called before the first frame update
    public static void IniciarEnemigo(Transform[] recorrido1)
    {
        siguientePosicion = recorrido1[0].position;
        recorrido = recorrido1;  
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(
            transform.position, 
            siguientePosicion, 
            velocidad * Time.deltaTime);

            if ( Vector3.Distance(transform.position, siguientePosicion) < distanciaCambio)
            {
                nSiguientenPosicion++;
                if (nSiguientenPosicion >= recorrido.Length)
                {
                    nSiguientenPosicion = 0;  
                }
                siguientePosicion = recorrido[nSiguientenPosicion].position;
            }
    }
}
