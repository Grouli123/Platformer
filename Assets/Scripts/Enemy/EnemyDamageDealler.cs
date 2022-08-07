using UnityEngine;

public class EnemyDamageDealler : MonoBehaviour
{
    [SerializeField] private float _damage;

    private void OnTriggerEnter2D(Collider2D colision) 
    {
        Vector2 impulse = new Vector2(0, 1.5f);
        if(colision.CompareTag("Damageable"))
        {
            colision.gameObject.GetComponent<Health>().TakeDamage(_damage);
            GameObject obj = GameObject.Find("CharacterFrog");
            obj.GetComponent<Rigidbody2D>().AddForce(impulse, ForceMode2D.Impulse);
        }
    }
}
