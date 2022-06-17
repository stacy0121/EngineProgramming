using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class instruction2 : MonoBehaviour
{
    public Text text;
    // Start is called before the first frame update
    void Start()
    {
        
}

    // Update is called once per frame
    void Update()
    {
        if (enemy.distance > 15.0f) text.text = "귀신에게 가까이 다가가보자";
        else
        {
            if(enemyStamina_Text.stm1 == 0 && enemyStamina_Text.stm2 == 19)   // 서브 몹이 사라지고 보스가 등장했을 때
            {
                text.text = "어디로 간거지?";
            }
            else
            {
                text.text = "";
            }
        }
    }
}
