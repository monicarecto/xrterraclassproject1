using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectTracker : MonoBehaviour
{
    public List<GameObject> trackedObjects = new List<GameObject>();
    public static ObjectTracker Instance;

    public void DestroyNow()
    {
        foreach (GameObject go in trackedObjects)
        {
            Destroy(go);
        }
        trackedObjects.Clear();
    }

    public void AddToTracked(GameObject objectToAdd)
    {
    trackedObjects.Add(objectToAdd);
    }

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(this);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}