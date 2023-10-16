using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5.0f;  // Adjust this to set the movement speed.
    public float jumpForce = 5.0f;  // Adjust this for the jump height.

    public bool canMove = true;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        while (canMove) {
            float horizontalInput = Input.GetAxis("Horizontal");
            Vector2 movement = new Vector2(horizontalInput * moveSpeed, GetComponent<Rigidbody2D>().velocity.y);
            GetComponent<Rigidbody2D>().velocity = movement;

            if (Input.GetButtonDown("Jump")) {
                GetComponent<Rigidbody2D>().velocity = new Vector2(GetComponent<Rigidbody2D>().velocity.x, jumpForce);
            }
        }
        
    }
}
