using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class endTextControl : MonoBehaviour
{
    public Text ScriptTxt2;

    // Start is called before the first frame update
    void Start()
    {
        ScriptTxt2.text = "";   // ó���� ����
    }

    // Update is called once per frame
    void Update()
    {
        if (player.finish == true)   // ������ ������ ����
        {
            ScriptTxt2.text = "       The End!\nYour Score: " + textControl.po.ToString() + "/15";
        }
    }
}
