using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrackedObject : MonoBehaviour
{
    //public ObjectTracker tracker;
    // Start is called before the first frame update
    void Start()
    {
        ObjectTracker.Instance.AddToTracked(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
