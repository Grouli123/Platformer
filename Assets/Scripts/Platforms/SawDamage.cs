using UnityEngine;

public class SawDamage : MonoBehaviour
{
    [SerializeField] private float _damage;
    
    private void OnTriggerEnter2D(Collider2D collision) 
    {
        if(collision.isTrigger != true)
        {
            if(collision.CompareTag("Damageable"))
            {
                collision.gameObject.GetComponent<Health>().TakeDamage(_damage);
            }
        }   
    }
}
