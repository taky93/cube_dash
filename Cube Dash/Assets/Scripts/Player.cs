using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Rigidbody rb;
    public float speed;
    public bool isJumping = false;
    // Start is called before the first frame update


    // Update is called once per frame
    void FixedUpdate()
    {

        rb.AddForce(0, 0, speed * Time.deltaTime);

        if (Input.GetKey(KeyCode.RightArrow))
        {
            rb.AddForce(speed  * Time.deltaTime, 0, 0);
        }
       if (Input.GetKey(KeyCode.LeftArrow))
        {
            rb.AddForce(-speed * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey(KeyCode.Space) && !isJumping)
        {
            isJumping = true;
            rb.AddForce(0,speed * Time.deltaTime,0);
            isJumping = false;
        }
    }
}
