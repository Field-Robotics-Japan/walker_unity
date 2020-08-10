using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KyleKeyControl : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        bool Stop = true;
        if (Input.GetKeyDown(KeyCode.UpArrow)) {
            Stop = true;
        }
        else if (Input.GetKeyDown(KeyCode.RightArrow)) {
            Stop = true;
        }
        else if (Input.GetKeyDown(KeyCode.LeftArrow)) {
            Stop = true;
        }
        else if(Input.GetKeyDown(KeyCode.DownArrow)) {
            Stop = true;
        }
        else {
            Stop = false;
        }
        GetComponent<Animator>().SetBool("Stop",Stop);  
    }
}
