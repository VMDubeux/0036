using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManagerX : MonoBehaviour
{
    public GameObject[] BallPrefabs;
    private int _ballIndex;

    private float spawnLimitXLeft = -22;
    private float spawnLimitXRight = 7;
    private float spawnPosY = 30;

    private float startDelay = 1.0f;
    private float spawnInterval = 4.0f;

    void Start()
    {
        InvokeRepeating("SpawnRandomBall", startDelay, spawnInterval);
    }

    
    void SpawnRandomBall () // Spawn random ball at random x position at top of play area
    {
        _ballIndex = Random.Range(0, 3);
        
        Vector3 spawnPos = new Vector3(Random.Range(spawnLimitXLeft, spawnLimitXRight), spawnPosY, 0); // Generate random ball index and random spawn position

        Instantiate(BallPrefabs[_ballIndex], spawnPos, BallPrefabs[_ballIndex].transform.rotation); // instantiate ball at random spawn location
    }

}
