using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class parameter : MonoBehaviour
{
    public int hp=100;

    // Start is called before the first frame update
    void Start()
    {
        print(hp);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    //ダメージを受けた時
    public void Damaged(int damage)
	{
        hp = hp - damage;
        print(hp);
        if(hp<=0)
        {
            SceneManager.LoadScene("main menu");
        }
	}
}
