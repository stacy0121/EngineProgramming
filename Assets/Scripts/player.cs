using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour    
{
    private bool IsJumping;

    // Start is called before the first frame update
    void Start()
    {
        IsJumping = false;
    }

    // Update is called once per frame
    void Update()
    {
<<<<<<< Updated upstream
=======
<<<<<<< HEAD
        //Vector3 movement = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));  // ��ġ ����
        Vector3 movement = new Vector3(Input.GetAxis("Horizontal"), 0, 0);
        transform.Translate(movement / 50);
        Debug.Log(movement);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (!IsJumping)
            {
                IsJumping = true;

                GetComponent<Rigidbody>().AddForce(Vector3.up * 5.0f, ForceMode.Impulse);   // Impulse - ������ ������ �����鼭 ���� ���ϴ� �ɼ�
            }
=======
>>>>>>> Stashed changes
        Vector3 movement = new Vector3(Input.GetAxis("Horizontal"), 0, 0);
        transform.Translate(movement / 10);
        Debug.Log(movement);

        if (Input.GetKeyDown(KeyCode.Space)){
            GetComponent<Rigidbody>().AddForce(Vector3.up * 5.0f, ForceMode.Impulse);   // Impulse - ������ ������ �����鼭 ���� ���ϴ� �ɼ�

            if (!IsJumping)
            {
                IsJumping = true;
                GetComponent<Rigidbody>().AddForce(Vector3.up * 10.0f, ForceMode.Impulse);
            }

            else
                return;
        }

        /*else if(Input.GetKeyDown(KeyCode.A)){
            GetComponent<Rigidbody>().AddForce(Vector3.left * 3.0f, ForceMode.Impulse);
        }
>>>>>>> a9a913c7bf586566e2ecda92fdebdb5cbac4ed3a

        }
        else
            return;

        //else if(Input.GetKeyDown(KeyCode.A)){
        //    GetComponent<Rigidbody>().AddForce(Vector3.left * 3.0f, ForceMode.Impulse);
        //}

<<<<<<< HEAD
        //else if (Input.GetKeyDown(KeyCode.S))
        //{
        //    GetComponent<Rigidbody>().AddForce(Vector3.back * 3.0f, ForceMode.Impulse);
        //}

        //else if (Input.GetKeyDown(KeyCode.D))
        //{
        //    GetComponent<Rigidbody>().AddForce(Vector3.right * 3.0f, ForceMode.Impulse);
        //}

        //else if (Input.GetKeyDown(KeyCode.W))
        //{
        //    GetComponent<Rigidbody>().AddForce(Vector3.forward * 3.0f, ForceMode.Impulse);
        //}
=======
        else if (Input.GetKeyDown(KeyCode.W))
        {
            GetComponent<Rigidbody>().AddForce(Vector3.forward * 3.0f, ForceMode.Impulse);
        }*/
<<<<<<< Updated upstream
=======
>>>>>>> a9a913c7bf586566e2ecda92fdebdb5cbac4ed3a
>>>>>>> Stashed changes
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Land"))
            IsJumping = false;
    }
}
