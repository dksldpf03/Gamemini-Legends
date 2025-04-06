using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class GamePlayer : MonoBehaviour
{
    public string playerName; // ���� - string
    public int Score; // ���� - int
    public int Hp;
    public float GameTimer; // �Ҽ��� - float
    public bool IsPlaying; // �³� Ʋ����

    private void Start()
    {
        
    }

    private void Update()
    {

        if (!IsPlaying)
        {
            Debug.Log("������ �������ϴ�");
            return;
        }



        GameTimer = GameTimer - Time.deltaTime;
        if (GameTimer <= 0) 
        {
            IsPlaying = false;
        }
    }

    private void OnTriggerEnter(Collider other)
    {

        bool isEnemy = other.gameObject.tag == "Enemy";
        bool isItem = other.gameObject.tag == "Item";

        if (isEnemy)
        {
            Debug.Log("Enemy Check");
            Hp = Hp - 1;

            if (Hp <= 0)
            {
                IsPlaying = false;
            }
        }


        if(isItem)
        {
            Debug.Log("Item Chack");
            Score = Score + 1;
        }

        Destroy(other.gameObject);

        // Destroy �ı�
        // Instantiate ����
    }

}
