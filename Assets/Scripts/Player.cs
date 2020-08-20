using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public float speed;
    public float jumpForce;
    public Rigidbody2D rb;
    public SpriteRenderer spriteRenderer;
    public Animator anim;

    private bool canJump = true;

    private int score = 0;
    public Text scoreText;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Coin")
        {
            score++;
            Destroy(collision.gameObject);
            scoreText.text = score.ToString();
        }

        if(collision.tag == "Enemy")
        {
            SceneManager.LoadScene("Przegrana");
        }

        if (collision.tag == "Win")
        {
            SceneManager.LoadScene("Wygrana");
        }
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Physics2D.Raycast(transform.position, Vector3.down, 0.6f))
        {
            canJump = true;
        }

        if( Input.GetKeyDown(KeyCode.Space) && canJump == true )
        {
            rb.AddForce(new Vector2(0, jumpForce));
            anim.SetTrigger("jump");
            canJump = false;
        }


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
