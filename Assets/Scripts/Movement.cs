using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        ProcessThrust();
        ProcessRotation();

    }

    void ProcessThrust()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            Debug.Log("Pressed SPACE ");
        }
        
    }

    void ProcessRotation()
    {
        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(0,45,0);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(0,-45,0);
        }
    }
}
