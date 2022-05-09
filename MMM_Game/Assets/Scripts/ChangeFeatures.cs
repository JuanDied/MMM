using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeFeatures : MonoBehaviour
{
   
   public GameObject Girl1;
   public GameObject Girl2;
   public GameObject Kid;
   public GameObject Kid2;

   private bool state = false;
   public string Player;
    // Start is called before the first frame update
    void Start()
    {
        //kid
       
       Player = Player_selector.player;
       Girl1.SetActive(false);
       Girl2.SetActive(false); //lo cambie
       Debug.Log("Clickeeeeedd!2222 :  "+Player);
       if (Player == "jugador A"){

          //Se pone el man
          Debug.Log("Se despliega el man");
          Kid.SetActive(true);
          Kid2.SetActive(false);
          Girl1.SetActive(false);
          Girl2.SetActive(false);
       }
       else{
            Kid.SetActive(false);
            Kid2.SetActive(false);
            Girl1.SetActive(false);
            Girl2.SetActive(true);

       }
    }

  
    public void Feature()
    {
       
       if(Player == "Jugador B"){
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
       if(Player == "jugador A"){
               if (state == false ){ 
            Kid2.SetActive(true);
            Kid.SetActive(false);
            state = true;
            }
            else{
            Kid2.SetActive(false);
            Kid.SetActive(true);
            state = false;
            
            }
      }
        
    }
}
