using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bodyMovement : MonoBehaviour
{
    public static GameObject boss;
    public GameObject originalBoss;
    public static Vector3 playerPosition;

    public GameObject bullet;   // prefeb ���
    GameObject cloneBullet;

    float rotationX;
    public static float speed = 0.01f;

    public static bool finish = false;   // ü���� 0�� �ǰų� ���� ��� �׿��� �� true
    bool spawn = false;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // ���� ȸ��
        float angle = transform.eulerAngles.y;   // ���� ȸ���ϴ� �� �� yȸ������ ����

        Vector3 movement = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        transform.Translate(movement / 50);
        playerPosition = transform.position;

        float headX = Input.GetAxis("Mouse X");   // ���콺�� ���� �¿�θ� ȸ�� (���Ʒ� ȸ���� ��� ������)
        //float headY = Input.GetAxis("Mouse Y");

        rotationX = rotationX + headX;     // ȸ���� ����
        //rotationY = rotationY + headY;

        transform.eulerAngles = new Vector3(0.0f, rotationX, 0.0f);   // �÷��̾� ȸ����

        // ȭ�� ���� ��ġ
        Vector3 cloneArrow = new Vector3(Screen.width*6/8, Screen.height /2, 1f); // ���� ȭ�鿡�� ȭ���� ������ ��ġ ������Ʈ (�����) *���� �Ʒ��� (0, 0)*
        Vector3 cloneArrowInUnity = Camera.main.ScreenToWorldPoint(cloneArrow);      // ȭ�� ��ǥ�� ����Ƽ ��ġ������ ��ȯ *�������(0, 0). ũ�⵵ �ٸ�*

        // ���콺 ��ư�� �����ٰ� ������ �� ȭ�� �߻�
        if (Input.GetMouseButtonUp(0) && Time.frameCount % 3 == 0)   // ȭ�� �߻� ������
        {
            cloneBullet = Instantiate(bullet);   // ȭ�� prefeb���� �ν��Ͻ�ȭ
            cloneBullet.transform.position = cloneArrowInUnity;   // ������ ���� ��ġ�� ȭ�� �ű�
            Vector3 screenPositon = new Vector3(Screen.width /2, Screen.height*3/5, 500f);   // ���� ȭ�鿡�� ȭ���� ���� ��ġ
            Vector3 aimPosition = Camera.main.ScreenToWorldPoint(screenPositon);   // ȭ�� ��ǥ�� ����Ƽ ��ǥ�� ����
            cloneBullet.GetComponent<Rigidbody>().AddForce(aimPosition * 5f);      // ��ġ*��
       
            cloneBullet.transform.eulerAngles = new Vector3(0, angle+80, -head.rotationY-5);   // �÷��̾ ȸ���ϸ� ȭ���� ���⵵ ȸ��. headY?*****************************************************
        }

        // ������� �� óġ�ϸ� ���� ����
        if (enemyStamina_Text.stm1 == 0)
        {
            if(spawn != true)   // �� ���� ����
            {
                boss = Instantiate(originalBoss, new Vector3(0, 5.86f, 0), Quaternion.identity);
                spawn = true;
            }

            boss.transform.rotation = Quaternion.LookRotation(transform.position - boss.transform.position).normalized;
            boss.transform.position = Vector3.MoveTowards(boss.transform.position, transform.position, speed);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "enemy")   // ������ ���� �ε�����
        {
            playerStamina_Text.stm--;          // ���� ü�� ��� �ϱ�

            if (playerStamina_Text.stm == 0)   // ���� ü���� 0�� �Ǹ�
                finish = true;           // ���� ���� (failed �����ֱ�)
        }
    }
}
