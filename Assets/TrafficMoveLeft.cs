using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrafficMoveLeft : MonoBehaviour
{
    public float moveSpeed = 5;
    private float deadZone = -10;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += (Vector3.down * moveSpeed) * Time.deltaTime;
        if (transform.position.y < deadZone)
        {
            Debug.Log("left object destroyed");
            Destroy(gameObject);
        }
    }
}
