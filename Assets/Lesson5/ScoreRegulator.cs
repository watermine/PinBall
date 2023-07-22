using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ScoreRegulator : MonoBehaviour
{

    //スコアを表示するテキスト
    private GameObject ScoreText;
    //スコアの初期値を設定
    private int Score = 0;

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        //シーン中のScoreTextオブジェクトを取得
        this.ScoreText = GameObject.Find("ScoreText");
        //ScoreTextに点数を表示
        this.ScoreText.GetComponent<Text>().text = "Score:" + Score;

       
    }
    

    //衝突時に呼ばれる関数
    void OnCollisionEnter(Collision other)
    {

        //各ターゲットごとに取得できる点数を設定
        if (other.gameObject.tag == "SmallStarTag")
        {
           Score += 1;
        }
        else if(other.gameObject.tag == "LargeStarTag")
        {
           Score += 100;
        }
        else if (other.gameObject.tag == "SmallCloudTag")
        {
           Score += 10;
        }
        else if(other.gameObject.tag == "LargeCloudTag")
        {
           Score += 1000;
        }
    }
}
