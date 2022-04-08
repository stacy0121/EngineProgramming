using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyAI : MonoBehaviour
{
    NavMeshAgent m_enemy = null;
    [SerializeField] Transform[] m_tfWayPoints = null;   // Bake�� �̵��� ��Ҹ� �迭�� ����. �̵��� ��ġ ����
    int m_count = 0;    // ������ Ƚ��

    void MoveToNextWayPoint()   // ���� ��������
    {
        if(m_enemy.velocity == Vector3.zero)
        {
            m_enemy.SetDestination(m_tfWayPoints[m_count++].position);

            if(m_count >= m_tfWayPoints.Length)
            {
                m_count = 0;
            }
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        m_enemy = GetComponent<NavMeshAgent>();
        InvokeRepeating("MoveToNextWayPoint", 0f, 2f);   // 2�ʿ� �� ���� �ݺ�
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
