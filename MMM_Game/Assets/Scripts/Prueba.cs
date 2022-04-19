using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using System.Text.RegularExpressions;

public class Prueba : MonoBehaviour
{

    public GameObject IngresaNombre;
    public GameObject Bienvenido;
    public GameObject Instrucciones;
    public GameObject Seguridad;
    public bool state = false;
    public int index = 0;
    public string nombre ="";

    [SerializeField] InputField inputField;

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
           nombre = inputField.text;
        if(nombre.Length < 3){
            bool alert = EditorUtility.DisplayDialog("Escribe tu nombre completo",
                "Tu nombre debe tener más de 3 letras", "Vale!");
        }
        else{
            IngresaNombre.SetActive(false);
        Bienvenido.SetActive(false);
        Instrucciones.SetActive(true);
        Seguridad.SetActive(false);
        index++;
        }    
        
       }
       else if(index == 2){
        IngresaNombre.SetActive(false);
        Bienvenido.SetActive(false);
          Instrucciones.SetActive(false);
        Seguridad.SetActive(true);
        index++;
       }
     
   }

   void OnEnable()
{
    //Register InputField Event
    inputField.onValueChanged.AddListener(inputValueChanged);
}


static string CleanInput(string strIn)
{
    // Replace invalid characters with empty strings.
    return Regex.Replace(strIn,
          @"[^a-zA-Z]", ""); 
}

//Called when Input changes
void inputValueChanged(string attemptedVal)
{
    inputField.text = CleanInput(attemptedVal);
}

void OnDisable()
{
    //Un-Register InputField Events
    inputField.onValueChanged.RemoveAllListeners();
}


}
