using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrafficSpawnerLeft : MonoBehaviour
{
    public GameObject trafficLeft;
    public float spawnRate = 0.2f;
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
        Instantiate(trafficLeft, new Vector3(-1,7,0), transform.rotation);
    }
}
