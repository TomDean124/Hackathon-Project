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
    
    [Header("Attack Variables")]
    public float attackStrength; 
    public float attackRangeFromPlayer;
    public float cooldownTime; 
    [SerializeField] private float m_timer; 
    

    private float m_sqrdDistFromTarget; 
    private float m_sqrdAttackRangeFromPlayer; 


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void Start()
    {
        m_aiAgent = GetComponent<NavMeshAgent>(); 
        InitAgent();
    }

    void Update()
    {
        m_timer += Time.deltaTime; 
    }
    // Update is called once per frame
    void FixedUpdate()
    {
        SetTarget();
        Attack();
    }

    void Attack()
    {
        m_sqrdDistFromTarget = (transform.position - target.transform.position).sqrMagnitude;
        if(m_sqrdDistFromTarget <= m_sqrdAttackRangeFromPlayer)
        {
            if(CanAttack())
            {
                target.GetComponent<Health>().TakeDamage(15);
                m_timer = 0;
            }
        } 
    }

    void SetTarget()
    {
        m_aiAgent.SetDestination(target.transform.position);
    }

    private bool CanAttack()
    {
        if(m_timer >= cooldownTime)
        {
            return true;
        }
        else
        {
            return false; 
        }
    }

    void InitAgent()
    {
        m_aiAgent.speed = moveSpeed; 
        m_aiAgent.stoppingDistance = attackRangeFromPlayer; 
        m_sqrdAttackRangeFromPlayer = attackRangeFromPlayer * attackRangeFromPlayer; 
    }


    void OnTriggerEnter(Collider _collisionInfo)
    {
        Health _health = GetComponent<Health>();
        
        switch(_collisionInfo.gameObject.tag)
        {
            case "Projectile": 
                _health.TakeDamage(15f); //Switch to getting the damage from the projectile script. 
            break;
        }
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red; 
        Gizmos.DrawWireSphere(transform.position, attackRangeFromPlayer);
    }
}
