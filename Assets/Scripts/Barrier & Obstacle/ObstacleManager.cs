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
