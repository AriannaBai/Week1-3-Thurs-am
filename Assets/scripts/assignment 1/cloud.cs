using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cloud : MonoBehaviour
{
    public AnimationCurve curve; // for let the cloud to move

    public Vector2 start; 
    public Vector2 end;

    public float speed;

    // I set the speed is one and I cannot let it become 0
    public float speedMultiplier = 1f; // set the speede in 1 to make it normal and when it increase and make the speed slow down 

    [Range(0, 1)]
    public float t;

    bool back = false;


    // Start is called before the first frame update
    void Start()
    {

    }

    // I wanna update the frame once everytime 
    void Update()
    {
    // Use the float to decrase the speed of my cloud and let the cloud when it moving and come back    Apply the speed multiplier to slow down the animation
        float deltaTime = Time.deltaTime;

        if (back) t -= deltaTime;
        else t += deltaTime;

        if (t >= 1) back = true;
        if (t <= 0) back = false;

    // I use the Lerp and put it between the start and end positions and also using the curve's evaluation to let it move
        Vector2 scale = transform.localScale;
        transform.position = Vector2.Lerp(start, end, curve.Evaluate(t));
        transform.localScale = scale;
    }
}
