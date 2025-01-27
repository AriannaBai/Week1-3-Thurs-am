using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;
using static UnityEngine.RuleTile.TilingRuleOutput;

public class AnimationDemo : MonoBehaviour
{
    public AnimationCurve curve;
    [Range(0, 1)]
    public float t;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        t += Time.deltaTime;

        if (t>1)
{
            t = 0;
        }
        transform.localScale = Vector2.one * curve.Evaluate(t);

    }
}