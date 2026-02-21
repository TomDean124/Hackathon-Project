using UnityEngine;
using TMPro; 
[RequireComponent(typeof(Health))]
public class HealthUI : MonoBehaviour
{
   public TextMeshProUGUI currentHealthText; 
   private Health _HealthComponent; 

   private void Awake()
   {
        _HealthComponent = GetComponent<Health>();
   }

    //Sets the players initial health to the text 
   private void Start()
   {
        currentHealthText.text = _HealthComponent.currentHealth.ToString();
   }

    //Subscribes the players UI to update once the player takes damage.
   private void OnEnable()
   {
        GameManager.OnDamage += UpdateHealthUI;
   }

    //Ensures the game doesn't crash by unsubscribing once the engine is closed. 
   private void OnDisable()
   {
        GameManager.OnDamage -= UpdateHealthUI;
   }

    //Converts the float to an int and then converts that to a string.  
    public void UpdateHealthUI()
    {
        currentHealthText.text = ((int)_HealthComponent.currentHealth).ToString(); 
    }
}
