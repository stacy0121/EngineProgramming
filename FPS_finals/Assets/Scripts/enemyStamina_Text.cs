using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class enemyStamina_Text : MonoBehaviour
{
    public Text text;   // text�� �Է��ϱ� ���� â
    public static float stm1;     // ������� ü��
    public static float stm2;     // ������ ü��

    void Start()
    {
        stm1 = 10;
        stm2 = 20;
    }

    void Update()
    {
        if (stm1 != 0) text.text = "���� ü��: " + stm1.ToString();   // ������� ü���� ���� ������
        else
        {
            text.text = "������ ü��: " + stm2.ToString();
            if (stm2 == 0) bodyMovement.finish = true;   // ������ ü���� �� ������ ��
        }
    }
}
