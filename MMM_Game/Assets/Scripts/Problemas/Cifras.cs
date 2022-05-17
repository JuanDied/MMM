using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Cifras : MonoBehaviour
{
    public Text Unacifra1;
    public Text Unacifra2;

    public ScoreBtn puntos;
  
    private int num1;
    private int num2;

    public Text respuestaField;
    private bool salta;
    private int rCorrecta;
    // Start is called before the first frame update
    void Start()
    {
        salta = true;
        num1 = Random.Range(1,9);
        num2 = Random.Range(1,9);
        Unacifra1.text = num1.ToString();
        Unacifra2.text = num2.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Respuesta()
    {
        rCorrecta = num1*num2;
        if(salta == true){
        if(int.Parse(respuestaField.text) == rCorrecta){
            Debug.Log("noiseee");
            puntos.AumentarPuntaje();
            salta = false;
        }else{

            Debug.Log("malooo");
            puntos.DisminuirPuntaje();
        }
        
    }
    }

   
}
