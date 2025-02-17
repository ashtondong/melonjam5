using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrafficSpawnerMiddle : MonoBehaviour
{
    public GameObject trafficMiddle;
    public float spawnRate = 0.8f;
    private float timer = 0;

    // Start is called before the first frame update
    void Start()
    {
        spawner();
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < spawnRate)
        {
            timer += Time.deltaTime;
        }
        else
        {
            spawner();
            timer = 0;
        }

    }
    void spawner()
    {
        Instantiate(trafficMiddle, new Vector3(2, -5, 0), transform.rotation);
    }
}
