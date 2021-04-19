using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RuchPostaci : MonoBehaviour
{
    public float movementSpeed;
    public Rigidbody2D rb;

    public Animator animator;

    public float jumpforce = 20f;
    float mx;
    float mx2;

    private void Update()
    {
        mx = Input.GetAxisRaw("Horizontal");
        mx2 = Mathf.Abs(mx);
        animator.SetFloat("Speed", mx2);

        if (mx>0)
        {
            transform.localScale = new Vector3(-3f, 4f, 1f);
        }
        else if (mx<0)
        {
            transform.localScale = new Vector3(3f, 4f, 1f);
        }

        if (Input.GetButtonDown("Jump"))
        {
            Jump();
        }

    }

    private void FixedUpdate()
    {
        Vector2 movement = new Vector2(mx * movementSpeed, rb.velocity.y);
        rb.velocity = movement;
       

    }
    void Jump()
    {
        Vector2 movement = new Vector2(rb.velocity.x, jumpforce);
        rb.velocity = movement;
    }
}