using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyAI : MonoBehaviour
{
    NavMeshAgent m_enemy = null;
    [SerializeField] Transform[] m_tfWayPoints = null;   // Bake한 이동할 장소를 배열로 저장. 이동한 위치 변수
    int m_count = 0;    // 움직인 횟수

    void MoveToNextWayPoint()   // 다음 지점으로
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
        InvokeRepeating("MoveToNextWayPoint", 0f, 2f);   // 2초에 한 번씩 반복
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
