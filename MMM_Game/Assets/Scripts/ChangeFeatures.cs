using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeFeatures : MonoBehaviour
{
     public GameObject pelo1;
    public GameObject pelo2;
    public bool state = false;
    // Start is called before the first frame update
    void Start()
    {

       pelo1.SetActive(false);
       pelo2.SetActive(true);
    }

    // Update is called once per frame
    public void Feature()
    {
        if (state == false){ 
       pelo1.SetActive(true);
       pelo2.SetActive(false);
       state = true;
       }
       else{
           pelo1.SetActive(false);
       pelo2.SetActive(true);
       state = false;
       }
    }
}
