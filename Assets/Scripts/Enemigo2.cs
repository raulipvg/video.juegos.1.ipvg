using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemigo2 : MonoBehaviour
{
    // Start is called before the first frame update
    //[SerializeField] Transform[] waypoints;
    static Transform[] recorrido;
    static Vector3 siguientePosicion;
    float velocidad = 6.0f;
    float distanciaCambio = 0.5f;
    int nSiguientenPosicion = 0;
    private void Start()
    {
        transform.position = Iniciar.asignarPosicion(1);
        recorrido = Iniciar.asignarCamino(1);
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
