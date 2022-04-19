using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class Player : MonoBehaviour
{
    Rigidbody rb;
    public Text length;
    public AudioSource click;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    void Update()
    {
        rb.velocity = new Vector3(1, rb.velocity.y, rb.velocity.z);
        length.text = (Mathf.RoundToInt(transform.position.x)).ToString();
    }
    private void OnCollisionEnter(Collision collision)
    {
        click.Play();
    }
}