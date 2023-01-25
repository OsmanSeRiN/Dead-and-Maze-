using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character_Move : MonoBehaviour
{ 
    Rigidbody2D PlayerX;
    public float movespeed;

    // Start is called before the first frame update
    void Start()
    {
       PlayerX = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
       HorizontalMove();
    }

    void HorizontalMove()
    {
         PlayerX.velocity = new Vector2(Input.GetAxis("Horizontal") * movespeed ,Input.GetAxis("Vertical")*movespeed );
    }

    
}