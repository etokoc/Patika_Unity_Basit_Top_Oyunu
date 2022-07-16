using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallBehaviour : MonoBehaviour
{
    // Start is called before the first frame update
    private new Rigidbody rigidbody;
    void Start()
    {
        rigidbody = gameObject.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    private Vector3 force;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            force = new Vector3(0, 0, 1);
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            force = new Vector3(-1, 0, 0);
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            force = new Vector3(1, 0, 0);
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            force = new Vector3(0, 0, -1);
        }
        rigidbody.AddForce(force);

    }
}
