using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_MOve : MonoBehaviour
{
    public Vector2 pos1,pos2;
    public float enemyspeed=1f;
    private float oldPosition;

   
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Enemy_Move();
    }

    public void Enemy_Move() 
    {
        transform.position = Vector3.Lerp(pos1,pos2,Mathf.PingPong(Time.time*enemyspeed,1f));

        if (transform.position.x>oldPosition)
        {
            transform.localRotation=Quaternion.Euler(0,180,0);
        }
        else if(transform.position.x<oldPosition)
        {
            transform.localRotation = Quaternion.Euler(0,0,0);
        }
                       
    }
}