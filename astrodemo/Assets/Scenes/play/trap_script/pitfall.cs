using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pitfall : MonoBehaviour
{
    public parameter parameter;

    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
           parameter.hp=parameter.hp-10;
        }
    }
}
