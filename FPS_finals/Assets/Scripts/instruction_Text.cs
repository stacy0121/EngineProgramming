using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class instruction_Text : MonoBehaviour
{
    public Text text;

    void Start()
    {
        text.text = "";   // 처음엔 공백
    }

    void Update()
    {
        if (bodyMovement.finish == true)   // 게임이 종료되고
        {
            if (enemyStamina_Text.stm2 == 0)      // 체력이 0이었을 때
                text.text = "Failed!";
            else text.text = "Success!";   // 적을 다 죽였을 때
        }

    }
}
