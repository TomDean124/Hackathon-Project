using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(NavMeshAgent))]
public class EnemyAI : MonoBehaviour
{
    [Header("Components")]
    public GameObject target; 
    private NavMeshAgent m_aiAgent;

    [Header("Movement Variables")]
    public float moveSpeed; 


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void Start()
    {
        m_aiAgent = GetComponent<NavMeshAgent>(); 
    }

    // Update is called once per frame
    void Update()
    {
        SetTarget();
    }

    void SetTarget()
    {
        m_aiAgent.SetDestination(target.transform.position);
    }
}
