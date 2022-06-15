using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class playerStamina_Text : MonoBehaviour
{
    public Text text;   // text를 입력하기 위한 창
    public static float stm;     // 플레이어의 체력

    void Start()
    {
        stm = 10;
    }

    void Update()
    {
        text.text = "나의 체력: " + stm.ToString();
    }
}
