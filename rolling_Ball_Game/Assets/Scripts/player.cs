using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    private bool IsJumping;
    private GameObject fallingLand;

    // Start is called before the first frame update
    void Start()
    {
        IsJumping = false;
        fallingLand = GameObject.FindGameObjectWithTag("fallingLand");
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 movement = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        transform.Translate(movement / 15);
        Debug.Log(movement);

        if (Input.GetKeyDown(KeyCode.Space))
        {

            if (!IsJumping)
            {
                IsJumping = true;
                GetComponent<Rigidbody>().AddForce(Vector3.up * 7.0f, ForceMode.Impulse);   // Impulse - ������ ������ �����鼭 ���� ���ϴ� �ɼ�
            }

            else
                return;
        }        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Land"))
            IsJumping = false;

        if (collision.gameObject.tag.Equals("obstacle"))
        {
            textControl.po -= 1;   // ������ text���� �浹 Ƚ���� ���� ���� po�� textControl.cs���� �ҷ��ͼ� ���
            Object.Destroy(collision.gameObject);
        }

        if (collision.gameObject.CompareTag("fallingLand"))   // ���� ������ ����߸���
        {
            fallingLand.GetComponent<Rigidbody>().useGravity = true;
            Object.Destroy(gameObject, 5);
        }

        if (collision.gameObject.tag == "coin")   // ���� �Ա�
        {
            Object.Destroy(collision.gameObject);
            textControl.po += 1;
        }
    }
}
