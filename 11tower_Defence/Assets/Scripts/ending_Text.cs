using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ending_Text : MonoBehaviour
{
    private Text text;

    void Start()
    {
        text = this.gameObject.GetComponent<Text>();
        text.text = "";   // ó���� ����
    }

    void Update()
    {
        if(canonMovement.finish == true)   // ������ ����ǰ�
        {
            if(stamina_Text.stm == 0)      // ü���� 0�̾��� ��
                text.text = "Failed!";
            else text.text = "Success!";   // ���� �� �׿��� ��
        }

    }
}
