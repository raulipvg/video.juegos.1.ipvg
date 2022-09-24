using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paredes : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider colision)
    {
        if (colision.gameObject.CompareTag("Bala"))
        {
            Debug.Log("Bala en la pared");
            Destroy(colision.gameObject);
        }
    }
}
