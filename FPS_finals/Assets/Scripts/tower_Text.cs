using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class tower_Text : MonoBehaviour
{
    private Text text;   // text�� �Է��ϱ� ���� â
    public static float stm;     // ���� ü��

    void Start()
    {
        stm = 1;
    }

    void Update()
    {
        text.text = "tower stamina: " + stm.ToString();
    }
}
