using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class playerStamina_Text : MonoBehaviour
{
    public Text text;   // text�� �Է��ϱ� ���� â
    public static float stm;     // �÷��̾��� ü��

    void Start()
    {
        stm = 10;
    }

    void Update()
    {
        text.text = "���� ü��: " + stm.ToString();
    }
}
