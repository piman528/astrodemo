using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class editmode : MonoBehaviour
{
    public int mode=0;

    public void pitfall_mode()
    {
        mode=1;
        Debug.Log(mode);
    }
    public void press_esc_mode()
    {
        mode=0;
        Debug.Log(mode);
    }
}
