using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class instruction_Text : MonoBehaviour
{
    public Text text;

    void Start()
    {
        text.text = "";   // ó���� ����
    }

    void Update()
    {
        if (bodyMovement.finish == true)   // ������ ����ǰ�
        {
            if (enemyStamina_Text.stm2 == 0)      // ü���� 0�̾��� ��
                text.text = "Failed!";
            else text.text = "Success!";   // ���� �� �׿��� ��
        }

    }
}
