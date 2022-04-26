using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class obstacleAI : MonoBehaviour
{
    NavMeshAgent obstacle = null;
    [SerializeField] Transform[] m_tfWayPoints = null;   // Bake�� �̵��� ��Ҹ� �迭�� ����. �̵��� ��ġ ����
    int m_count = 0;    // ������ Ƚ��

    void MoveToNextWayPoint()
    {
        if (obstacle.velocity == Vector3.zero)   // ���߸� ���� ��������
        {
            obstacle.SetDestination(m_tfWayPoints[m_count++].position);

            if (m_count >= m_tfWayPoints.Length)
            {
                m_count = 0;
            }
        }

    }

    // Start is called before the first frame update
    void Start()
    {
        obstacle = GetComponent<NavMeshAgent>();
        InvokeRepeating("MoveToNextWayPoint", 0f, 2f);   // 2�ʸ��� �ݺ�
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
