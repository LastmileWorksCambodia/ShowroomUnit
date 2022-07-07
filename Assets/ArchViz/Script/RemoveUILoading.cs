using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RemoveUILoading : MonoBehaviour
{
    [SerializeField] Canvas loadingCan;

    // Start is called before the first frame update
    void Start()
    {
        loadingCan.enabled = true;
        //Time.timeScale = 0;
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        Invoke("RemoveLoadingUI", 3f);
        
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void RemoveLoadingUI()
    {
        loadingCan.enabled = false;
    }
}
