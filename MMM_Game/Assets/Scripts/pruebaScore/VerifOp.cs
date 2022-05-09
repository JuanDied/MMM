using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VerifOp : MonoBehaviour
{
    public Text cifra1;
    public Text cifra2;
    private int num1;
    private int num2;
    public Text respuestaField;
    
    private int rCorrecta;
    // Start is called before the first frame update
    void Start()
    {
        num1 = Random.Range(0,900);
        num2 = Random.Range(0,9);
        cifra1.text = num1.ToString();
        cifra2.text = num2.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Respuesta()
    {
        rCorrecta = num1*num2;
        if(int.Parse(respuestaField.text) == rCorrecta){
            Debug.Log("noiseee");

        }else{

            Debug.Log("malooo");
        }
        
    }
}
