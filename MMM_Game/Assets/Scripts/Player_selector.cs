using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Player_selector : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private GameObject player_name;
    private TextMeshProUGUI player_name_text;
    [SerializeField]private TextMeshProUGUI Selected_player;
    

    void Start()
    {
        player_name_text = player_name.GetComponent<TextMeshProUGUI>();
    }

    // // Update is called once per frame
    // void Update()
    // {
        
    // }
    public void IwasClicked(){
        Debug.Log("Clickeeeeedd! :  "+player_name_text.text);
        Selected_player.text = player_name_text.text;
    }
}
