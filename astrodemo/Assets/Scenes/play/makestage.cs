using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class makestage : MonoBehaviour
{
    //使うオブジェクトの宣言
    public GameObject whitecube;
    public GameObject blackcube;
    public GameObject start;
    public GameObject goal;

    //ステージの配置
    public int[,] stageArray = new int[17,17]{
        {1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1},
        {1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1},
        {1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1},
        {1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1},
        {1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1},
        {1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1},
        {1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1},
        {2,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,3},
        {2,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,3},
        {2,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,3},
        {1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1},
        {1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1},
        {1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1},
        {1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1},
        {1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1},
        {1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1},
        {1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1}
    };

    void Start()
    {
        //ステージを配置する
        int stagesquares=0;
        for(int i=0;i<stageArray.GetLength(0); i++){
            for(int j=0;j<stageArray.GetLength(1); j++){
                //床の配置
                if(stageArray[i,j]==0){
                    if(stagesquares==0){
                        Instantiate(blackcube,new Vector3(i,-1,j),Quaternion.identity);
                    }else{
                        Instantiate(whitecube,new Vector3(i,-1,j),Quaternion.identity);
                    }
                }else if(stageArray[i,j]==1){ //壁の配置
                    Instantiate(whitecube,new Vector3(i,0,j),Quaternion.identity);
                }else if(stageArray[i,j]==2){ //ゴールの配置
                    Instantiate(goal,new Vector3(i,-1,j),Quaternion.identity);
                }else if(stageArray[i,j]==3){ //スタートの配置
                    Instantiate(start,new Vector3(i,-1,j),Quaternion.identity);
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
