using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Personaje : MonoBehaviour
{
    float velocidadAvance = 3.0f;                                          //velocidad a la que avanzar� sentido adelante/atr�s
    float velocidadRotacion = 20.0f;                                       //velocidad de rotaci�n, al mover las flechas izquierda/derecha
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");                     //captura las teclas en horizontal (izquierda/derecha)
        float vertical = Input.GetAxis("Vertical");                         //captura las teclas en vertical (arriba/abajo)

        float avance = vertical * velocidadAvance * Time.deltaTime;         //Realiza el c�lculo por per�odo de tiempo, de cu�nto deber� moverse hacia adelante o atr�s
        float rotacion = horizontal * velocidadRotacion * Time.deltaTime;   //Realiza el�c�lculo por per�odo de tiempo, de cu�nto deber� rotar a izquierda y derecha

        transform.Rotate(Vector3.up, rotacion);                             //Efect�a la rotaci�n con respecto al frente del vector, tomando Vector3.up con referencia
        transform.position += transform.forward * avance;                   //Usa el transform.forward para moverse hacia adelante, avance le dice cu�nto ser� ese movimiento
     
    }

    /*
     Adem�s del script, en UNITY hubo que agregar el componente Rigidbody al cilindro personaje,
    y en sus propiedades, bloquear la rotaci�n en X,Y,Z adem�s de las posiciones Y,Z
    ya que, al colisionar con un cuerpo como el redondo, este lo rotaba por lo que los movimientos 
    los hac�a con una pendiente, ascendiendo por el plano ZY.
    */
}
