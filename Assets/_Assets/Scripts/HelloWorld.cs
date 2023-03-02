using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloWorld : MonoBehaviour
{
    int frameCount;

    // Start is called before the first frame update
    void Start()
    {
        frameCount = 0;
        Debug.Log("Hello, World!");
    }

    // Update is called once per frame
    void Update()
    {
        frameCount = frameCount + 1;
        string coolMessage = "Frame" + frameCount;
        Debug.Log(coolMessage);
    }
}
