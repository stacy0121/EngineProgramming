using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class timer : MonoBehaviour
{
    private Text text;
    private float Timer;

    // Start is called before the first frame update
    void Start()
    {
        text = this.gameObject.GetComponent<Text>();   // 시간 조작
    }

    // Update is called once per frame
    void Update()
    {
        if(counter.count < 1)   // 카운트를 다 세면 타이머 시작
        {
            if (run.xPos < 144)   // 도착할 때까지만 기록
                Timer += Time.deltaTime;   // 시간 싱크 맞춤
            //text.text = Timer.ToString();
            text.text = string.Format("{0:N2}", Timer);   // 소수점 아래 2자리
            //Debug.Log(Timer);
        }
        
    }
}
