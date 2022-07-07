using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class makestage : MonoBehaviour
{
    public GameObject whitecube;
    public GameObject blackcube;
    public GameObject start;
    public GameObject goal;
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
    // Start is called before the first frame update
    void Start()
    {
        int stagesquares=0;
        for(int i=0;i<stageArray.GetLength(0); i++){
            for(int j=0;j<stageArray.GetLength(1); j++){
                if(stageArray[i,j]==0){
                    if(stagesquares==0){
                        Instantiate(blackcube,new Vector3(i,-1,j),Quaternion.identity);
                        stagesquares=1;
                    }else{
                        Instantiate(whitecube,new Vector3(i,-1,j),Quaternion.identity);
                        stagesquares=0;
                    }
                }else if(stageArray[i,j]==1){
                    Instantiate(whitecube,new Vector3(i,0,j),Quaternion.identity);
                }else if(stageArray[i,j]==2){
                    Instantiate(goal,new Vector3(i,-1,j),Quaternion.identity);
                }else if(stageArray[i,j]==3){
                    Instantiate(start,new Vector3(i,-1,j),Quaternion.identity);
                }
            }
        }
    }
}
