using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class head : MonoBehaviour
{
    public static float angleCam;
    float rotationX;
    public static float rotationY;

    public static float headY;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // 카메라의 회전
        float headX = Input.GetAxis("Mouse X");
        headY = Input.GetAxis("Mouse Y");   // 마우스값 초기화

        rotationX = rotationX + headX;
        rotationY = rotationY + headY;           // 회전값 가중

        transform.eulerAngles = new Vector3(-rotationY, rotationX, 0.0f);
    }
}
