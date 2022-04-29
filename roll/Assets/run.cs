using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class run : MonoBehaviour
{
    public static float xPos;   // 카메라 관여

    // Start is called before the first frame update
    void Start()
    {
        xPos = 1;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.LeftArrow)|| Input.GetKeyDown(KeyCode.RightArrow))
            xPos+=7f;
        transform.position = new Vector3((int)xPos-4, 0, 0);   // 깊이 없음
    }
}
