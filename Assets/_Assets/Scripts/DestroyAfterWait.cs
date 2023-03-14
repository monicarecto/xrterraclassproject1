using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyAfterWait : MonoBehaviour
{
    public float waitTime;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(WaitThenDestory());
    }

    IEnumerator WaitThenDestory()
    {
        yield return new WaitForSeconds(waitTime);
        Destroy(gameObject);
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
