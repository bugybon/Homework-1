using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D rigidBody;
    private float direction;

    [SerializeField]
    [Range(1, 30)]
    private float movementSpeed = 10;

    // Start is called before the first frame update
    void Start()
    {
        rigidBody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        direction = Input.GetAxisRaw("Horizontal");
        ResolveDirection();
    }

    private void FixedUpdate()
    {
        if (direction != 0)
        {
            Vector2 target = rigidBody.velocity;
            target.x = direction * movementSpeed;
            rigidBody.velocity = target;
        }
    }

    private void ResolveDirection()
    {
        if(direction < 0)
        {
            transform.localRotation = Quaternion.Euler(0, 180, 0);
        }
        else if (direction > 0)
        {
            transform.localRotation = Quaternion.Euler(0, 0, 0);
        }
    }
}
