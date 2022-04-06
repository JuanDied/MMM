using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class RedirMapa : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
   public void Tienda()
    {
        SceneManager.LoadScene("Tienda");
    }

    public void Deporte()
    {
        SceneManager.LoadScene("Deporte");
    }

    public void Biblioteca()
    {
        SceneManager.LoadScene("Biblioteca");
    }
}
