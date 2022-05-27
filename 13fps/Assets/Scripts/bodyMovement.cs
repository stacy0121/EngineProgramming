using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bodyMovement : MonoBehaviour
{
    public static GameObject diglett;
    public GameObject originalDig;

    float rotationX;
    float rotationY;

    // Start is called before the first frame update
    void Start()
    {
        //diglett = Instantiate(originalDig, new Vector3(5, 10, 5), Quaternion.identity);   // ȸ�� ����
        diglett = Instantiate(originalDig, new Vector3(Random.Range(-10f, 10f), 10, Random.Range(-10f, 10f)), Quaternion.identity);   // ����ǰ ���� (���� ����)
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 movement = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        transform.Translate(movement/50);

        // ���� ȸ��
        float headX = Input.GetAxis("Mouse X");
        float headY = Input.GetAxis("Mouse Y");   // ���콺�� �ʱ�ȭ

        rotationX = rotationX + headX;
        rotationY = rotationY + headY;           // ����

        transform.eulerAngles = new Vector3(-rotationY, rotationX, 0.0f);
    }
}
