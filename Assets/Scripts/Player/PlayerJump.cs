using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerJump : MonoBehaviour
{

    private Rigidbody2D rigidBody;

    private bool isJumping = false;

    [SerializeField]
    [Range(1, 30)]
    private float jumpForce = 10;

    // Start is called before the first frame update
    void Start()
    {
        rigidBody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            isJumping = isGrounded();
        }
    }

    private void FixedUpdate()
    {
        if (isJumping && isGrounded())
        {
            Vector2 jumpVelocity = rigidBody.velocity;
            jumpVelocity.y = jumpForce;
            rigidBody.velocity = jumpVelocity;

            isJumping = false;
        }
    }

    private bool isGrounded()
    {
        Vector3 boxOrigin = transform.position;
        boxOrigin.y -= 1;
        Collider2D[] arr = Physics2D.OverlapBoxAll(boxOrigin, new Vector2(1,1) , 0f);

        foreach(Collider2D c in arr)
        {
            if(c.gameObject.layer == 8)
            {
                return true;
            }
        }
        return false;
    }
}
