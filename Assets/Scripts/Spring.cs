using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spring : MonoBehaviour
{
    private Rigidbody2D target;

    [SerializeField]
    private float jumpVelocity=20;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (!collision.gameObject.CompareTag("Legs"))
        {
            return;
        }

        target = collision.gameObject.transform.parent.GetComponent<Rigidbody2D>();
        Vector3 vel = target.velocity;
        vel.y = jumpVelocity;
        target.velocity = vel;
    }
}
