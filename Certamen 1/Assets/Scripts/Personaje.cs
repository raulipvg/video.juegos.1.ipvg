using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Personaje : MonoBehaviour
{
    float velocidadAvance = 3.0f;                                          //velocidad a la que avanzará sentido adelante/atrás
    float velocidadRotacion = 20.0f;                                       //velocidad de rotación, al mover las flechas izquierda/derecha
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");                     //captura las teclas en horizontal (izquierda/derecha)
        float vertical = Input.GetAxis("Vertical");                         //captura las teclas en vertical (arriba/abajo)

        float avance = vertical * velocidadAvance * Time.deltaTime;         //Realiza el cálculo por período de tiempo, de cuánto deberá moverse hacia adelante o atrás
        float rotacion = horizontal * velocidadRotacion * Time.deltaTime;   //Realiza el´cálculo por período de tiempo, de cuánto deberá rotar a izquierda y derecha

        transform.Rotate(Vector3.up, rotacion);                             //Efectúa la rotación con respecto al frente del vector, tomando Vector3.up con referencia
        transform.position += transform.forward * avance;                   //Usa el transform.forward para moverse hacia adelante, avance le dice cuánto será ese movimiento
     
    }

    /*
     Además del script, en UNITY hubo que agregar el componente Rigidbody al cilindro personaje,
    y en sus propiedades, bloquear la rotación en X,Y,Z además de las posiciones Y,Z
    ya que, al colisionar con un cuerpo como el redondo, este lo rotaba por lo que los movimientos 
    los hacía con una pendiente, ascendiendo por el plano ZY.
    */
}
