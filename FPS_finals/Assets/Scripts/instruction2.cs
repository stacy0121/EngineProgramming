using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class instruction2 : MonoBehaviour
{
    public Text text;
    // Start is called before the first frame update
    void Start()
    {
        
}

    // Update is called once per frame
    void Update()
    {
        if (enemy.distance > 15.0f) text.text = "�ͽſ��� ������ �ٰ�������";
        else
        {
            if(enemyStamina_Text.stm1 == 0 && enemyStamina_Text.stm2 == 19)   // ���� ���� ������� ������ �������� ��
            {
                text.text = "���� ������?";
            }
            else
            {
                text.text = "";
            }
        }
    }
}
