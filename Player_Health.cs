using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    public float health;
    public bool dead=false;
    public GameObject Win_effect;
    public Slider slider;

    void Start()
    {
         slider.maxValue=health;
    }

    // Update is called once per frame
    void Update()
    {      
        slider.value = health;
    }

   public void getDamage(float damage)
    {
        if(health-damage>=0)
        {
            health-=damage;
        }
        else
        {
           health=0;
        }
        Idead();
        slider.value=health;
    }

  
   public GameObject character;
   void Idead()
   {
    if(health==0)
    {
        dead=true;
        fail_menu();
    }
    if (dead==true)
    {   
      Destroy(character,0);
    }
   }

   public GameObject FailMenu,Voice;

   public void fail_menu() 
   {
     FailMenu.SetActive(true);
     Time.timeScale=0;
     Voice.SetActive(false);
     
   }
}
