using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class BarrierManager : Singleton<BarrierManager>
{
    public bool spawning = true;
    public float spawnRateInSeconds = 0.7f;
    public float barrierSpeed = 40.0f;

    public GameObject prefab;

    private int lastColor;
    private int currentColor;
    
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

            currentColor = Random.Range(0, (int)CurrentColor.COUNT);
            while (currentColor == lastColor)
                currentColor = Random.Range(0, (int)CurrentColor.COUNT);

            var barrierBehaviour = barrier.GetComponent<BarrierBehaviour>();
            barrierBehaviour.SetColor((CurrentColor)currentColor);
            barrierBehaviour.barrierSpeed = barrierSpeed;

            lastColor = currentColor;

            yield return new WaitForSeconds(spawnRateInSeconds);
        }
    }
}
