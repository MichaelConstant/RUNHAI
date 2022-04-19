using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dragable : MonoBehaviour
{
    bool canDrag = true;
    bool draged = false;

    float timer = 0;
    public float lifeSpan;

    private void Update()
    {
        Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mousePosition.z = 0;
        float distance = ((Vector2)transform.position - (Vector2)mousePosition).magnitude;
        if (Input.GetMouseButton(0) && distance < 1f && canDrag)
        {
            transform.position = mousePosition;
            transform.rotation = new Quaternion(0, 0, 0, 0);
            GetComponent<Rigidbody>().velocity = new Vector3 (0,0,0);
            GetComponent<Rigidbody>().angularVelocity = new Vector3(0, 0, 0);
            draged = true;
        }
        if (draged && Input.GetMouseButtonUp(0))
        {
            canDrag = false;
        }
        if (!canDrag)
        {
            timer += Time.deltaTime;
        }
        if (timer >= lifeSpan)
        {
            Destroy(gameObject);
        }
    }
}