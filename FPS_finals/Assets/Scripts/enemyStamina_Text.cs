using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class enemyStamina_Text : MonoBehaviour
{
    public Text text;   // text를 입력하기 위한 창
    public static float stm1;     // 서브몹의 체력
    public static float stm2;     // 보스의 체력

    void Start()
    {
        stm1 = 10;
        stm2 = 20;
    }

    void Update()
    {
        if (stm1 != 0) text.text = "적의 체력: " + stm1.ToString();   // 서브몹의 체력이 닿을 때까지
        else
        {
            text.text = "보스의 체력: " + stm2.ToString();
            if (stm2 == 0) bodyMovement.finish = true;   // 보스의 체력이 다 닳으면 끝
        }
    }
}
