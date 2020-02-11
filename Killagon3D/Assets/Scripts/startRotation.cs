using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class startRotation : MonoBehaviour
{
    public float s1;
    public float s2;
    public float s3;

    void Update()
    {
        transform.Rotate(s1, s2, s3);
    }
}
