using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class CambioDialogo : MonoBehaviour
{
   public GameObject dialogo1;
   public GameObject dialogo2;

   public GameObject dialogoSuper1;

   public GameObject dialogoSuper2;
    private bool dial = false;
    private int super = 1;
    void Start()
    {
        dialogo2.SetActive(false);
        dialogoSuper1.SetActive(false);
        dialogoSuper2.SetActive(false);
        
    }

    // Update is called once per frame
    public void cambio()
    {  
        if(dial==false){
        dialogo1.SetActive(false);
        dialogo2.SetActive(true);
        dial=true;
        }
        else if(dial==true){
        dial = false;
        SceneManager.LoadScene("Mapa");
        }
    }

     public void cambioSupermercado()
    {  
        if(super==1){
        dialogoSuper1.SetActive(true);
        super++;
        }
        else if(super==2){
        dialogoSuper2.SetActive(true);
        super++;
        }
        else{
            SceneManager.LoadScene("Mapa");
        }
    }
}
