using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletMovement : MonoBehaviour
{
    void Start()
    {
        
    }

    void Update()
    {

    }

    void OnBecameInvisible()   // ȭ�鿡�� �����
    {
        Destroy(gameObject);   // �Ѿ� ������Ʈ ����
    }

    private void OnCollisionEnter2D(Collision2D collision)   // �浹 ����
    {
        if (collision.gameObject.tag == "enemy")   // ���࿡ ���� �Ѿ��� �浹�ϸ�
        {
            Destroy(gameObject);    // �Ѿ� ���ֱ�
            stamina_Text.enemy++;   // ų �� �߰�

            if (stamina_Text.enemy == 20)      // �� 20������ ��� ���̸�
                canonMovement.finish = true;   // ���� ����
        }
    }
}
