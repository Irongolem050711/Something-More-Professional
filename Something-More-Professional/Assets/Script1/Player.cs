using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float jumpSpeed = 100.0f;
    private bool onGround = false;

    public float speed = 5f;

    // Jump

    // Start is called before the first frame update
    void Start()
    {
        
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

    }
}
