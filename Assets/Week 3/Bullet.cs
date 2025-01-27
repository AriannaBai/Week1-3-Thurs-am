using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 5;
    bool hasBeenFired = false;

    void Update()
    {
        PointAtMouse();
        if (hasBeenFired == true)
        {

        }
    }

    void PointAtMouse()
    {
        Vector3 mouse = Camera.main.ScreenToViewportPoint(Input.mousePosition);
        mouse.x = 0;
        Vector2 direction = mouse - transform.position;

        transform.up = direction;
    }

    void Movement()
    {
        //transform.position += Vector3.up * speed * Time.deltaTime;
        transform.Translate(transform.up * speed * speed * Time.deltaTime);
    }
}