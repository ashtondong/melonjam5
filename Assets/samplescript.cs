using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class samplescript : MonoBehaviour
{
    public Rigidbody2D sampleRigidBody;
    public float jumpHeight;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) == true)
        {
            sampleRigidBody.velocity = Vector2.up * jumpHeight;
        }
        
    }
} 
