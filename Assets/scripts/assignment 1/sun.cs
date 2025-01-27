using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using UnityEngine;

public class sun : MonoBehaviour
{
    [Range(0, 1)]
    public float time; // this means the value of the curve like the number which I set is from zero to one
    public AnimationCurve curve;

    public Transform start; // the sqaure shich is the start position of the object
    public Transform end; //  the sqaure shich is the end position of the object

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        transform.position = Vector2.Lerp(start.position, end.position, curve.Evaluate(time)); // let the sun move by the curve and the start is where sun start moving and the end is the position where sun stop moving

    }
}
