using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UltimoProblema : MonoBehaviour
{
    public ScoreBtn puntos;
    public Text Unacifra1;
    public Text Unacifra2;
    public Text Unacifra3;
    public Text Unacifra4;
    public Text Doscifras1;
    public Text Trescifras1;
    private int num1;
    private int num2;
    private int num3;
    private int num4;
    private int num5;
    private int num6;
    private bool salta;
    public Text respuestaField;
    public GameObject fallaste;
    private int rCorrecta;
    // Start is called before the first frame update
    void Start()
    {
        salta = true;
        num1 = Random.Range(1,9);
        num2 = Random.Range(10,99);
        num3 = Random.Range(100,500);
        num4 = Random.Range(1,9);
        num5 = Random.Range(1,9);
        num6 = Random.Range(1,9);
        Unacifra1.text = num1.ToString();
        Unacifra2.text = num4.ToString();
        Unacifra3.text = num5.ToString();
        Unacifra4.text = num6.ToString();
        Doscifras1.text = num2.ToString();
        Trescifras1.text = num3.ToString();
    }

    // Update is called once per frame
    void Update()
    {
         if(Input.GetMouseButtonDown(0)){
                fallaste.SetActive(false);
            }
    }

    public bool Respuesta1()
    {
        
        bool resp = false;
        rCorrecta = num1*num2+num3+num4+num5+num6;
        if(salta == true){
            if(int.Parse(respuestaField.text) == rCorrecta){
                Debug.Log("noiseee");
                puntos.AumentarPuntaje();
                salta = false;
                resp = true;
             }else{

                Debug.Log("malooo");
                puntos.DisminuirPuntaje();
                resp = false;
            }
        
    }
    return resp;
    }

      public void Respuesta2()
    {
        
        
        rCorrecta = num1*num2+num3+num4+num5+num6;
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
