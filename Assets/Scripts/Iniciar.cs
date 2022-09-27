using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Iniciar : MonoBehaviour
{
    [SerializeField] GameObject[] enemigos;

    [SerializeField] Transform[] camino1;
    [SerializeField] Transform[] camino2;
    [SerializeField] Transform[] camino3;
    [SerializeField] Transform[] camino4;
    [SerializeField] Transform[] camino5;

    private static Transform[] c1;
    private static Transform[] c2;
    private static Transform[] c3;
    private static Transform[] c4;
    private static Transform[] c5;
    private static List<int> recorridos;
    private static Vector3[] posicionesIniciales;
    void Start()
    { 

        posicionesIniciales = new Vector3[5];

        posicionesIniciales[0] = new Vector3(6.14f, 1.5f, 7.76f);
        posicionesIniciales[1]= new Vector3(-10.9f, 1.5f, -7.76f);
        posicionesIniciales[2] = new Vector3(-11.21f, 1.5f, 17.4f);
        posicionesIniciales[3] = new Vector3(-16.49f, 1.5f, 6.65f);
        posicionesIniciales[4] = new Vector3(13.4f, 1.5f, -11.5f);

         recorridos = new List<int> ();

        // Se crea una lista llamada recorridos que indica el orden aleatorio de las posiciones y rutas a asignar a los 5 enemigos
        for (int i=0; i < posicionesIniciales.Length; i++)
        {
            int r = Random.Range(0, 5);
            
            while (recorridos.IndexOf(r) > -1 )
            {
                r = Random.Range(0, 5);
            }
            recorridos.Add(r);
        }
        c1 = camino1;
        c2 = camino2;
        c3 = camino3;
        c4 = camino4;
        c5 = camino5;
    }
    //Retorna el recorrido para el enemigo i segun la asignacion aleatoria 
    private static int getRecorrido(int i) { return recorridos[i]; }

    //Asigna posicion aleatoria a un enemigo en particular
    public static Vector3 asignarPosicion(int nEnemigo) { return posicionesIniciales[getRecorrido(nEnemigo)]; }

    //Asigna el camino a seguir por un enemigo segun el seteo aleatorio
    public static Transform[] asignarCamino(int nEnemigo)
    {
        int camino = getRecorrido(nEnemigo);
        if (camino == 0){ return c1;
        }else if (camino == 1){ return c2;
        }else if (camino == 2){ return c3;
        }else if (camino == 3){ return c4;
        }else { return c5; 
        }
    }
}
