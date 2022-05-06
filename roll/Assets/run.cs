using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class run : MonoBehaviour
{
    public static float xPos;   // 카메라 관여

    // Start is called before the first frame update
    void Start()
    {
        xPos = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (counter.count < 1){   // 카운트를 다 세면 출발
            // 왼쪽, 오른쪽 화살표 키를 연달아 눌러서 달리기
            if (Input.GetKeyDown(KeyCode.LeftArrow) || Input.GetKeyDown(KeyCode.RightArrow))
                xPos += 6f;   // 6만큼 감
            transform.position = new Vector3((int)xPos, 0, 0);   // 깊이 없음
            if (xPos > 144)
                xPos = 149;
        }
    }
}
