using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    float velocityX = 0.0f;
    float velocityZ = 0.0f;
    float acceleration = .001f;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (velocityX < .15)
        {
            this.velocityX += this.acceleration * Input.GetAxis("Horizontal");
        }
        if (velocityZ < .15)
        {
        this.velocityZ += this.acceleration * Input.GetAxis("Vertical");
        }
        print("HORIZONTAL: " + Input.GetAxis("Horizontal"));
        print("VERTICAL: " + Input.GetAxis("Vertical"));

        if (Mathf.Abs(Input.GetAxis("Horizontal")) < .15)
        {
            this.velocityX = 0;
        }
        if (Mathf.Abs(Input.GetAxis("Vertical")) < .15)
        {
            this.velocityZ = 0;
        }
        
        Vector3 position = this.transform.position;
        position.x += this.velocityX; 
        position.z += this.velocityZ;
        this.transform.position = position;
    }
}
