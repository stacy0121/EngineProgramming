using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bodyMovement : MonoBehaviour
{
    public static GameObject sub;
    public GameObject originalSub;

    public GameObject bullet;
    GameObject cloneBullet;

    float rotationX;
    float rotationY;

    // Start is called before the first frame update
    void Start()
    {
        sub = Instantiate(originalSub, new Vector3(Random.Range(-10f, 10f), 10, Random.Range(-10f, 10f)), Quaternion.identity);   // 복제품 생성 (원본 보존)
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 movement = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        transform.Translate(movement / 50);

        // 몸이 회전
        float headX = Input.GetAxis("Mouse X");
        float headY = Input.GetAxis("Mouse Y");   // 마우스값 초기화

        rotationX = rotationX + headX;
        rotationY = rotationY + headY;           // 가중

        transform.eulerAngles = new Vector3(-rotationY, rotationX, 0.0f);

        if (Input.GetMouseButtonUp(0))
        {
            cloneBullet = Instantiate(bullet, transform.position, Quaternion.identity);
            Vector3 screenPositon = new Vector3(Screen.width / 2, Screen.height / 2, 10f);   // 현재 화면에서 위치 업데이트 (정가운데) *왼쪽 아래가 (0, 0)*
            Vector3 aimPosition = Camera.main.ScreenToWorldPoint(screenPositon);   // 화면 좌표를 유니티 위치값으로 변환 *정가운데가 (0, 0). 크기도 다름*
            cloneBullet.GetComponent<Rigidbody>().AddForce(aimPosition * 100f);   // 위치*힘
        }
    }
}
