using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrafficMoveRight : MonoBehaviour
{
    // Start is called before the first frame update
    public float moveSpeed = 5;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += (Vector3.up * moveSpeed) * Time.deltaTime;
    }
}
