using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class New2D : MonoBehaviour
{
    
    public Animator animator;
    public float moveSpeed = 5f;
    public bool isGrounded = false;
    

    
    void Update()
    {
        
        animator.SetFloat("Horizontal", Input.GetAxis("Horizontal"));
        
        Jump();
        
        Vector3 movement = new Vector3(Input.GetAxis("Horizontal"), 0f, 0f);
        
        transform.position += movement * Time.deltaTime * moveSpeed;
        
    }
    
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Ground")
             isGrounded = true;
    }
   
    private void OnCollisionExit2D(Collision2D other)
    {
        if (other.gameObject.tag == "Ground")
             isGrounded = false;
    }

    void Jump()
    {
        if (Input.GetButtonDown("Jump") && isGrounded == true )
        {
            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0f, 650f), ForceMode2D.Impulse);
        }
    }
    
    
    
}
