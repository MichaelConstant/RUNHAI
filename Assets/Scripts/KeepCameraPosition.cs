using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeepCameraPosition : MonoBehaviour
{
    public GameObject player;
    private void Update()
    {
        transform.position = new Vector3(player.transform.position.x + 6f, transform.position.y, transform.position.z);
    }
}
