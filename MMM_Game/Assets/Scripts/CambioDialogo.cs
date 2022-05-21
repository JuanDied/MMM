using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class CambioDialogo : MonoBehaviour
{

    public Button boton;

    public Button botonIncorrecta1;
    public Button botonIncorrecta2;
    public Button botonIncorrecta3;
    public Button botonCorrecta;
   
    public ScoreBtn algo;
    public Text respuestaField;
   public GameObject dialogo1;
   public GameObject dialogo2;

   public GameObject dialogoSuper1;

   public GameObject dialogoSuper2;
    public GameObject dialogoDepor1;
    public GameObject dialogoDepor2;
    public GameObject dialogoDepor3;
    public GameObject respuesta;

    public GameObject dialogoMadre1;

    public GameObject dialogoMadre2;

    public GameObject dialogoMadre3;

    public GameObject respuestaMadre;

    public static bool supermercado;
    public static bool padrecito;
    private bool dial = false;
    private int super = 1;
    private int madre = 1;

    public Cifras answ;
    void Start()
    {
       
        dialogo2.SetActive(false);
        dialogoSuper1.SetActive(false);
        dialogoSuper2.SetActive(false);

        dialogoDepor1.SetActive(true);
        dialogoDepor2.SetActive(false);
        dialogoDepor3.SetActive(false);
        respuesta.SetActive(false);

        dialogoMadre1.SetActive(true);
        dialogoMadre2.SetActive(false);
        dialogoMadre3.SetActive(false);
        respuestaMadre.SetActive(false);
       
        
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
     void Update()
    {
        
       
    }

     public void cambioSupermercado()
    {  
        if(super==1){
        dialogoSuper1.SetActive(true);
        super++;
        boton.interactable = false;
        }
        else if(super==2){
        dialogoSuper2.SetActive(true);
        super++;
        boton.interactable = true;
        botonCorrecta.interactable = false;
        botonIncorrecta1.interactable = false;
        botonIncorrecta2.interactable = false;
        botonIncorrecta3.interactable = false;
        }
        else{
            supermercado=true;
            SceneManager.LoadScene("Resultados");
            
        }
    }

    public void cambioDeporte()
    {  
        bool cor = false;
        if(super==1){
        dialogoDepor1.SetActive(false);
        dialogoDepor2.SetActive(true);
        respuesta.SetActive(true);
        
        super++;
        }
        else if(super==2){
           cor = algo.Problema2(respuestaField.text);
            if(cor){
        dialogoDepor2.SetActive(false);
        dialogoDepor3.SetActive(true);
        respuesta.SetActive(true);
        super++;
         }else{

            }
        }
        else{
            SceneManager.LoadScene("Padre2");
        }
    }

     public void Madre2()
    {  
        if(madre==1){
        dialogoMadre1.SetActive(false);
        dialogoMadre2.SetActive(true);
        respuestaMadre.SetActive(true);
        madre++;
        }
        else if(madre==2){
           if(answ.Respuesta1()){
               answ.Respuesta2();
        dialogoMadre2.SetActive(false);
        dialogoMadre3.SetActive(true);
        respuestaMadre.SetActive(true);

        madre++;
           }else{

            }
        }
        else{
            SceneManager.LoadScene("Mapa");
        }
    }

    public void cambioPadre()
    {  
        if(dial==false){
        dialogo1.SetActive(false);
        dialogo2.SetActive(true);
        dial=true;
        }
        else if(dial==true){
        dial = false;
        padrecito = true;
        SceneManager.LoadScene("Mapa");
        }
    }
}
