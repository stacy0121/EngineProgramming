using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour
{
    float rotationX;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // 적에게 가까이 다가가면 서브몹이 움직임 (게임 시작)
        float distance = Vector3.Distance(bodyMovement.playerPosition, transform.position);
        Debug.Log("distance: " + distance);

        float headX = Input.GetAxis("Mouse X");
        rotationX = rotationX + headX;
        transform.eulerAngles = new Vector3(-90, rotationX+180, 0.0f);
        //transform.rotation = Quaternion.LookRotation(bodyMovement.playerPosition - transform.position).normalized;   //*******************************************     
        if (distance <= 15.0f)
        {
            transform.position = Vector3.MoveTowards(transform.position, bodyMovement.playerPosition, 0.05f);
            //Debug.Log(Vector3.Distance(bodyMovement.playerTransform.transform.position, transform.position));
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
