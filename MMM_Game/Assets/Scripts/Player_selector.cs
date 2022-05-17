using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class Player_selector : MonoBehaviour
{
    // Start is called before the first frame update
    // [SerializeField] private GameObject player_name;
    private GameObject player_obj;
    private Animator animator;
    [SerializeField]private TextMeshProUGUI player_name_text;
    [SerializeField]private TextMeshProUGUI Selected_player;
    public static string player;
   
    void Start()
    {
        // player_name_text = player_name.GetComponent<TextMeshProUGUI>();
        animator = GetComponent<Animator>();
        player_obj = GetComponent<GameObject>();
    }

    // // Update is called once per frame
    // void Update()
    // {
        
    // }
    public void Next_scene(){
        Debug.Log("continuamos");
        SceneManager.LoadScene("Personalization");
    }

    public void IwasClicked(){
        Debug.Log("Clickeeee2edd! :  "+player_name_text.text);
        animator.SetTrigger("saltar");
        Selected_player.text = player_name_text.text;
        player = player_name_text.text;

        // while((animator.GetCurrentAnimatorStateInfo(0).normalizedTime ) < 0.99f)
        // {
        //     Debug.Log("Jumping");
            
         

        // }
      // SceneManager.LoadScene("Personalization");  
    }

    public void Update(){
        // while((animator.GetCurrentAnimatorStateInfo(0).normalizedTime ) < 0.99f)
        // {
        //     Debug.Log("Jumping");
            
         

        // }
    }
    
}
