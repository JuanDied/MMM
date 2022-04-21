using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEditor;
using UnityEngine.SceneManagement;
public class ChangeScene2 : MonoBehaviour
{
    public static int index = 0;


   
    public void ChangeScene()
    {
        if(index == 0){
       
        SceneManager.LoadScene("Selection_scene");
        index++;
        }
        else if(index == 1){
        SceneManager.LoadScene("Personalization");
        index++;
        }
        else if(index == 2){
            SceneManager.LoadScene("GameResume");
            index++;
        }
    }
}
