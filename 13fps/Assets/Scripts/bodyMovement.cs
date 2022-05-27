using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bodyMovement : MonoBehaviour
{
    public static GameObject diglett;
    public GameObject originalDig;

    float rotationX;
    float rotationY;

    // Start is called before the first frame update
    void Start()
    {
        //diglett = Instantiate(originalDig, new Vector3(5, 10, 5), Quaternion.identity);   // 회전 없음
        diglett = Instantiate(originalDig, new Vector3(Random.Range(-10f, 10f), 10, Random.Range(-10f, 10f)), Quaternion.identity);   // 복제품 생성 (원본 보존)
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 movement = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        transform.Translate(movement/50);

        // 몸이 회전
        float headX = Input.GetAxis("Mouse X");
        float headY = Input.GetAxis("Mouse Y");   // 마우스값 초기화

        rotationX = rotationX + headX;
        rotationY = rotationY + headY;           // 가중

        transform.eulerAngles = new Vector3(-rotationY, rotationX, 0.0f);
    }
}
