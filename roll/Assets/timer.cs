using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class timer : MonoBehaviour
{
    private Text text;
    private float Timer;

    // Start is called before the first frame update
    void Start()
    {
        text = this.gameObject.GetComponent<Text>();   // �ð� ����
    }

    // Update is called once per frame
    void Update()
    {
        if(counter.count < 1)   // ī��Ʈ�� �� ���� Ÿ�̸� ����
        {
            if (run.xPos < 144)   // ������ �������� ���
                Timer += Time.deltaTime;   // �ð� ��ũ ����
            //text.text = Timer.ToString();
            text.text = string.Format("{0:N2}", Timer);   // �Ҽ��� �Ʒ� 2�ڸ�
            //Debug.Log(Timer);
        }
        
    }
}
