using UnityEngine;

public class ImpactSplatManager : MonoBehaviour
{
    public GameObject decalPrefab; 
    public float offset; 
    public float _rayLength;



 void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Environment")
        {
            ContactPoint contact = collision.contacts[0];

            Vector3 spawnPosition = contact.point + contact.normal * offset;

            Quaternion rotation = Quaternion.LookRotation(-contact.normal);

            Instantiate(decalPrefab, spawnPosition, rotation);

            Destroy(gameObject);
        }
    }
}
