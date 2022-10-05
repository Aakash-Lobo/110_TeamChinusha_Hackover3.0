using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slide : MonoBehaviour
{
    /*Rigidbody rb;
    //CapsuleCollider collider;

    float originalHeight;
    public float reducedHeight;

    public float slideSpeed = 4f;

    public bool isSliding;

    void Start()
    {
        collider = GetComponent<CapsuleCollider>();
        rb = GetComponent<Rigidbody>();
        originalHeight = GetComponent<Collider>().height;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftControl) && Input.GetKey(KeyCode.W))
        {
            Sliding();
        }
        else if (Input.GetKeyUp(KeyCode.LeftControl))
        {
            GoUp();
        }
    }

    private void Sliding()
    {
        GetComponent<Collider>().height = reducedHeight;
        rb.AddForce(transform.forward * slideSpeed, ForceMode.VelocityChange);
    }

    private void GoUp()
    {
        GetComponent<Collider>().height = originalHeight;
    }*/
}
