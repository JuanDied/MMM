using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Papa2 : MonoBehaviour
{
    public static bool dad2;
    void Start()
    {
        
    }

    // Update is called once per frame
    public void Resultados()
    {
        dad2=true;
        SceneManager.LoadScene("Resultados");
        
    }
}
