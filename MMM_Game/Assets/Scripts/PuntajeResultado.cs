using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PuntajeResultado : MonoBehaviour
{
    public static int puntuacion = ScoreBtn.puntuacion;
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
}
