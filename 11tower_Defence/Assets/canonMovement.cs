using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class canonMovement : MonoBehaviour
{
    public static float angle;
    Vector2 target;
    public static Vector3 objPosition;
    public GameObject bullet;

    // Start is called before the first frame update
    void Start()
    {
        target = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 mousePosition = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 5);   // ���콺�� vector2
        objPosition = Camera.main.ScreenToWorldPoint(mousePosition);
        Debug.Log(objPosition + ", " + mousePosition);

        // ���콺�� ���󰡴� ����
        angle = Mathf.Atan2(objPosition.y - target.y, objPosition.x - target.x) * Mathf.Rad2Deg;
        this.transform.rotation = Quaternion.AngleAxis(angle - 90, Vector3.forward);

        // �ϳ��� �����ǰ� �߻�
        if (Input.GetMouseButtonUp(0))
        {
            GameObject cloneBullet = Instantiate(bullet, new Vector3(0, 0, 0), Quaternion.identity);
            cloneBullet.GetComponent<Rigidbody2D>().AddForce(objPosition * 50);
        }
    }
}
