using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed;
    public int health;
    public int money;
    
    public GameObject hand;
    private GameObject[] Inventory;


    private Rigidbody2D rb;
    private Vector2 moveInput;
    private Vector2 moveVelocity;
    private Vector2 mousePosition;

    private Animator anim;

     private bool facingRight = true;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        
    }
    // Update is called once per frame
    void Update()
    {
        UpdateUI();

        moveInput = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
        moveVelocity = moveInput.normalized * speed;

        if ((moveInput.x == 0) && (moveInput.y == 0))
        {
            anim.SetBool("IsRunning",false);
        }
        else
        {
            anim.SetBool("IsRunning", true);
        }


        if (!facingRight  && moveInput.x < 0)
        {
            Flip();
        }
        
        else if (facingRight && moveInput.x > 0)
        {
            Flip(); 
        }

        Vector2 PosPlayer = gameObject.transform.position;
        Vector2 PosMouse  = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        if(PosMouse.x < PosPlayer.x && !facingRight){
            Flip();
        }
        if(PosMouse.x > PosPlayer.x && facingRight){
            Flip();
        }
        //mousePosition = Input.mousePosition;
        //transform.LookAt(mousePosition);
    }

    private void UpdateUI() {
        GameObject.FindWithTag("Money").GetComponent<Text>().text = money.ToString();
        GameObject.FindWithTag("Health").GetComponent<Text>().text = health.ToString();
    }

    private void FixedUpdate()
    {
        rb.MovePosition(rb.position + moveVelocity * Time.fixedDeltaTime);
    }

    private void Flip()
        {
            facingRight = !facingRight;
            Vector3 Scaler = transform.localScale;
            Scaler.x *= -1;
            transform.localScale = Scaler;
            
        }
    
}
