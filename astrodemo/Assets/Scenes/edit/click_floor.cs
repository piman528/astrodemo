using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class click_floor : MonoBehaviour, IPointerClickHandler
{
    public updatestage updatestage;
    public void OnPointerClick(PointerEventData eventData)
    {
        print($"オブジェクト {name} がクリックされたよ！");
    }
}
