using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    Rigidbody rb;
    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    void Update()
    {
        rb.velocity = new Vector3(1, rb.velocity.y, rb.velocity.z);
    }
}