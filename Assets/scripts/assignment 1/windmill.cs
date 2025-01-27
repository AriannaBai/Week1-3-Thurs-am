using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class windmill : MonoBehaviour
{
    public float Fan = 1f;

    // Start is called before the first frame update
    void Start()
    {
     
     
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 fan = transform.eulerAngles; // to make the fan moving and changing the rotation 
        fan.z += Fan;
        transform.eulerAngles = fan;
    }
}
