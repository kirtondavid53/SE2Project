using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sun : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //transform.RotateAround(Vector3.zero, Vector3.right,0.5f*Time.deltaTime);      //for something still faster than reality but more accurate
        transform.RotateAround(Vector3.zero, Vector3.right,10f*Time.deltaTime);        //for demonstration
        transform.LookAt(Vector3.zero);
        
    }
}
