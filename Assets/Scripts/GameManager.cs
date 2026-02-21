using UnityEngine;
using System;

public class GameManager : MonoBehaviour
{
    public static event Action OnDeath;
    public static event Action OnDamage;
    public static GameManager Instance;

    private void Awake()
    {
        if(Instance == null)
        {
            Instance = this;    
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void TriggerDeath()
    {
        OnDeath?.Invoke();
    }

    public void TriggerDamage()
    {
        OnDamage?.Invoke();
    }
}
