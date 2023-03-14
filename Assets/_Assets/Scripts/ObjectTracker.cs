using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectTracker : MonoBehaviour
{
    public float totalDestructionTime = 2f;

    public List<GameObject> trackedObjects = new List<GameObject>();
    public static ObjectTracker Instance;

    public void DestroyNow()
    {
        StartCoroutine(DestroyOverTime());
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

    IEnumerator DestroyOverTime()
    {
        float timeBetween = totalDestructionTime / trackedObjects.Count;
        foreach (GameObject go in trackedObjects)
        {
            Destroy(go);
            yield return new WaitForSeconds(timeBetween);
        }
        trackedObjects.Clear();
    }
}