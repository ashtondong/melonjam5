using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{

    public GameObject Obstacle;
    public float SpawnRate = 2;
    private float timer = 0;
    public float bottomheightOffset = 8;
    public float topheightOffset = 13;

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

        float lowestPoint = transform.position.y - bottomheightOffset;
        float highestPoint = transform.position.y + topheightOffset;

        Instantiate(Obstacle, new Vector3(transform.position.x, Random.Range(lowestPoint, highestPoint), 0), transform.rotation);
        timer = 0;



    }
}
