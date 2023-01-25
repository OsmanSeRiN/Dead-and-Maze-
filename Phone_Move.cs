using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Window_Move : MonoBehaviour
{
    public float speedx;
    public float speedy;
    Rigidbody2D PlayerXb;
    public float HorizontalX;
    public float verticalx;
    public int yonx;
    public int yony;
    public int yonz=45;
    int sayac=0;
    
    void Start()
    {
        PlayerXb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Horizontall();
        
    }
  
    public void Horizontall()
    {
        //HorizontalX = Input.GetAxis("Horizontal");
        PlayerXb.velocity =new Vector2(HorizontalX*speedx,verticalx*speedy);
    }

    public void left()
    {
       HorizontalX = -1;
       left_turn();
    }
    public void right()
    {
       HorizontalX = 1;
       right_turn();
    }
    public void stopp()
    {
       HorizontalX = 0;
       verticalx = 0;
       if (sayac % 2==0)
       {
        left_turn();
        sayac++;
       }
       else
       {
        right_turn();
        sayac++;
       }
       
       
    }
    public void up() 
    {
     verticalx = 1;  
     left_turn();
    }
    public void down() 
    {
      verticalx = -1;  
        right_turn();  
    }

    void left_turn()
    {
     transform.Rotate(yonx,yony,yonz);
    }
    void right_turn()
    {
       transform.Rotate(yonx,yony,-45);
    }
    
}
