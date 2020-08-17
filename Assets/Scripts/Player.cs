using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed;
    public Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if( Input.GetKey(KeyCode.D) )
        {
            rb.AddForce(new Vector2(speed, 0));
        }

        if (Input.GetKey(KeyCode.A))
        {
            rb.AddForce(new Vector2(-speed, 0));
        }
    }
}
