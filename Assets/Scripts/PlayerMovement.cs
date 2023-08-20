using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{   //speed for different movements (up/sideways + gravity)
    public float LandSpeed = 5f;
    public float upSpeed = 4f;
    public float rotationSpeed = 2f;
    public float gravity = 10;

    //different inputs
    public float horizontalInput;
    public float verticalInput;
    public float jumpInput;
    public float rotationInput;
   
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Input for forwards/backwards
        verticalInput = Input.GetAxis("Vertical");
        transform.Translate(Vector3.right * Time.deltaTime * LandSpeed * verticalInput);

        // Input for left/right
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.back * Time.deltaTime * LandSpeed * horizontalInput);

        //Input for Jump
        jumpInput = Input.GetAxis("Jump");
        transform.Translate(Vector3.up * Time.deltaTime * jumpInput * gravity);

        //spain without the a 
        rotationInput = Input.GetAxis("Rotation");
        transform.Rotate(Vector3.up * Time.deltaTime * rotationSpeed * rotationInput);

    }
}
