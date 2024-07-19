using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrafficSpawnerRight : MonoBehaviour
{
    public GameObject trafficRight;
    public float spawnRate = 1;
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
        Instantiate(trafficRight, new Vector3(5, -5, 0), transform.rotation);
    }
}
