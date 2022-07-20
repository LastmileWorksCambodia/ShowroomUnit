using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenAndCloseDoor : MonoBehaviour
{
    [SerializeField] private Animator DoorLeftClose = null;
    [SerializeField] private Animator DoorLeftOpen = null;
    [SerializeField] private Animator DoorRightClose = null;
    [SerializeField] private Animator DoorRightOpen = null;

    [SerializeField] private bool openTrigger = false;

   private void OnTriggerEnter(Collider other) 
   {
        if(other.CompareTag("Player"))
        {
            if(openTrigger)
            {
                DoorLeftOpen.Play("DoorLeftOpen", 0, 0.0f);
                DoorRightOpen.Play("DoorRightOpen", 0, 0.0f);
            }
        }

   }

   private void OnTriggerExit(Collider other) 
   {
        if(other.CompareTag("Player"))
        {
            if(openTrigger)
            {
                DoorLeftClose.Play("DoorLeftClose", 0, 0.0f);
                DoorRightClose.Play("DoorRightClose", 0, 0.0f);

            }
        }
   }
}
