using UnityEngine;

public class TriggerRock : MonoBehaviour
{
   [SerializeField] private Rigidbody2D _rigid;
   [SerializeField] private Animator _anim;

   private void Start() 
   {
        _rigid.GetComponent<Rigidbody2D>();
        _anim.GetComponent<Animator>();

        _rigid.simulated = false;
   }

   private void OnTriggerEnter2D(Collider2D collision) 
   {
        if(collision.isTrigger != true)
        {
            _rigid.simulated = true;
            _anim.SetTrigger("IsFall");
        }
   }
}