using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarrierBehaviour : MonoBehaviour
{
    public float barrierSpeed = 40.0f;

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
        if (transform.position.x <= -20.0f)
            Destroy(gameObject);

        transform.Translate(new Vector3(-barrierSpeed * Time.deltaTime, 0.0f, 0.0f));
    }

    public void SetColor(CurrentColor color)
    {
        switch (color)
        {
            case CurrentColor.RED:
                meshRenderer.material.SetColor("_Color", new Color32(184, 15, 10, 128));
                break;

            case CurrentColor.GREEN:
                meshRenderer.material.SetColor("_Color", new Color32(50, 205, 50, 128));
                break;

            case CurrentColor.BLUE:
                meshRenderer.material.SetColor("_Color", new Color32(65, 105, 225, 128));
                break;

            case CurrentColor.PURPLE:
                meshRenderer.material.SetColor("_Color", new Color32(102, 51, 153, 128));
                break;
        }

        currentColor = color;
    }
}
