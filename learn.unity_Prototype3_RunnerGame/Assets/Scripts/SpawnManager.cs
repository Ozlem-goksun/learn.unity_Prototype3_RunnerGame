using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{

    public GameObject obstaclePrefab;
    private Vector3 spawnPos = new Vector3(20, 0, 0);

    private float startDelay = 1.0f;
    private float spawnInterval = 1.0f;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnObstacles", startDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {
        if (obstaclePrefab.transform.position.x < -5)
        {
            Destroy(obstaclePrefab.gameObject);
        }
    }

    private void SpawnObstacles()
    {
        Instantiate(obstaclePrefab, spawnPos, obstaclePrefab.transform.rotation);
    }
}