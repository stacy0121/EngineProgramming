using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour
{
    float rotationX;
    public static float distance;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // 나를 바라보는 적
        float headX = Input.GetAxis("Mouse X");
        rotationX = rotationX + headX;
        transform.eulerAngles = new Vector3(-90, rotationX + 180, 0.0f);

        // 적에게 가까이 다가가면 서브몹이 움직임 (게임 시작)
        distance = Vector3.Distance(bodyMovement.playerPosition, transform.position);
        Debug.Log("distance: " + distance);

        if (distance <= 15.0f)   // 적과의 거리가 15 이하일 때
        {
            transform.position = Vector3.MoveTowards(transform.position, bodyMovement.playerPosition, 0.01f);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "arrow")   // 화살이 적에 닿으면 적을 없애고 다른 위치에 자동 생성
        {
            enemyStamina_Text.stm1--;   // 체력 차감
            if (enemyStamina_Text.stm1 == 0)
            {
                Destroy(gameObject);
            }
        }
    }
}
