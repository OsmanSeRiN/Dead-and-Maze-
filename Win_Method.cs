using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Win_Code : MonoBehaviour
{
    public GameObject Win_Method;
    public GameObject Voice_off;
    public int Level;
    
    void Start()
    {
        if(PlayerPrefs.HasKey("Level"))
        {
          Level=PlayerPrefs.GetInt("Level");
        }
        else 
        {
          PlayerPrefs.SetInt("Level",0);
        }
    }

    // Update is called once per frame
    void Update()
    {
          
    }

    void OnTriggerEnter2D(Collider2D other)
    {
         if (other.tag=="Chest")
         {
            Winner();
         }
    }
      public void Winner() 
    {
         Time.timeScale=0;
         Win_Method.SetActive(true);
         Voice_off.SetActive(false);
         Level+=1;
         PlayerPrefs.SetInt("Level",Level);
         
         
         
    }

}
