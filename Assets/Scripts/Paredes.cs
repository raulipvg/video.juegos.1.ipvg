using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paredes : MonoBehaviour
{
    private void OnTriggerEnter(Collider colision)
    {
        if (colision.gameObject.CompareTag("Bala"))     // Identifica mediante la etiqueta si al colisión fue por una bala
        {
            Destroy(colision.gameObject);               // Destruye la bala
        }
    }
}
