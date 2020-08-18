using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed;
    public Rigidbody2D rb;
    public SpriteRenderer spriteRenderer;
    public Animator anim;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if( Input.GetKey(KeyCode.D) )
        {
            rb.AddForce(new Vector2(speed, 0));
            spriteRenderer.flipX = false;
        }

        if (Input.GetKey(KeyCode.A))
        {
            rb.AddForce(new Vector2(-speed, 0));
            spriteRenderer.flipX = true;
        }

        // if ( warunek1 || warunek2) ----> któryś z warunków musi być prawdziwy
        

        /* 
           if (warunek )
           {
            tu wejdziemy, jeśli warunek jest prawdziwy
           }
           else
           {
           tu wejdziemy w przeciwym wypadku
           }
        */
        

        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.D))
        {
            anim.SetBool("move", true);
        }
        else
        {
            anim.SetBool("move", false);
        }
    }
}
