using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemigo3 : MonoBehaviour
{
    static Transform[] recorrido;
    static Vector3 siguientePosicion;
    float velocidad = 7.0f;
    float distanciaCambio = 0.5f;
    int nSiguientenPosicion = 0;
    private void Start()
    {
        transform.position = Iniciar.asignarPosicion(2);
        recorrido = Iniciar.asignarCamino(2);
        siguientePosicion = recorrido[0].position;
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
