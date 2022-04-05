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
        Vector3 movement = new Vector3(Input.GetAxis("Horizontal"), 0, 0);
        transform.Translate(movement / 25);
        Debug.Log(movement);

        if (Input.GetKeyDown(KeyCode.Space)){

            if (!IsJumping)
            {
                IsJumping = true;
                GetComponent<Rigidbody>().AddForce(Vector3.up * 7.0f, ForceMode.Impulse);   // Impulse - 질량의 영향을 받으면서 힘을 가하는 옵션
            }

            else
                return;
        }

        /*else if(Input.GetKeyDown(KeyCode.A)){
            GetComponent<Rigidbody>().AddForce(Vector3.left * 3.0f, ForceMode.Impulse);
        }

        else if (Input.GetKeyDown(KeyCode.S))
        {
            GetComponent<Rigidbody>().AddForce(Vector3.back * 3.0f, ForceMode.Impulse);
        }

        else if (Input.GetKeyDown(KeyCode.D))
        {
            GetComponent<Rigidbody>().AddForce(Vector3.right * 3.0f, ForceMode.Impulse);
        }

        else if (Input.GetKeyDown(KeyCode.W))
        {
            GetComponent<Rigidbody>().AddForce(Vector3.forward * 3.0f, ForceMode.Impulse);
        }*/
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Land"))
            IsJumping = false;
    }
}
