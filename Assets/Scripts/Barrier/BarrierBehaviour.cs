﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarrierBehaviour : MonoBehaviour
{
    public CurrentColor currentColor = CurrentColor.RED;

    private MeshRenderer meshRenderer = null;

    private void Awake()
    {
        meshRenderer = GetComponent<MeshRenderer>();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector3(-5.0f * Time.deltaTime, 0.0f, 0.0f));
    }

    public void SetMaterial(Material material)
    {
        meshRenderer.material = material;
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            var player = other.GetComponent<Player>();

            if (player.currentColor != currentColor)
            {
                Debug.Log("DENIED");
                player.health -= 1;
            }
            else
            {
                Debug.Log("ALLOWED");
            }
        }
    }
}
