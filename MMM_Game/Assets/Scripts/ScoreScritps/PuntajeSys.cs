using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PuntajeSys : MonoBehaviour
{
    public static int puntuacion = DefPuntaje.puntuacion;
    
    public Text textPuntuacion;
    // Start is called before the first frame update
    void Start()
    {
        
        
        textPuntuacion.text = puntuacion.ToString();
        
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    public void AumentarPuntaje()
    {
        puntuacion++;
        textPuntuacion.text = puntuacion.ToString();
        
    }

    public void DisminuirPuntaje()
    {
        puntuacion--;
        textPuntuacion.text = puntuacion.ToString();
        
    }

    public void CambiarEscena(){

        SceneManager.LoadScene("Score2");
    }

    public void CambiarEscena2(){

        SceneManager.LoadScene("ScoreSystem");
    }
}

