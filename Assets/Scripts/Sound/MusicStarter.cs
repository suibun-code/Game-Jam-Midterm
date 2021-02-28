using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicStarter : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GameObject.FindGameObjectWithTag("Music").GetComponent<MenuMusic>().PlayMusic();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
