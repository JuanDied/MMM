using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class RedirMapa : MonoBehaviour
{

    public static bool dad;
    public static bool dad2;
    // Start is called before the first frame update
    void Start()
    {
        dad = CambioDialogo.supermercado;
        dad2 = CambioDialogo.padrecito;
    }


    void Update(){

        
    }
    // Update is called once per frame
   public void Tienda()
    {
        SceneManager.LoadScene("Tienda");
    }

    public void Deporte()
    {
        SceneManager.LoadScene("Sport");
    }

    public void Biblioteca()
    {
        SceneManager.LoadScene("Biblioteca");
    }

     public void Mapa()
    {
        
        if(dad2){
            
            SceneManager.LoadScene("Madre2");
        }else if(dad){

            SceneManager.LoadScene("Padre");

        }else{

            SceneManager.LoadScene("Mapa");
        }

            
    }

     public void Madre()
    {
      
        SceneManager.LoadScene("Madre2");
        
    }

     public void Resultados()
    {
        if(dad2){
             SceneManager.LoadScene("Mama2");
        }else{
             SceneManager.LoadScene("Resultados");

        }
          
    }

       public void PapaDos()
    {
      
            SceneManager.LoadScene("Mama2");
        
    }
}
