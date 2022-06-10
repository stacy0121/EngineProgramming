using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bodyMovement : MonoBehaviour
{
    public static GameObject sub;
    public GameObject originalSub;

    public GameObject bullet;
    GameObject cloneBullet;

    float rotationX;
    float rotationY;

    // Start is called before the first frame update
    void Start()
    {
        sub = Instantiate(originalSub, new Vector3(Random.Range(-10f, 10f), 10, Random.Range(-10f, 10f)), Quaternion.identity);   // ����ǰ ���� (���� ����)
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 movement = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        transform.Translate(movement / 50);

        // ���� ȸ��
        float headX = Input.GetAxis("Mouse X");
        float headY = Input.GetAxis("Mouse Y");   // ���콺�� �ʱ�ȭ

        rotationX = rotationX + headX;
        rotationY = rotationY + headY;           // ����

        transform.eulerAngles = new Vector3(-rotationY, rotationX, 0.0f);

        if (Input.GetMouseButtonUp(0))
        {
            cloneBullet = Instantiate(bullet, transform.position, Quaternion.identity);
            Vector3 screenPositon = new Vector3(Screen.width / 2, Screen.height / 2, 10f);   // ���� ȭ�鿡�� ��ġ ������Ʈ (�����) *���� �Ʒ��� (0, 0)*
            Vector3 aimPosition = Camera.main.ScreenToWorldPoint(screenPositon);   // ȭ�� ��ǥ�� ����Ƽ ��ġ������ ��ȯ *������� (0, 0). ũ�⵵ �ٸ�*
            cloneBullet.GetComponent<Rigidbody>().AddForce(aimPosition * 100f);   // ��ġ*��
        }
    }
}
