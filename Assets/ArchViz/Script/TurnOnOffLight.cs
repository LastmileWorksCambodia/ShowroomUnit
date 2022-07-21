using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnOnOffLight : MonoBehaviour
{
   [SerializeField] private GameObject light = null;
    private bool on = false;
    private bool playEnterCol = false;

    private void OnTriggerEnter(Collider other) 
    {
        if(other.CompareTag("Player"))
        {
            playEnterCol = true;
        }   
    }

    private void OnTriggerExit(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            playEnterCol = false;
        }
 
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.E))
        {
            if(playEnterCol)
            {
                if(!on)
                {
                    light.SetActive(true);
                    on = true;
                }
                else
                {
                    light.SetActive(false);
                    on = false;
                }
                
            }
            
        }
    }
}
