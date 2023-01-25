using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Sytem : MonoBehaviour
{
    public float Health;
    public float Damage;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

   void OnTriggerEnter2D(Collider2D other)
    {
        other.GetComponent<PlayerHealth>().getDamage(Damage);
    }
}