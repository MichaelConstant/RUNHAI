using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    void Update()
    {
        GetComponent<Rigidbody>().velocity = Vector3.right;
    }
}