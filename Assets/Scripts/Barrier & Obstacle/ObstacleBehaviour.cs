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

        transform.position = new Vector3(transform.position.x - obstacleSpeed * Time.deltaTime, transform.position.y,
            transform.position.z);
    }
}
