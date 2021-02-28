using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleManager : MonoBehaviour
{
    public bool spawning = true;
    public float spawnRateMinTime = 2.0f;
    public float spawnRateMaxTime = 3.5f;
    private float spawnRateInSeconds;
    public float obstacleSpeed = 40.0f;

    public GameObject prefab;

    void Start()
    {
        switch (InfoKeeperStatic.difficulty)
        {
            case 0:
                spawnRateMinTime = 3.0f;
                spawnRateMaxTime = 6.0f;
                obstacleSpeed = 20.0f;
                break;

            case 1:
                spawnRateMinTime = 1.7f;
                spawnRateMaxTime = 3.0f;
                obstacleSpeed = 30.0f;
                break;

            case 2:
                spawnRateMinTime = 1.0f;
                spawnRateMaxTime = 2.0f;
                obstacleSpeed = 45.0f;
                break;

            default:
                spawnRateMinTime = 1.0f;
                spawnRateMaxTime = 2.0f;
                obstacleSpeed = 45.0f;
                break;
        }

        StartCoroutine(SpawnerCoroutine());
    }

    IEnumerator SpawnerCoroutine()
    {
        while (spawning)
        {
            GameObject barrier = Instantiate(prefab);
            barrier.transform.parent = transform;

            spawnRateInSeconds = Random.Range(spawnRateMinTime, spawnRateMaxTime);

            var barrierBehaviour = barrier.GetComponent<ObstacleBehaviour>();
            barrierBehaviour.obstacleSpeed = obstacleSpeed;

            yield return new WaitForSeconds(spawnRateInSeconds);
        }
    }
}
