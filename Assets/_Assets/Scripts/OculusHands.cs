using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class OculusHands : MonoBehaviour
{
    
    Animator anim;
    public InputActionReference gripReference, triggerReference;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();

        gripReference.action.started += GripPressed;
        gripReference.action.canceled += GripCancelled;
        triggerReference.action.started += TriggerPressed;
        triggerReference.action.canceled += TriggerCancelled;
    }

   void OnDestroy()

    {
        anim = GetComponent<Animator>();

        gripReference.action.started -= GripPressed;
        gripReference.action.canceled -= GripCancelled;
        triggerReference.action.started -= TriggerPressed;
        triggerReference.action.canceled -= TriggerCancelled;
    }
    // Update is called once per frame
    void Update()
    {
        
    } 

    void GripPressed(InputAction.CallbackContext junk)
    {
        anim.SetBool("GripPressed", true);
    }

    void GripCancelled(InputAction.CallbackContext junk)
    {
        anim.SetBool("GripPressed", false);
    }

    void TriggerPressed(InputAction.CallbackContext junk)
    {
        anim.SetBool("TriggerPressed", true);
    }

    void TriggerCancelled(InputAction.CallbackContext junk)
    {
        anim.SetBool("TriggerPressed", false);
    }

}
 