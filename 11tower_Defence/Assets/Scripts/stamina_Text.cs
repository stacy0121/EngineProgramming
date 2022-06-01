using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class stamina_Text : MonoBehaviour
{
    private Text text;
    public static float stm;     // 체력
    public static float enemy;   // 처치한 적의 개수

    void Start()
    {
        stm = 10;   // 기본 체력 10
        enemy = 0;
        text = this.gameObject.GetComponent<Text>();
    }

    void Update()
    {
        text.text = "stamina: " + stm.ToString() + "\nkill: " + enemy.ToString() + "/20";
    }
}
