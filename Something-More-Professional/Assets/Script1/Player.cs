using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed = 5f;

    // Jumping Variables
    public float jumpForce = 3f;
    private Rigidbody rb;

    // Limiting height in jump
    private float maxHeight = 3f;

    // Start is called before the first frame update
    void Start()
    {
        // Jumping
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {

        // Move to the left
        if(Input.GetKey(KeyCode.A)) {
            transform.position -= new Vector3(speed * Time.deltaTime, 0f, 0f);
        }

        // Move Right
        if(Input.GetKey(KeyCode.D)) {
            transform.position += new Vector3(speed * Time.deltaTime, 0f, 0f);
        }

        // Jump
        if(Input.GetKey(KeyCode.W)) {

            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            
            if(transform.position.y > maxHeight) {
                rb.velocity = new Vector3(rb.velocity.x, 0f);
                transform.position = new Vector3(transform.position.x, maxHeight);
            }

        }

    }
}
