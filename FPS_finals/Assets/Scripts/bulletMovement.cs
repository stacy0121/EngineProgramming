using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletMovement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnBecameInvisible()   // ȭ�鿡�� �����
    {
        Destroy(gameObject);   // �Ѿ� ������Ʈ ����
    }

    private void OnCollisionEnter(Collision collision)   // �浹 ����
    {
        if (collision.gameObject.tag == "enemy" || collision.gameObject.tag == "tower")   // ���࿡ �Ѿ��� ���̳� Ÿ���� �浹�ϸ�
        {
            Destroy(gameObject);    // �Ѿ� ���ֱ�
        }
    }
}
