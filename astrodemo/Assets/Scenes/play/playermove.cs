using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playermove : MonoBehaviour
{
    public makestage makestage;
    public GameObject player;
    public int[,] playerArray = new int[17,17]{
        {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
        {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
        {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
        {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
        {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
        {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
        {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
        {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
        {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1,0},
        {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
        {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
        {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
        {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
        {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
        {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
        {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
        {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0}
    };
    void Start()
    {
        for(int k=0;k<playerArray.GetLength(0);k++){
            for(int l=0;l<playerArray.GetLength(1);l++){
                if(playerArray[k,l]==1){
                    Instantiate(player,new Vector3(k,0,l),Quaternion.identity);
                }
            }
        }
    }
    void Update()
    {
        if (Input.GetKeyDown (KeyCode.RightArrow)) {
            updateplayerposition(0,1);
        }
        if (Input.GetKeyDown (KeyCode.LeftArrow)) {
            updateplayerposition(0,-1);
        }
        if (Input.GetKeyDown(KeyCode.DownArrow)) {
            updateplayerposition(1,0);
         }
        if (Input.GetKeyDown(KeyCode.UpArrow)) {
            updateplayerposition(-1,0);
        }
    }

    void updateplayerposition(int x,int y)
    {
        int playerpositionx=0;
        int playerpositiony=0;
        for(int i=0;i<playerArray.GetLength(0);i++){
            for(int j=0;j<playerArray.GetLength(1);j++){
                if(playerArray[i,j]==1){
                    playerpositionx=i;
                    playerpositiony=j;
                }
            }
        }
        Debug.Log(playerpositiony+" "+playerpositiony);
        if(makestage.stageArray[playerpositionx+x,playerpositiony+y]==1){
            return;
        }else{
            playerArray[playerpositionx+x,playerpositiony+y]=2;
            playerArray[playerpositionx,playerpositiony]=0;
            return;
        }
    }
}