using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ScoreRegulator : MonoBehaviour
{

    //�X�R�A��\������e�L�X�g
    private GameObject ScoreText;
    //�X�R�A�̏����l��ݒ�
    private int Score = 0;

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        //�V�[������ScoreText�I�u�W�F�N�g���擾
        this.ScoreText = GameObject.Find("ScoreText");
        //ScoreText�ɓ_����\��
        this.ScoreText.GetComponent<Text>().text = "Score:" + Score;

       
    }
    

    //�Փˎ��ɌĂ΂��֐�
    void OnCollisionEnter(Collision other)
    {

        //�e�^�[�Q�b�g���ƂɎ擾�ł���_����ݒ�
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
