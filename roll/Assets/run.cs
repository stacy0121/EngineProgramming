using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class run : MonoBehaviour
{
    public static int xPos;   // 카메라 관여

    // Start is called before the first frame update
    void Start()
    {
        xPos = 1;
    }

    // Update is called once per frame
    void Update()
    {
        xPos++;
        transform.position = new Vector3(xPos, 0, 0);   // 깊이 없음
    }
}
