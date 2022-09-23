using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Iniciar : MonoBehaviour
{
    [SerializeField] GameObject[] enemigos;

    [SerializeField] Transform[] camino1;
    [SerializeField] Transform[] camino2;


    //public static List <Transform[]> recorridos;
    public static Transform[] recorrido2;

    // Start is called before the first frame update
    void Start()
    { 

        Vector3[] posicionesIniciales = new Vector3[2];

        posicionesIniciales[0] = new Vector3(6.14f, 1.5f, 7.76f);
        posicionesIniciales[1]= new Vector3(-10.9f, 1.5f, -7.76f);       

        List<int> aux = new List<int> ();

        // Por cada Enemigo asignar posicion inicial y Vector de movimiento
        for (int i=0; i < posicionesIniciales.Length; i++)
        {
            int r = Random.Range(0, 2);
            
            while ( aux.IndexOf(r) > -1 )
            {
                r = Random.Range(0, 2);
            }

            aux.Add(r);

            enemigos[i].transform.position = posicionesIniciales[r];

            if (i == 0)
            {
                switch (r)
                {
                    case 0:
                        Enemigo1.IniciarEnemigo1(camino1);
                        break;
                    case 1:
                        Enemigo1.IniciarEnemigo1(camino2);
                        break;
                }
            }

            else if (i == 1)
            {
                switch (r)
                {
                    case 0:
                        Enemigo2.IniciarEnemigo2(camino1);
                        break;
                    case 1:
                        Enemigo2.IniciarEnemigo2(camino2);
                        break;
                }
            }
               


        }



    }

   

}
