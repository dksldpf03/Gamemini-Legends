using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class GamePlayer : MonoBehaviour
{
    public string playerName; // 문자 - string
    public int Score; // 숫자 - int
    public int Hp;
    public float GameTimer; // 소숫점 - float
    public bool IsPlaying; // 맞냐 틀리냐

    private void Start()
    {
        
    }

    private void Update()
    {

        if (!IsPlaying)
        {
            Debug.Log("게임이 끝났습니다");
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

        // Destroy 파괴
        // Instantiate 생성
    }

}
