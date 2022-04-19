using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    Rigidbody rb;
    public Text length;
    public Text EndLength;
    public AudioSource click;
    public bool canWalk = true;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    void Update()
    {
        if (canWalk)
        {
            rb.velocity = new Vector3(1, rb.velocity.y, rb.velocity.z);
        }
        length.text = "Length: "+(Mathf.RoundToInt(transform.position.x)).ToString();
        EndLength.text = "Game Over!\n\nYou Walked " + (Mathf.RoundToInt(transform.position.x)).ToString() + " Meters\nTry Harder Next Time?";
    }
    private void OnCollisionEnter(Collision collision)
    {
        click.Play();
    }

    public void RestartGame()
    {
        rb.velocity = Vector3.zero;
        SceneManager.LoadScene(0);
    }
}