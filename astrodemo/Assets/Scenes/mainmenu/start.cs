using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class start : MonoBehaviour,IPointerClickHandler
{
    // タップ  
    public void OnPointerClick(PointerEventData eventData){
        SceneManager.LoadScene("play");
    }
}