using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Biblioteca : MonoBehaviour
{
    public GameObject dialogoBiblio1;

    public GameObject dialogoBiblio2;

    public GameObject dialogoBiblio3;

    public GameObject librosBiblioteca;

    public GameObject Recepcion;
    public GameObject respuestaBiblio;

    private int biblio = 0;
    // Start is called before the first frame update
    void Start()
    {
        Recepcion.SetActive(false);
        dialogoBiblio1.SetActive(true);
        dialogoBiblio2.SetActive(false);
        dialogoBiblio3.SetActive(false);
        respuestaBiblio.SetActive(false);
    }

   public void Biblio()
    {  
        if(biblio==0){
            Recepcion.SetActive(true);
            librosBiblioteca.SetActive(false);
            biblio++;
        }
        else if(biblio==1){
        dialogoBiblio1.SetActive(false);
        dialogoBiblio2.SetActive(true);
        respuestaBiblio.SetActive(true);
        biblio++;
        }
        else if(biblio==2){
        dialogoBiblio2.SetActive(false);
        dialogoBiblio3.SetActive(true);
        respuestaBiblio.SetActive(true);

        biblio++;
        }
        else{
            SceneManager.LoadScene("Resultados");
        }
    }
  
}
