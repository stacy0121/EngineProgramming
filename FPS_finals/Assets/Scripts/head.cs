using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class head : MonoBehaviour
{
    public static float angleCam;
    float rotationX;
    public static float rotationY;

    public static float headY;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // ī�޶��� ȸ��
        float headX = Input.GetAxis("Mouse X");
        headY = Input.GetAxis("Mouse Y");   // ���콺�� �ʱ�ȭ

        rotationX = rotationX + headX;
        rotationY = rotationY + headY;           // ȸ���� ����

        transform.eulerAngles = new Vector3(-rotationY, rotationX, 0.0f);
    }
}
