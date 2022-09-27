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
    private void Start()
    {
        transform.position = Iniciar.asignarPosicion(0); //Asigna posicion inicial aleatoria del enemigo 0
        recorrido = Iniciar.asignarCamino(0); //Asigna camino a seguir aleatorio del enemigo 0
        siguientePosicion = recorrido[0].position; //Se le asigna el primer camino a seguir
    }
    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(
            transform.position, 
            siguientePosicion, 
            velocidad * Time.deltaTime);

            if ( Vector3.Distance(transform.position, siguientePosicion) < distanciaCambio) //Si el enemigo esta muy cerca de la distancia de cambio (se está acercando al punto)
            {
                nSiguientenPosicion++; 
                if (nSiguientenPosicion >= recorrido.Length) // Validacion que requiere cuando llegue al limite del arreglo del camino
                {
                    nSiguientenPosicion = 0;   // vuelve al recorrido inicial
                }
                siguientePosicion = recorrido[nSiguientenPosicion].position; //Que se diriga al otro punto del recorrido asignado
            }
    }
}
