using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class click_floor : MonoBehaviour, IPointerClickHandler
{
    public void OnPointerClick(PointerEventData eventData)
    {
        Vector3 this_object_point = this.transform.position;
        GameObject.FindWithTag("update_stage").GetComponent<updatestage>().update_stage_object(this_object_point);
    }
}
