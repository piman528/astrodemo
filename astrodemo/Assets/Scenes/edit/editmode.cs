using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class editmode : MonoBehaviour
{
    public int mode=0;
    float dt = 0;

    void Update()
    {
        dt += Time.deltaTime;
        if (dt > 1)
        {
            dt = 0.0f;
            print(name+"="+mode.ToString("0"));
        }
    }


    public void pitfall_mode()
    {
        mode=1;
        Debug.Log("1に変更");
    }
    public void press_esc_mode()
    {
        mode=0;
        Debug.Log("0に変更");
    }
}
