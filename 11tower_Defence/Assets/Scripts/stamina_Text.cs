using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class stamina_Text : MonoBehaviour
{
    private Text text;
    public static float stm;     // ü��
    public static float enemy;   // óġ�� ���� ����

    void Start()
    {
        stm = 10;   // �⺻ ü�� 10
        enemy = 0;
        text = this.gameObject.GetComponent<Text>();
    }

    void Update()
    {
        text.text = "stamina: " + stm.ToString() + "\nkill: " + enemy.ToString() + "/20";
    }
}
