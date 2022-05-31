using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class canonMovement : MonoBehaviour
{
    public static float angle;
    Vector2 target;
    public static Vector3 objPosition;
    public GameObject bullet;
    public GameObject enemyMove;
    public static GameObject cloneEnemy;

    // Start is called before the first frame update
    void Start()
    {
        target = transform.position;
        cloneEnemy = Instantiate(enemyMove, new Vector3(9.42f, 0, 0), Quaternion.identity);   // ������ �� �� ����
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 mousePosition = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 5);   // ���콺�� vector2
        objPosition = Camera.main.ScreenToWorldPoint(mousePosition);

        // ���콺�� ���󰡴� ����
        angle = Mathf.Atan2(objPosition.y - target.y, objPosition.x - target.x) * Mathf.Rad2Deg;
        this.transform.rotation = Quaternion.AngleAxis(angle - 90, Vector3.forward);

        // �ϳ��� �����ǰ� �߻�
        if (Input.GetMouseButtonUp(0))
        {
            GameObject cloneBullet = Instantiate(bullet, new Vector3(0, 0, 0), Quaternion.identity);   // �Ѿ� �ν��Ͻ� ����(������)
            cloneBullet.GetComponent<Rigidbody2D>().AddForce(objPosition * 50);
            cloneBullet.transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);   // �Ѿ� ������ ���콺 ����(���� ����)���� ����
            Debug.Log("bulletAngle");
        }

        cloneEnemy.transform.position = Vector3.MoveTowards(cloneEnemy.transform.position, new Vector3(0, 0, 0), 0.01f);   //���� ������ ����
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "enemy")   // ������ ���� �ε�����
        {
            Debug.Log("DEAD"); //�����â�� �۾�... �̾ȿ� �ٸ����� �־� ���� ���� �˷��ּŵ� ������?!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
        }
    }
}
