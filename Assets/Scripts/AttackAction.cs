using UnityEngine;

public abstract class AttackAction : MonoBehaviour
{
    //Sets the default damage to 10, can be changed by implimentors for different damage values
    protected float damage = 10f; 
    protected float projectileSpeed = 10f;
    protected float maxDistFromPlayer = 100f; 
    protected float cooldownTime = 0.5f; 
    public GameObject projectileObject; 
    public GameObject playerObject;
    public KeyCode keyRequired; 

    // * Methods * //
    public abstract void Execute();
}
