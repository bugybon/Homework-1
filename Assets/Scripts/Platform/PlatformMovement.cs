using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformMovement : MonoBehaviour
{
    private float direction;

    [SerializeField]
    [Range(0,30)]
    private float speed = 10;

    private float position = 0;
    [SerializeField]
    private GameObject point1, point2;


    void Update()
    {
        if(position >= 1)
        {
            GameObject temp = point1;
            point1 = point2;
            point2 = temp;
            position = 0;
        }

        transform.position = Vector2.Lerp(point1.transform.position,point2.transform.position, position);
        position += Time.deltaTime * speed;


    }
}
