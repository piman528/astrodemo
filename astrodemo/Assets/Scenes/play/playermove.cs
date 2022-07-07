using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playermove : MonoBehaviour
{
    //スクリプトから変数を取ってくる
    public makestage makestage;
    public makeplayer makeplayer;

    //キーの入力があったらプレイヤーの位置のアップデートをする
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

    //プレイヤーの位置のアップデート
    void updateplayerposition(int x,int y)
    {
        int playerpositionx=0;
        int playerpositiony=0;

        //配列を座標に変換
        for(int i=0;i<makeplayer.playerArray.GetLength(0);i++){
            for(int j=0;j<makeplayer.playerArray.GetLength(1);j++){
                if(makeplayer.playerArray[i,j]==1){
                    playerpositionx=i;
                    playerpositiony=j;
                }
            }
        }

        if(playerpositionx+x>=makeplayer.playerArray.GetLength(0) || playerpositionx+x<0){ //配列のxの範囲外だったらリターンする
            return;

        }else if(playerpositiony+y>=makeplayer.playerArray.GetLength(1) || playerpositiony+y<0){ //配列のyの範囲外だったらリターンする
            return;

        }else if(makestage.stageArray[playerpositionx+x,playerpositiony+y]==1){ //壁だったらリターン
            return;

        }else if(makestage.stageArray[playerpositionx+x,playerpositiony+y]==4){ //何もない場所だったらリターン
            return;

        }else{ //移動可能な場合
            //配列をアップデート
            makeplayer.playerArray[playerpositionx+x,playerpositiony+y]=1;
            makeplayer.playerArray[playerpositionx,playerpositiony]=0;
            //オブジェクトを移動させる
            transform.position = new Vector3(playerpositionx+x,0,playerpositiony+y);
            return;

        }
    }
}
