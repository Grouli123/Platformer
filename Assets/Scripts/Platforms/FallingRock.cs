using UnityEngine;

public class FallingRock : MonoBehaviour
{
    [SerializeField] private BoxCollider2D _rockBox;
    [SerializeField] private float _damage;
    
    [SerializeField] private GameObject _rock;

    private void Start()
    {
        _rockBox.GetComponent<BoxCollider2D>();
    }

    private void OnTriggerEnter2D(Collider2D collision) 
    {
        if(collision.isTrigger != true)
        {
            if(collision.CompareTag("Damageable"))
            {
                collision.gameObject.GetComponent<Health>().TakeDamage(_damage);
                Destroy(_rock, 0.1f);
            }
        }   
    }

    private void IdleRock()
    {
        _rockBox.enabled = false;
    }
    
    private void FallRock()
    {
        _rockBox.enabled = true;
    }
}
