using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    [SerializeField]
    private GameObject target;

    private Vector3 offset;
    // Start is called before the first frame update
    void Start()
    {
        //target = gameObject.GetComponent<GameObject>();
        offset = transform.position - target.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.Lerp(transform.position, (target.transform.position + offset), Time.deltaTime);
    }
}
