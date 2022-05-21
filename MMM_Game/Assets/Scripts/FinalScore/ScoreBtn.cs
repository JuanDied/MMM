using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ScoreBtn : MonoBehaviour
{
    public GameObject fallaste;
    public static int puntuacion = DefPuntaje.puntuacion;

    public Text textPuntuacion;
    // Start is called before the first frame update
    void Start()
    {
        fallaste.SetActive(false);
        textPuntuacion.text = puntuacion.ToString();
        
    }
    private void Update() {
        if(Input.GetMouseButtonDown(0)){
                fallaste.SetActive(false);
            }
    }
    public void AumentarPuntaje()
    {

        puntuacion = puntuacion + 100;
        textPuntuacion.text = puntuacion.ToString();
        
    }

    public void DisminuirPuntaje()
    {
        fallaste.SetActive(true);
        
        if(puntuacion==0){
    
            
        }
        else{
            puntuacion = puntuacion - 50;
            textPuntuacion.text = puntuacion.ToString();

        }
       
        
    }

    public bool Problema2(string Respuesta){
        bool cor = false;
        if(int.Parse(Respuesta) == 900 )
        {
            Debug.Log("Respuesta Correcta");
            puntuacion = puntuacion + 100;
            textPuntuacion.text = puntuacion.ToString();
            cor = true;

        }
        else{
            fallaste.SetActive(true);
            cor=false;
            if(puntuacion==0){
    
            Debug.Log("Respuesta Incorrecta");
            }
            else{
            Debug.Log("Respuesta Incorrecta");
            puntuacion = puntuacion - 50;
            textPuntuacion.text = puntuacion.ToString();
                
            }
           
        }
        return cor;
    }
    

}
