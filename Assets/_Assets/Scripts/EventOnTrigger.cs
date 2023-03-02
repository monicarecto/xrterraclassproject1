using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class EventOnTrigger : MonoBehaviour
{

    public bool doCheckTag; 
    public string tagToCheck;
    public UnityEvent OnEnter;
    private void OnTriggerEnter(Collider other)
    {
        if (doCheckTag)
        {


            if (other.CompareTag(tagToCheck))
            {
                Debug.Log(other.name);
                OnEnter.Invoke();
            }
        }
        else
        {
            OnEnter.Invoke();
            Debug.Log(other.name);
        }
    }
    }
 
