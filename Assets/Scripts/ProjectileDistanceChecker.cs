using UnityEngine;

public class ProjectileDistanceChecker : MonoBehaviour
{
    public float maxDistance; 
    public Vector3 Player; 

    public void Init(float m_maxDist, Vector3 m_playerTransform)
    {
        maxDistance = m_maxDist;
        Player = m_playerTransform; 
    }

    public void FixedUpdate()
    {
        float _sqrRadius = maxDistance * maxDistance; 
        float _sqrDistanceFromPlayer = (transform.position - Player).sqrMagnitude;

        if(_sqrDistanceFromPlayer > _sqrRadius)
        {
            Destroy(gameObject);
            Debug.Log("GameObject is getting deleted");  
        }
    }
}
