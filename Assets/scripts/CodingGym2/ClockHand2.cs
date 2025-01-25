using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClockHand2 : MonoBehaviour
{
    public float R = 1f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 CL2 = transform.eulerAngles;
        CL2.z += R*12;
        transform.eulerAngles = CL2;
    }
}
