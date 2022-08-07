using UnityEngine;
public class Health : MonoBehaviour
{
    public float maxHealth;   
    public float currentHealth;
    public bool isAlive;
    public bool damageCheck;

    private void Awake()
    {
        currentHealth = maxHealth;
        isAlive = true;
    }

    public void TakeDamage(float damage)
    {       
        currentHealth -= damage;
        damageCheck = true;        
        CheckIsAlive();     
    }

    private void CheckIsAlive()
    {
        if(currentHealth > 0)
        {
            isAlive = true;
        }
        else
        {
            isAlive = false; 
            Destroy(gameObject);                      
        }
    }    

    public void TakeHeal(float hp)
    {
        currentHealth += hp;
    }
}
