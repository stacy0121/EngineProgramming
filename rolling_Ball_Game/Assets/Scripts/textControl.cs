using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class textControl : MonoBehaviour
{
    public Text ScriptTxt;   // text�� �Է��ϱ� ���� â ����
    public static int po;   // ���� �Է�(����)�ϱ� ���� ���
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()   // ���ڰ� �ٲ�� ������Ʈ�ؾ� ��
    {
        ScriptTxt.text = "Score: " + po.ToString() + "/15";   // text�� String�� ǥ�� ����. int�� String���� ��ȯ�ϴ� �Լ� ���
    }
}
