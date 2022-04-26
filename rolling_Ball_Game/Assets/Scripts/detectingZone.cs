using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class detectingZone : MonoBehaviour
{
    [SerializeField] enemyAI m_enemy = null;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            m_enemy.SelfTarget(other.transform);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            m_enemy.RemoveTarget();
        }
    }

        // Start is called before the first frame update
        void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
