using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrafficMoveRight : MonoBehaviour
{
    // Start is called before the first frame update
    public float moveSpeed = 5;
    private float deadZone = 10;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += (Vector3.up * moveSpeed) * Time.deltaTime;
        if (transform.position.y > deadZone)
        {
            Debug.Log("right object destroyed");
            Destroy(gameObject);
        }
    }
}
