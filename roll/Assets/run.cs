using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class run : MonoBehaviour
{
    public static float xPos;   // ī�޶� ����

    // Start is called before the first frame update
    void Start()
    {
        xPos = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (counter.count < 1){   // ī��Ʈ�� �� ���� ���
            // ����, ������ ȭ��ǥ Ű�� ���޾� ������ �޸���
            if (Input.GetKeyDown(KeyCode.LeftArrow) || Input.GetKeyDown(KeyCode.RightArrow))
                xPos += 6f;   // 6��ŭ ��
            transform.position = new Vector3((int)xPos, 0, 0);   // ���� ����
            if (xPos > 144)
                xPos = 149;
        }
    }
}
