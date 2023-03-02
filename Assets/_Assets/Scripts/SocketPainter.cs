using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class SocketPainter : MonoBehaviour
{

    public GameObject SockettedObject;

    public void RegisterObject (SelectEnterEventArgs args)

    {
        SockettedObject = args.interactableObject.transform.gameObject;
        
    }

    public void ReleaseObject ()

    {
        SockettedObject = null;
    }

    public void ChangeMaterial(Material newMaterial)


    {
        if (SockettedObject != null)
        {
           Renderer[] Renderers= SockettedObject.GetComponentsInChildren<Renderer>();
            foreach(Renderer renderer in Renderers)
            {
                renderer.material = newMaterial;
            }

        }

    }
}

