using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Prueba : MonoBehaviour
{

    public GameObject IngresaNombre;
    public GameObject Bienvenido;
    public bool state = false;

   private void Start() {
       
       IngresaNombre.SetActive(false);
       Bienvenido.SetActive(true);
   }
    public void ChangeUI()
   {
       

       if (state == false){ 
       IngresaNombre.SetActive(true);
       Bienvenido.SetActive(false);
       state = true;
       }
     
   }
}
