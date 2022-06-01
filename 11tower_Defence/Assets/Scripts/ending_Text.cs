using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ending_Text : MonoBehaviour
{
    private Text text;

    void Start()
    {
        text = this.gameObject.GetComponent<Text>();
        text.text = "";   // 처음엔 공백
    }

    void Update()
    {
        if(canonMovement.finish == true)   // 게임이 종료되고
        {
            if(stamina_Text.stm == 0)      // 체력이 0이었을 때
                text.text = "Failed!";
            else text.text = "Success!";   // 적을 다 죽였을 때
        }

    }
}
