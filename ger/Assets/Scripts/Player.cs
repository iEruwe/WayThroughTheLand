using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float playerSpeed;
    public float playerJumpForce;

    private Rigidbody2D player;
    private Animator animator;
    private GroundSensor groundSensor;
    private bool isGrounded = false;

    void Start()
    {
        animator = GetComponent<Animator>();
        player = GetComponent<Rigidbody2D>();
        groundSensor = transform.Find("GroundSensor").GetComponent<GroundSensor>();
        Time.timeScale = 1;
    }
    void Update()
    {
        if (!isGrounded && groundSensor.State())
        {
            isGrounded = true;
            animator.SetBool("Grounded", isGrounded);
        }

        if (isGrounded && !groundSensor.State())
        {
            isGrounded = false;
            animator.SetBool("Grounded", isGrounded);
        }

        float inputX = Input.GetAxis("Horizontal");

        if (inputX > 0)
        {
            transform.localScale = new Vector3(-1.0f, 1.0f, 1.0f);
        }
        else if (inputX < 0)
        {
            transform.localScale = new Vector3(1.0f, 1.0f, 1.0f);
        }

        player.velocity = new Vector2(inputX * playerSpeed, player.velocity.y);

        if (Input.GetKeyDown("space") && isGrounded)
        {
            animator.SetTrigger("Jump");
            isGrounded = false;
            animator.SetBool("Grounded", isGrounded);
            player.velocity = new Vector2(player.velocity.x, playerJumpForce);
            groundSensor.Disable(0.2f);
        }

        else if (Mathf.Abs(inputX) > Mathf.Epsilon)
        {
            animator.SetInteger("AnimState", 2);
        }

        else
        {
            animator.SetInteger("AnimState", 0);
        }
    }
}