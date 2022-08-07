using UnityEngine;

public class Tramplin : MonoBehaviour
{
    [SerializeField] private Animator _anim;
    [SerializeField] private GameObject _tramplin;
    
    private void Start()
    {
        _anim.GetComponent<Animator>();
        _tramplin.SetActive(false);
    }

    private void OnTriggerEnter2D(Collider2D colision) 
    {
       if(colision.CompareTag("Damageable"))
       {
           _tramplin.SetActive(true);
           _anim.SetTrigger("IsJump");
       }
    }
}
