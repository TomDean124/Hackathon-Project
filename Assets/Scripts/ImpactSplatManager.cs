using UnityEngine;

public class ImpactSplatManager : MonoBehaviour
{
    public GameObject collisionPrefab; 
    public float offset; 

    private void OnTriggerEnter(Collision collision)
    {
        ContactPoint _intersectionPoint = collision.contacts[0];
        GameObject _splatObject = Instantiate(collisionPrefab, _intersectionPoint.point + (_intersectionPoint.normal * offset), Quaternion.LookRotation(_intersectionPoint.normal));
    }
}
