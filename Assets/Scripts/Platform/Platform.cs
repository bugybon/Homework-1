using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform : MonoBehaviour
{
    [SerializeField]
    private Collider2D hitbox;
    [SerializeField]
    private bool isMoving = false;
    [SerializeField]
    private bool isFalling = false;
    [SerializeField]
    private float time = 1f;
    private void Start()
    {
        hitbox = GetComponent<Collider2D>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Legs"))
        {
            hitbox.enabled = true;
            if (isMoving)
            {
                collision.gameObject.transform.parent.SetParent(this.transform);
            }
            if (isFalling)
            {
                hitbox.enabled = false;
                Destroy(this.transform.gameObject, time);
            }
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            hitbox.enabled = false;
            if (isMoving)
            {
                collision.gameObject.transform.parent = null;
            }
        }
    }
}
