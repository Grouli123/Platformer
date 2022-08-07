using UnityEngine;

public class Heal : MonoBehaviour
{
    [SerializeField] private Health _health;
    [SerializeField] private GameObject _healPoint;
    [SerializeField] private BoxCollider2D _hpCollider;     
    [SerializeField] private AudioSource _eatSound;
    [SerializeField] private float _hp;

    private void Start() 
    {
        _hpCollider.GetComponent<BoxCollider2D>();
        _eatSound = _eatSound.GetComponent<AudioSource>();
    }   
    private void Update() 
    {
        if(_health.maxHealth != _health.currentHealth)
        {
            _hpCollider.enabled = true;
        }
        else
        {
            _hpCollider.enabled = false;
        }
    }
    private void OnTriggerEnter2D(Collider2D collision) 
    {
        if(collision.isTrigger != true)
        {
            if(collision.CompareTag("Damageable"))
            {       
                collision.gameObject.GetComponent<Health>().TakeHeal(_hp);                
                _eatSound.Play();
                Destroy(_healPoint);
            }
        }   
    }
}
