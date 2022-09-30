using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour    // ctrl Ŭ�� -> ���� �ҽ� ����
{
    // Start is called before the first frame update
    // ī�޶� GameObjectó��. Main Camera�� ����. ���������� ����
    public GameObject camera;
    public Rigidbody rb;
    public ConstantForce cf;   // player�� ��(�߷�)�� �ٲٱ�
    float current_y = 0;
    float current_angle = 0;

    // �� ����
    void Start()
    {
        // ť ����
    }

    // Update is called once per frame
    void Update()   // �ʴ� 60�� ȣ��
    {

        // jump
        if (Input.GetKeyDown(KeyCode.Space))   // Ŭ��(�ܺ� �Է� - Input)���� �� �� ��
        {
            //transform.position = new Vector3(transform.position.x, 5, transform.position.y);   // transform�� component�� �ƴ�(GetComponent �� ��)   ��ǥ �����
            rb.AddForce(Vector3.up * 7, ForceMode.VelocityChange);   // up�� static �޼ҵ�. y�������� 1��ŭ (0, 1, 0)
        }

        /*if (rb.velocity.y != 0)
            print("velocity" + rb.velocity.y);*/

        // right
        /*if (Input.GetKey(KeyCode.D))   // ������ ���� �� ����������
        {
            //rb.AddForce(Vector3.right, ForceMode.VelocityChange);   // ���ӵ��� ����
            rb.velocity = new Vector3(3, rb.velocity.y, 0);   // ����� ������?
        }*/

        int speed = 3;
        // shiftŰ �޸���
        if (Input.GetKey(KeyCode.LeftShift))
            speed = 10;

        // left&right    
        // rb.velocity = new Vector3(Input.GetAxis("Horizontal")*speed, rb.velocity.y, rb.velocity.z);
        // 3��Ī �յ�
        rb.velocity = new Vector3(Input.GetAxis("Vertical") * speed, rb.velocity.y, 0);


        // Player�� ���� ī�޶� ��ǥ ���� (���� ��ü-Player ��ġ������ z���� ����)
        // �� ���� �Ʒ��� ���� ���� ����
        int camera_angle = 4;
        int camera_angle_value = 0;
        float gap = 0.1f;

        // �� ���� ���� ��
        if (transform.position.y > 0)
        {
            // ī�޶� ��ġ�� camera_angle ���̱��� +0.1��ŭ ������ (�ִϸ��̼�ó��)
            if (current_y < camera_angle)
                current_y += gap;

            if (current_angle < camera_angle_value)
                current_angle += gap;
        }
        else
        {   // �� �ؿ� ���� ��
            camera_angle = -5;   // ī�޶� y�� ���� �ּҰ�
            camera_angle_value = -10;   // x�� ���� �ּҰ�

            if (current_y > camera_angle)
                current_y -= gap;

            if (current_angle > camera_angle_value)
                current_angle -= gap;
            
        }

        // �밢������ �������� (����)
        camera.transform.rotation = Quaternion.Euler(current_angle, 90, 0);   // 360�� ������ ���(���Ϸ� ����). ������ -1~1
        // camera.transform.Rotate(camera_angle_value, 0, 0);   // ���� ȸ��

        // camera.transform.position = new Vector3(this.transform.position.x, transform.position.y, transform.position.z - 10);   // Ⱦ ��ũ��
        camera.transform.position = new Vector3(this.transform.position.x - 10, transform.position.y + current_y, transform.position.z);   // 3��Ī
        // getter, setter �޼ҵ�(ex. Vector3.right, zero)�� �޸� ������ �ʿ����
        

        // �߷� ���� �ٲٱ�
        // �� ������ �������� �ִ°� (�� �� �Ͼ�� ��Ȳ)
        if (transform.position.y < -3 && cf.force.y < 0)   // ������
        {
            cf.force = new Vector3(0, 30, 0);
        }  // �� ���� �ö󰡰� �ִ°�
        else if (transform.position.y > 2 && cf.force.y > 0)
        {
            cf.force = new Vector3(0, -3, 0);
        }

        // ���� ����
        // �̴� ����
        
    }
}


