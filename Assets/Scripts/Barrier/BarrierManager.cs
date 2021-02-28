using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarrierManager : Singleton<BarrierManager>
{
    [SerializeField] public Material[] barrierMaterials = null;

    public bool spawning = true;
    public GameObject prefab;

    private int lastColor;
    private int currentColor;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnerCoroutine());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator SpawnerCoroutine()
    {
        while (spawning)
        {
            GameObject barrier = Instantiate(prefab);

            currentColor = Random.Range(0, 3);

            while (currentColor == lastColor)
                currentColor = Random.Range(0, 3);

            barrier.GetComponent<BarrierBehaviour>().SetColor(lastColor);
            barrier.transform.parent = transform;

            lastColor = currentColor;

            yield return new WaitForSeconds(0.7f);
        }
    }
}
