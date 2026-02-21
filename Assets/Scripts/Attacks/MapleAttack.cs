using UnityEngine;

public class MapleAttack : AttackAction
{
    public override void Execute()
    {
        GameObject _projectile = Instantiate(projectileObject, playerObject.transform.position, playerObject.transform.rotation);
        SoundManager.Instance.PlayShootSound();
        ProjectileDistanceChecker _projectileDistChecker = _projectile.GetComponent<ProjectileDistanceChecker>();


        Rigidbody rb = _projectile.GetComponent<Rigidbody>();

        if(rb == null){
            Debug.Log("No Rigidbody found"); 
        }

        rb.linearVelocity = _projectile.transform.forward * projectileSpeed; 
        _projectileDistChecker.Init(maxDistFromPlayer, playerObject.transform.position); 
    }
}
