using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float horizontal;
    public float speed;
    public Rigidbody2D rb;
    public Animator anim;
    public bool isWalking;

    //ground check variables
    public Transform groundCheck;
    public LayerMask groundLayer;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        CheckForWalking();
        anim.SetBool("isWalking", isWalking);

        if (rb.velocity.y < 0 && !isGrounded())
        {
            anim.Play("JeffFalling");
        }
        else
        {
            anim.SetTrigger("backToGround");
        }

        horizontal = Input.GetAxisRaw("Horizontal");
        rb.velocity = new Vector2(horizontal * speed, rb.velocity.y);
    }

    public void CheckForWalking()
    {
        if (horizontal != 0 && isGrounded())
        {
            isWalking = true;
        }
        else
        {
            isWalking = false;
        }
    }

    public bool isGrounded()
    {
        return Physics2D.OverlapCircle(groundCheck.position, 0.2f, groundLayer);
    }
}
