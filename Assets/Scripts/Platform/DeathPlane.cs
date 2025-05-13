using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathPlane : MonoBehaviour
{
    [SerializeField]
    private GameObject respawnPoint;

    void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Col");
        if (collision.gameObject.CompareTag("Player"))
        {
            collision.gameObject.transform.position = respawnPoint.transform.position;
        }
    }
}
