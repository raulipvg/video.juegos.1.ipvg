using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemigo3 : MonoBehaviour
{
    static Transform[] recorrido;
    static Vector3 siguientePosicion;
    float velocidad = 4.0f;
    float distanciaCambio = 0.5f;
    int nSiguientenPosicion = 0;
    public static void IniciarEnemigo(Transform[] recorrido1)
    {
        //transform.position  = new Vector3(6.14f, 1.5f, 7.76f);
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

        if (Vector3.Distance(transform.position, siguientePosicion) < distanciaCambio)
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
