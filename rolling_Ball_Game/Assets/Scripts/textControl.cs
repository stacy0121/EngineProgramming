using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class textControl : MonoBehaviour
{
    public Text ScriptTxt;   // text를 입력하기 위한 창 정의
    public static int po;   // 점수 입력(숫자)하기 위한 장소
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()   // 숫자가 바뀌면 업데이트해야 함
    {
        ScriptTxt.text = "Score: " + po.ToString() + "/15";   // text는 String만 표현 가능. int를 String으로 변환하는 함수 사용
    }
}
