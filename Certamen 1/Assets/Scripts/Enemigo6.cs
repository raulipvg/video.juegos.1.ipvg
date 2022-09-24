using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemigo6 : MonoBehaviour
{

    public  int vida6 = 3;
    // Start is called before the first frame update
    private void OnCollisionEnter(Collision otro)
    {

            Debug.Log("Colisiona con algo ENEMIGO 6");
           
    
    }

    public  bool DanoVida()
    {
        vida6--;
        if (vida6 == 0) return true;
        else return false;
    }

}
