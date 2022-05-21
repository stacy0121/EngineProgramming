using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class drive : MonoBehaviour
{
    public Rigidbody2D rb2d;
    float xValue;
    float yValue;
    public float speed;
    public Camera camera;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        rb2d = GetComponent<Rigidbody2D>();
        yValue = Input.GetAxis("Vertical");
        xValue = Input.GetAxis("Horizontal");


        if (Input.GetKeyDown(KeyCode.LeftShift))   // ���� ����ƮŰ�� ������ ����
        {
            speed = 7;
        }

        camera.transform.position = new Vector3(transform.position.x, transform.position.y+1.5f, -10);   // ī�޶� ��ġ
    }

    public void FixedUpdate()   // ��������
    {
        //rb2d.velocity = new Vector2(0, yValue);    // ��ǥ ����
        rb2d.velocity = transform.up*yValue*speed;   // �ڱ��ڽ� ���ϱ� up * ����� �Է� ���� * ���ӷ�
        transform.Rotate(0, 0, -1 * xValue * 1);

        camera.transform.Rotate(0, 0, -1 * xValue * 0.8f);    // ī�޶� ȸ��
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.tag == "wall")   // �浹ü(Ǯ����)�� �ε����� �ֿܼ� �α� ����
        {
            Debug.Log("�浹!");
        }
    }
}
