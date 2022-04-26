using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class enemyAI : MonoBehaviour
{
    NavMeshAgent m_enemy = null;
    [SerializeField] Transform[] m_tfWayPoints = null;   // Bake한 이동할 장소를 배열로 저장. 이동한 위치 변수
    int m_count = 0;    // 움직인 횟수

    Transform m_target = null;   // 타겟 초기화
    // 적이 나를 따라오게
    public void SelfTarget(Transform p_target)   // 위험지역에 들어가면
    {
        CancelInvoke();          // 순찰 중지
        m_target = p_target;     // 타겟(m_target)을 나(p_target)로
    }

    public void RemoveTarget()   // 타겟이 위험 지역에서 나가면 다시 순찰
    {
        m_target = null;
        InvokeRepeating("MoveToNextWayPoint", 0f, 2f);
    }

    void MoveToNextWayPoint()
    {
        if (m_target == null)   // 타겟이 없을 때 실행
        {
            if (m_enemy.velocity == Vector3.zero)   // 멈추면 다음 지점으로
            {
                m_enemy.SetDestination(m_tfWayPoints[m_count++].position);

                if (m_count >= m_tfWayPoints.Length)
                {
                    m_count = 0;
                }
            }

        }

    }

    // Start is called before the first frame update
    void Start()
    {
        m_enemy = GetComponent<NavMeshAgent>();
        InvokeRepeating("MoveToNextWayPoint", 0f, 2f);   // 2초마다 반복
    }

    // Update is called once per frame
    void Update()
    {
        if (m_target != null)   // 타겟이 정해지면 쫓아가기
        {
            m_enemy.SetDestination(m_target.position);
        }
    }
}
