using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pitfall : MonoBehaviour
{

    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
           int pitfall = 10;
			other.gameObject.GetComponent<parameter>().Damaged(pitfall);
        }
    }
}
