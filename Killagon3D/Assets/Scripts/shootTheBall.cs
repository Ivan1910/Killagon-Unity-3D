using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shootTheBall : MonoBehaviour
{
    private Rigidbody rb;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            rb.AddForce(0,0,1000);
        }
    }
}
