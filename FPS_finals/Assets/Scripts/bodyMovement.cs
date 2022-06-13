using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bodyMovement : MonoBehaviour
{
    public static GameObject sub;
    public GameObject originalSub;

    public GameObject bullet;   // prefeb ���
    GameObject cloneBullet;

    float rotationX;
    float rotationY;

    float spawnX; float spawnY; float spawnZ;
    float rotateY;

    // Start is called before the first frame update
    void Start()
    {
        sub = Instantiate(originalSub, new Vector3(Random.Range(-10f, 10f), 10, Random.Range(-10f, 10f)), Quaternion.identity);   // ����ǰ ���� (���� ����)
        spawnX = transform.position.x; spawnY = transform.position.y; spawnZ = transform.position.z;
        rotateY = transform.rotation.y;
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
        rotationY = rotationY + headY;           // ���� ������ ����

        transform.eulerAngles = new Vector3(-rotationY, rotationX, 0.0f);

        spawnX = transform.position.x + 0.8f; spawnY = transform.position.y + 1.27f; spawnZ = transform.position.z + 0.930f;   // ���� ��ġ�� �÷��̾� ���������� ����
        rotateY = transform.eulerAngles.y + 71.128f;   // ȭ�� ȸ��

        if (Input.GetMouseButtonUp(0))
        {
            cloneBullet = Instantiate(bullet, new Vector3(spawnX, spawnY, spawnZ), Quaternion.identity);
            cloneBullet.transform.eulerAngles = new Vector3(transform.eulerAngles.x, rotateY, 1);
            Vector3 screenPositon = new Vector3(Screen.width / 2, Screen.height / 2, 10f);   // ���� ȭ�鿡�� ��ġ ������Ʈ (�����) *���� �Ʒ��� (0, 0)*
            Vector3 aimPosition = Camera.main.ScreenToWorldPoint(screenPositon);   // ȭ�� ��ǥ�� ����Ƽ ��ġ������ ��ȯ *������� (0, 0). ũ�⵵ �ٸ�*
            Debug.Log(aimPosition);
            cloneBullet.GetComponent<Rigidbody>().AddForce(aimPosition * 50f);   // ��ġ*��
        }
    }
}
