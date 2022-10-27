using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buttonpress : MonoBehaviour
{
    public editmode editmode;
    
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey (KeyCode.Escape)) {
            editmode.press_esc_mode();
        }
    }
}
