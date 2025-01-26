using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteMoving : MonoBehaviour
{
    float Moving = 3.0f;
    bool canMove = true;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 pos = transform.position;
        Vector2 screenPos = Camera.main.WorldToScreenPoint(pos);

        if (canMove)
        {
            pos.x += Input.GetAxisRaw("Horizontal") * Moving * Time.deltaTime;
            pos.y += Input.GetAxisRaw("Vertical") * Moving * Time.deltaTime;
        }

        if(screenPos.x <= 0 || screenPos.x >= Screen.width)
        {
            canMove = false;
        }
        if (screenPos.y <= 0 || screenPos.y >= Screen.height)
        {
            canMove = false;
        }

        transform.position = pos;
    }
}
