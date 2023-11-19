using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follower : MonoBehaviour
{

    public Transform player;
    public Vector3 offset;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.position =player.transform.position - offset;
    }
}
