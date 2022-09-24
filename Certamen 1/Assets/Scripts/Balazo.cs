using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Balazo : MonoBehaviour
{

    private void OnTriggerEnter(Collider otro)
    {
        // Debug.Log("Colisiona con algo Bala");
        if (otro.gameObject.CompareTag("Enemigo"))
        {
            Debug.Log("Bala al Enemigo");

            switch (otro.name)
            {
                case "Enemigo 1":
                    if (otro.GetComponent<Enemigo1>().DanoVida())
                    {
                        Destroy(otro.gameObject);

                    }
                    break;
                case "Enemigo 2":
                    if (otro.GetComponent<Enemigo2>().DanoVida())
                    {
                        Destroy(otro.gameObject);

                    }
                    break;
                case "Enemigo 3":
                    if (otro.GetComponent<Enemigo3>().DanoVida())
                    {
                        Destroy(otro.gameObject);

                    }
                    break;
                case "Enemigo 4":
                    if (otro.GetComponent<Enemigo4>().DanoVida())
                    {
                        Destroy(otro.gameObject);

                    }
                    break;
                case "Enemigo 5":
                    if (otro.GetComponent<Enemigo5>().DanoVida())
                    {
                        Destroy(otro.gameObject);

                    }
                    break;
                case "Enemigo 6":
                    if (otro.GetComponent<Enemigo6>().DanoVida())
                    {
                        Destroy(otro.gameObject);

                    }
                    break;
            }
            Destroy(this.gameObject);
        }
        else if (otro.gameObject.CompareTag("Muro"))
        {
            Debug.Log("Bala al Muro");
            Destroy(this.gameObject);

        }

    }


}
