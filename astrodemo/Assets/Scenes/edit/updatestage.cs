using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class updatestage : MonoBehaviour
{
    public stage stage;
    public editmode editmode;

    public void update_stage_object(Vector3 obj_point){
        print(obj_point);
        if (editmode.mode==1){
            stage.stageArray[(int)obj_point.x,(int)obj_point.z]=5;
        }
    }

}

