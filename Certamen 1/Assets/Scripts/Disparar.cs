using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disparar : MonoBehaviour
{
    //Agregan punto de inicio de donde la bala saldra.
    public GameObject BalaInicio;
    //Agregan Bala Prefab
    public GameObject BalaPrefab;
    //Agregar Bala Velocidad
    public float BalaVelocidad;

    // Update is called once per frame
    void Update()
    {
        //Input.GetButtonDown
        if (Input.GetButtonDown("Fire1"))
        {
           
            //1-Instanciar la BalaPrefab en las posiciones de BalaInicio
            GameObject BalaTemporal = Instantiate(BalaPrefab, BalaInicio.transform.position, BalaInicio.transform.rotation);

            //Obtener Rigidbody para agregar Fuerza. 
            Rigidbody rb = BalaTemporal.GetComponent<Rigidbody>();

            //Agregar la fuerza a la Bala
            rb.AddForce(transform.forward * BalaVelocidad);

            //Debemos Destruir la bala
            Destroy(BalaTemporal, 5.0f);
        }
    }

    

}
