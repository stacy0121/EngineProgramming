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
                GetComponent<Rigidbody>().AddForce(Vector3.up * 7.0f, ForceMode.Impulse);   // Impulse - 질량의 영향을 받으면서 힘을 가하는 옵션
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
            textControl.po -= 1;   // 층돌시 text에서 충돌 횟수로 만든 변수 po를 textControl.cs에서 불러와서 계산
            Object.Destroy(collision.gameObject);
        }

        if (collision.gameObject.CompareTag("fallingLand"))   // 땅에 닿으면 떨어뜨리기
        {
            fallingLand.GetComponent<Rigidbody>().useGravity = true;
            Object.Destroy(gameObject, 5);
        }

        if (collision.gameObject.tag == "coin")   // 코인 먹기
        {
            Object.Destroy(collision.gameObject);
            textControl.po += 1;
        }
    }
}
