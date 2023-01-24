using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementScript : MonoBehaviour
{
    public float MovementSpeed;
    public float RotationSpeed;
    public float JumpHeight;
    public bool IsForward = false;
    
    public Rigidbody2D rb;
  
    private float move;
    public bool isJump;
    

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    // Update is called once per frame
    void Jump()

    {
       // if (Time.time - lastJump < JumpCoolDown)
       // {
      //      return;
       // }
        //lastJump = Time.time;
        transform.position += transform.up * JumpHeight * Time.deltaTime;
    }
    void MoveForward()
    {
        //Debug.Log("Triggered movement");
        if (Time.timeScale >= 1f)
        {
            move = Input.GetAxis("Horizontal");
            rb.velocity = new Vector2(MovementSpeed * move, rb.velocity.y);
            IsForward = true;
        }
        
    }

    void Update()
    {

        MoveForward();
        float rotation = 0f; 

        if (Input.GetKey(KeyCode.A) && Time.timeScale >= 1f)
        {
            rotation = RotationSpeed;
        }
        else if (Input.GetKey(KeyCode.D) && Time.timeScale >= 1f)
        {
            rotation = -RotationSpeed;
        }
        float rotationAmount = rotation * Time.deltaTime;
        transform.Rotate(0f, 0f, rotationAmount);

        if (IsForward == true)
        {
            Debug.Log("Smoke");
        }
        if (Input.GetButtonDown("Jump") && isJump == false && Time.timeScale >= 1f)
        {
            Debug.Log("Jumped");
            rb.AddForce(new Vector2(rb.velocity.x, JumpHeight));
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Floor"))
        {
            isJump = false;
        }
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Floor"))
        {
            isJump = true;
        }
    }
    
}
