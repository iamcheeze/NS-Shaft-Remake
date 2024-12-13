using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scripting : MonoBehaviour
{
    public Rigidbody2D rb;
    public float horizontal;
    public float speed = 8f;

    void FixedUpdate()
    {
        rb.velocity = new Vector2(horizontal * speed, rb.velocity.y);
    }
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontal = Input.GetAxisRaw("Horizontal");
    }
}
