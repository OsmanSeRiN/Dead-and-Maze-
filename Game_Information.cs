using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game_Stady : MonoBehaviour
{    
    public float time;
    public GameObject control_stady;
    // Start is called before the first frame update
    void Start()
    {
                    
    }

    // Update is called once per frame
    void Update()
    {   
      
        
       
    }

    void  FixedUpdate()
    {
       if (time == 0)
       {
         control_stady.SetActive(false);
       }
       else
       {
        time--;
       }
    }
}
