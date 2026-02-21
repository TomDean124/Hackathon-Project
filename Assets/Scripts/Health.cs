using UnityEngine;

public class Health : MonoBehaviour
{
    [Header("Health Variables")] 
    [Tooltip("By default all gameobjects have a default health of 100")]
    public float maxHealth = 100f;
    public float currentHealth;

    public static Health Instance; 


    private void Start()
    {
        currentHealth = maxHealth; 
    }

    [ContextMenu("Trigger Damage")]
    public void Test()
    {
        TakeDamage(15f);
    }

    public void TakeDamage(float _damage)
    {   
        currentHealth -= _damage; 
        if(currentHealth <= 0)
        {
            GameManager.Instance.TriggerDeath();
        }
        GameManager.Instance.TriggerDamage(); 
    }
}
