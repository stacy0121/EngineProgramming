using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collider : MonoBehaviour
{
    // ���� 10��. �浹 : -1

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag.Equals("Player"))
        {
            Debug.Log("E1");
            textControl.po -= 1;   // ������ text���� �浹 Ƚ���� ���� ���� po�� textControl.cs���� �ҷ��ͼ� ���
            Destroy(GameObject.FindWithTag("E1"));
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        textControl.po = 10;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
