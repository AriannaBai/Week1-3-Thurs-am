using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Parent : MonoBehaviour
{
    public float rot = 50;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, 0, rot * Time.deltaTime);

        if (Input.GetMouseButtonDown(0))
        {
            transform.position = Vector3.zero;
            transform.eulerAngles = Vector3.zero;
            transform.rotation = Quaternion.identity;
        }
        if(Input.GetKeyDown(KeyCode.Space))
        {
            transform.localPosition = Vector3.zero;
            transform.localEulerAngles = Vector3.zero;
            transform.localRotation = Quaternion.identity;
        }
    }
}
