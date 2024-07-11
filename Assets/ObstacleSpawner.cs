using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{

    public GameObject Obstacle;
    public float SpawnRate = 2;
    private float timer = 0;

    // Start is called before the first frame update
    void Start()
    {
        spawnObject();
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < SpawnRate)
        {
            timer += Time.deltaTime;
        }

        else
        {
            spawnObject();
        }

    }

    void spawnObject()
    {

        Instantiate(Obstacle, transform.position, transform.rotation);
        timer = 0;

    }
}
