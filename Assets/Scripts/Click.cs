using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Click : MonoBehaviour
{
   public Color color1;
   public string mensaje;
   public GameObject gojo;

   void OnMouseDown() 
   {
    //Destroy the gameObject after clicking on it
    Debug.Log(mensaje);
    Destroy(gojo);
   }
}
