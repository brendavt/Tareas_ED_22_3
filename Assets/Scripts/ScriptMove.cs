using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*Investigadores:
Brenda Villegas Téllez
Ximena Cañéz Hernandez
*/
public class ScriptMove : MonoBehaviour
{
    /*Vector2, se usa en algunos casos para representar posiciones y vectores 2D en materiales o mallas de textura.*/
    /*Vector3, se usa para pasar posiciones y direcciones, representando vectores y puntos
    dentro del plano 2D de Unity.*/
    /*Vector4, se usa en los casos que se necesiten representar vectores de cuatro componentes.*/
    
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.A))
        {
            /*La variable "transform.position +=" llama a desplazar el sprite/objeto en las direcciones arriba,
            abajo, derecha, izquierda, andentro, fuera, etc.*/
            transform.position += Vector3.left; 
        }

        if (Input.GetKeyUp(KeyCode.D)) /*Cada vez que apretamos la tecla designada, el vector se va a sumar a la posición 
        del sprite permitiendo que este avance hacia la derecha; y de igual manera con el resto de las entradas
        creadas.*/
        {
            transform.position += Vector3.right;
        }

        if (Input.GetKeyUp(KeyCode.W))
        {
            transform.position += Vector3.up;
        }

        if (Input.GetKeyUp(KeyCode.S))
        {
            transform.position += Vector3.down;
        }
        
    }
}

/*Bibliografia:
https://www.youtube.com/watch?v=LGdEmNIzY8o&t=214s
https://docs.unity3d.com/es/530/ScriptReference/Vector3.html
*/
