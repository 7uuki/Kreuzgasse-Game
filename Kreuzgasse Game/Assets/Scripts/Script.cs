using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script : MonoBehaviour
{
    Rigidbody2D rbody;

    Vector2 movement;
    float moveLimiter = 0.7f;

    public float runSpeed = 5f;

    void Start()
    {
        rbody = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        // Gives a value between -1 and 1
        movement.x = Input.GetAxisRaw("Horizontal"); // -1 is left
        movement.y = Input.GetAxisRaw("Vertical"); // -1 is down
    }

    void FixedUpdate()
    {
        rbody.MovePosition(rbody.position + movement * runSpeed * Time.fixedDeltaTime);
       
    }
}
