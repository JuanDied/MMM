using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Prueba : MonoBehaviour
{

    public GameObject IngresaNombre;
    public GameObject Bienvenido;
    public GameObject Instrucciones;
    public GameObject Seguridad;
    public bool state = false;
    public int index = 0;

   private void Start() {
       
       IngresaNombre.SetActive(false);
       Bienvenido.SetActive(true);
       Instrucciones.SetActive(false);
       Seguridad.SetActive(false);
   }
    public void ChangeUI()
   {
       

       if (state == false & index == 0){ 
       IngresaNombre.SetActive(true);
       Bienvenido.SetActive(false);
       Instrucciones.SetActive(false);
       Seguridad.SetActive(false);
       state = true;
       index++;
       }
       else if(index == 1){
        IngresaNombre.SetActive(false);
        Bienvenido.SetActive(false);
        Instrucciones.SetActive(true);
        Seguridad.SetActive(false);
        index++;
       }
       else if(index == 2){
        IngresaNombre.SetActive(false);
        Bienvenido.SetActive(false);
          Instrucciones.SetActive(false);
        Seguridad.SetActive(true);
        index++;
       }
     
   }


}
