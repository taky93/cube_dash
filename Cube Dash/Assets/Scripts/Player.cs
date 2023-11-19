using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Rigidbody rb;
    public Vector3 move;
    public float speed = 100f;
    // Start is called before the first frame update
    void Start()
    {
        move = new Vector3(0, 0, 10);

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rb.AddForce(move * speed * Time.deltaTime,ForceMode.Acceleration);
    }
}
