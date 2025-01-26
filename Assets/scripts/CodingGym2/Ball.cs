using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public float ball = 20.0f;
    Vector2 direction;

    // Start is called before the first frame update
    void Start()
    {
        direction = new Vector2(Random.Range(-1f, 1f), Random.Range(-1f, 1f));
    }

    // Update is called once per frame
    void Update()
    {

        Vector2 b = (Vector2)transform.position + direction * ball * Time.deltaTime;

        Vector2 screenPos = Camera.main.WorldToScreenPoint(b);

        if (screenPos.x < 0 || screenPos.x > Screen.width)
        {
            direction.x *= -1;
        }

        if (screenPos.y < 0 || screenPos.y > Screen.height)
        {
            direction.y *= -1;
        }

        transform.position = b;

        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.localScale += Vector3.one * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.localScale -= Vector3.one * Time.deltaTime;
        }
    }
}
