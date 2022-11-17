using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroy : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        Debug.Log("壊す"); // ログを表示する
        Destroy(other.gameObject);
        transform.position= new Vector3(0,0,0);
    }
}
