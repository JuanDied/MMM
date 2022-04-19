using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeFeatures : MonoBehaviour
{
     public GameObject Girl1;
    public GameObject Girl2;
    public GameObject Kid;
    public bool state = false;
    public string Player;
    // Start is called before the first frame update
    void Start()
    {
        
       
       Player = Player_selector.player;
       Girl1.SetActive(false);
       Girl2.SetActive(true);
       Debug.Log("Clickeeeeedd!2222 :  "+Player);
       if (Player == "Player A"){

          //Se pone el man
          Debug.Log("Se despliega el man");
          Kid.SetActive(true);
          Girl1.SetActive(false);
          Girl2.SetActive(false);
       }
       else{
            Kid.SetActive(false);
            Girl1.SetActive(true);
          Girl2.SetActive(true);

       }
    }

  
    public void Feature()
    {
       
       if(Player == "Player B"){
               if (state == false ){ 
            Girl1.SetActive(true);
            Girl2.SetActive(false);
            state = true;
            }
            else{
            Girl1.SetActive(false);
            Girl2.SetActive(true);
            state = false;
            
            }
      }
        
    }
}
