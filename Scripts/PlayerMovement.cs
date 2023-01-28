using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 5f;
    public Rigidbody2D rigiBod;
    public Animator animate;
    Vector2 movement;

    // Update is called once per frame
    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        animate.SetFloat("Horizontal", movement.x);
        animate.SetFloat("Vertical", movement.y);
        animate.SetFloat("Speed", movement.sqrMagnitude);
    }

    void FixedUpdate()
    {
        // Good for physics to be more precise.
        rigiBod.MovePosition(rigiBod.position + movement * speed * Time.fixedDeltaTime);
    }

    void run()
    {
        if (Input.GetMouseButtonDown(0))
        {
            speed = 10f;
        }
    }
}
