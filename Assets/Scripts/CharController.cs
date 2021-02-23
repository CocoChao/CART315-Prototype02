using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Set the character movement speed

public class CharController : MonoBehaviour
{
    //[SerializedField] private Transform groundCheckTransform = null;
    private bool jumpKeyWasPressed;
    public float movementSpeed = 40f;
    //private Rigidbody rigidbodyComponent;
    //private bool isGrounded;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float hMovement = Input.GetAxis("Horizontal") * movementSpeed / 2;
        float vMovement = Input.GetAxis("Vertical") * movementSpeed;

        transform.Translate(new Vector3(hMovement, 0, vMovement) * Time.deltaTime);

        // Check if space key is pressed down
        if (Input.GetKeyDown(KeyCode.Space) == true)
        {
            // Debug.Log("Space Key Was Pressed Down");
            jumpKeyWasPressed = true;
        }
    }

    // FixedUpdate is called once every physic update
    private void FixedUpdate()
    {

        //if (Physics.OverlapSphere(groundCheckTransform.position, 0.1f).Length == 1)
        //{
        //    return;
        //}

        //if (!isGrounded)
        //{
        //    return;
        //}

        if (jumpKeyWasPressed)
        {
            // Debug.Log("Space Key Was Pressed Down");
            GetComponent<Rigidbody>().AddForce(Vector3.up * 10, ForceMode.VelocityChange);
            jumpKeyWasPressed = false;
        }
    }

    //private void OnCollisionEnter(Collision collision)
    //{
    //    isGrounded = true;
    //}

    //private void OnCollisionExit(Collision collision)
    //{
    //    isGrounded = false;
    //}

}
