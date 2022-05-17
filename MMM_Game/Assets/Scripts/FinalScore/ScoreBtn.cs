using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ScoreBtn : MonoBehaviour
{

    public static int puntuacion = DefPuntaje.puntuacion;
    
    public Text textPuntuacion;
    // Start is called before the first frame update
    void Start()
    {
        textPuntuacion.text = puntuacion.ToString();
    }

    public void AumentarPuntaje()
    {
        puntuacion = puntuacion + 100;
        textPuntuacion.text = puntuacion.ToString();
        
    }

    public void DisminuirPuntaje()
    {
        if(puntuacion==0){
    
            
        }
        else{
            puntuacion = puntuacion - 50;
            textPuntuacion.text = puntuacion.ToString();

        }
       
        
    }

    public void Problema2(string Respuesta){

        if(int.Parse(Respuesta) == 900 )
        {
            Debug.Log("Respuesta Correcta");
            puntuacion = puntuacion + 100;
            textPuntuacion.text = puntuacion.ToString();
            

        }
        else{
           
            if(puntuacion==0){
    
            Debug.Log("Respuesta Incorrecta");
            }
            else{
            Debug.Log("Respuesta Incorrecta");
            puntuacion = puntuacion - 50;
            textPuntuacion.text = puntuacion.ToString();

            }
           
        }
    }
    

}
