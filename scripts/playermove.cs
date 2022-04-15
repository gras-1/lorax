using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playermove : MonoBehaviour
{
    // Start is called before the first frame update
    public float movespeed = 5f;
    public Rigidbody2D rb;
    public Vector2 movement;
    public Animator animator;

    // Update is called once per frame
    void Update()
    {
        //input
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        animator.SetFloat("horiZ", movement.x);
        animator.SetFloat("vertical", movement.y);
        animator.SetFloat("speed", movement.sqrMagnitude);



    }

    void FixedUpdate()
    {
        //movement
        rb.MovePosition(rb.position + movement * movespeed * Time.fixedDeltaTime );

    }
}
