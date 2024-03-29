using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class makestage_E : MonoBehaviour
{
    //使うオブジェクトの宣言
    public GameObject whitecube;
    public GameObject blackcube;
    public GameObject start;
    public GameObject goal;
    public GameObject pitfall;

    public Transform goal_p;
    public Transform start_p;
    public Transform floor_p;
    public Transform wall_p;
    public Transform pitfall_p;

    public stage stage;
    // Start is called before the first frame update
    void Start()
    {
        //ステージを配置する
        int stagesquares=0;
        for(int i=0;i<stage.stageArray.GetLength(0); i++){
            for(int j=0;j<stage.stageArray.GetLength(1); j++){
                //床の配置
                if(stage.stageArray[i,j]==0){
                    if(stagesquares==0){
                        GameObject obj=Instantiate(blackcube,new Vector3(i,-1,j),Quaternion.identity);
                        obj.transform.SetParent(floor_p);
                    }else{
                        GameObject obj=Instantiate(whitecube,new Vector3(i,-1,j),Quaternion.identity);
                        obj.transform.SetParent(floor_p);
                    }
                }else if(stage.stageArray[i,j]==1){ //壁の配置
                    GameObject obj=Instantiate(whitecube,new Vector3(i,0,j),Quaternion.identity);
                    obj.transform.SetParent(wall_p);
                }else if(stage.stageArray[i,j]==2){ //ゴールの配置
                    GameObject obj=Instantiate(goal,new Vector3(i,-1,j),Quaternion.identity);
                    obj.transform.SetParent(goal_p);
                }else if(stage.stageArray[i,j]==3){ //スタートの配置
                    GameObject obj=Instantiate(start,new Vector3(i,-1,j),Quaternion.identity);
                    obj.transform.SetParent(start_p);
                }else if(stage.stageArray[i,j]==5){ //落とし穴の配置
                    GameObject obj=Instantiate(pitfall,new Vector3(i,-1,j),Quaternion.identity);
                    obj.transform.SetParent(pitfall_p);
                }
                //しましま
                if(stagesquares==0){
                    stagesquares=1;
                }else{
                    stagesquares=0;
                }
            }
        }
    }
}
