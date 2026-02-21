using UnityEngine;

public class MapleAttack : AttackAction
{
    public override void Execute()
    {
        GameObject _projectile = Instantiate(projectileObject, playerObject.transform.position, playerObject.transform.rotation);
        ProjectileDistanceChecker _projectileDistChecker = GetComponent<ProjectileDistanceChecker>();

        _projectileDistChecker.Init(maxDistFromPlayer, playerObject.transform.position); 

        Rigidbody rb = _projectile.GetComponent<Rigidbody>();

        if(rb == null){
            Debug.Log("No Rigidbody found"); 
        }

        rb.linearVelocity = _projectile.transform.forward * projectileSpeed; 
    }
}
