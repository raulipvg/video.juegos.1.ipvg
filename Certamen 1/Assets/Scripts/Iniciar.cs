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

    // Start is called before the first frame update
    void Start()
    { 

        Vector3[] posicionesIniciales = new Vector3[5];

        posicionesIniciales[0] = new Vector3(6.14f, 1.5f, 7.76f);
        posicionesIniciales[1]= new Vector3(-10.9f, 1.5f, -7.76f);
        posicionesIniciales[2] = new Vector3(-11.21f, 1.5f, 17.4f);
        posicionesIniciales[3] = new Vector3(-16.49f, 1.5f, 6.65f);
        posicionesIniciales[4] = new Vector3(13.4f, 1.5f, -11.5f);

        List<int> aux = new List<int> ();

        // Por cada Enemigo asignar posicion inicial y Vector de movimiento
        for (int i=0; i < posicionesIniciales.Length; i++)
        {
            int r = Random.Range(0, 5);
            
            while ( aux.IndexOf(r) > -1 )
            {
                r = Random.Range(0, 5);
            }

            aux.Add(r);

            //Asigno posicion inicial al enemigo de forma aleatoria
            enemigos[i].transform.position = posicionesIniciales[r];
            

            //Segun que enemigo sea asignar camino a tomar
            if (i == 0)
            {
                //Segun asignacion aleatoria de posicion inicial, se le asigna una ruta o camino a trazar
                switch (r)
                {
                    case 0:
                        Enemigo1.IniciarEnemigo(camino1);
                        break;
                    case 1:
                        Enemigo1.IniciarEnemigo(camino2);
                        break;
                    case 2:
                        Enemigo1.IniciarEnemigo(camino3);
                        break;
                    case 3:
                        Enemigo1.IniciarEnemigo(camino4);
                        break;
                    case 4:
                        Enemigo1.IniciarEnemigo(camino5);
                        break;
                }
            }

            else if (i == 1)
            {
                switch (r)
                {
                    case 0:
                        Enemigo2.IniciarEnemigo(camino1);
                        break;
                    case 1:
                        Enemigo2.IniciarEnemigo(camino2);
                        break;
                    case 2:
                        Enemigo2.IniciarEnemigo(camino3);
                        break;
                    case 3:
                        Enemigo2.IniciarEnemigo(camino4);
                        break;
                    case 4:
                        Enemigo2.IniciarEnemigo(camino5);
                        break;
                }
            }

            else if (i == 2)
            {
                switch (r)
                {
                    case 0:
                        Enemigo3.IniciarEnemigo(camino1);
                        break;
                    case 1:
                        Enemigo3.IniciarEnemigo(camino2);
                        break;
                    case 2:
                        Enemigo3.IniciarEnemigo(camino3);
                        break;
                    case 3:
                        Enemigo3.IniciarEnemigo(camino4);
                        break;
                    case 4:
                        Enemigo3.IniciarEnemigo(camino5);
                        break;
                }
            }

            else if (i == 3)
            {
                switch (r)
                {
                    case 0:
                        Enemigo4.IniciarEnemigo(camino1);
                        break;
                    case 1:
                        Enemigo4.IniciarEnemigo(camino2);
                        break;
                    case 2:
                        Enemigo4.IniciarEnemigo(camino3);
                        break;
                    case 3:
                        Enemigo4.IniciarEnemigo(camino4);
                        break;
                    case 4:
                        Enemigo4.IniciarEnemigo(camino5);
                        break;
                }
            }
            else if (i == 4)
            {
                switch (r)
                {
                    case 0:
                        Enemigo5.IniciarEnemigo(camino1);
                        break;
                    case 1:
                        Enemigo5.IniciarEnemigo(camino2);
                        break;
                    case 2:
                        Enemigo5.IniciarEnemigo(camino3);
                        break;
                    case 3:
                        Enemigo5.IniciarEnemigo(camino4);
                        break;
                    case 4:
                        Enemigo5.IniciarEnemigo(camino5);
                        break;
                }
            }



        }



    }

   

}
