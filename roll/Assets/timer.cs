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
        Timer += Time.deltaTime;
        //text.text = Timer.ToString();
        text.text = string.Format("{0:N2}", Timer);
        Debug.Log(Timer);
    }
}
