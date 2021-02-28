using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleBehaviour : MonoBehaviour
{
    public float obstacleSpeed = 40.0f;

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x <= -20.0f)
            Destroy(gameObject);

        transform.Translate(new Vector3(-obstacleSpeed * Time.deltaTime, 0.0f, 0.0f));
    }
}
