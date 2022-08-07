using UnityEngine;

public class SpikeAttack : MonoBehaviour
{
    [SerializeField] private BoxCollider2D _box;
    [SerializeField] private float _damage;

    private void Start()
    {
        _box.GetComponent<BoxCollider2D>();        
    }

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

    private void IdleSpike()
    {
        _box.enabled = false;
    }
    
    private void AttackSpike()
    {
        _box.enabled = true;
    }
}
