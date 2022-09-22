using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//public parameter parameter;

public class pitfall : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
           //paramater.hp=-10;
        }
    }
}
