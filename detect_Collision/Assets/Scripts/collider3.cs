using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collider3 : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag.Equals("Player"))
        {
            Debug.Log("E3");
            textControl.po -= 1;   // ������ text���� �浹 Ƚ���� ���� ���� po�� textControl.cs���� �ҷ��ͼ� ���
            Destroy(GameObject.FindWithTag("E3"));
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
