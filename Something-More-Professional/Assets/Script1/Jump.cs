using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{
    public float jumpSpeed = 100.0f;
    private bool onGround = false;
        Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb=GetComponent<Rigidbody>();
    }

    float movementSpeed;

    // Update is called once per frame
    void Update()
    {
        float amountToMove = movementSpeed * Time.deltaTime;
        Vector3 movement = (Input.GetAxis("Horizontal") * -Vector3.left * amountToMove) + (Input.GetAxis("Vertical") * Vector3.forward * amountToMove);
        rb.AddForce(movement, ForceMode.Force);
   
        if (Input.GetKeyDown("space"))
        {
            rb.AddForce(Vector3.up * jumpSpeed);
        }
    }

    void OnCollisionStay ()
    {
        onGround = true;
    }

}
