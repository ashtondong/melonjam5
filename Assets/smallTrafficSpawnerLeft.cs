using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class smallTrafficSpawnerLeft : MonoBehaviour
{
    public GameObject smallTraffic;
    public float spawnRate = 10;
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
        Instantiate(smallTraffic, new Vector3(-4, 6, 0), transform.rotation);
    }
}

