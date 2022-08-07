using UnityEngine;
using UnityEngine.UI;

public class HPBar : MonoBehaviour
{
    public Animator _animatorHit;

    [SerializeField] private GameObject _hero;
    [SerializeField] private GameObject _textLose;
    [SerializeField] private Health _health;


    [Header("HP Bar")]  
    [SerializeField] private float _numOfHearts;
    [SerializeField] private Image[] _hearts; 
    [SerializeField] private GameObject _hp;    
    
    [Header("Sound")]  
    [SerializeField] private AudioSource _hit;

    private void Start()
    {       
        _hit = _hit.GetComponent<AudioSource>();
        _animatorHit.GetComponent<Animator>();
    }

    private void Update()
    {  
        _numOfHearts = _health.currentHealth;
        IsAliveCheck();
        BarHP();

        if(_health.damageCheck == true)
        {
            _hit.Play();
            _animatorHit.SetTrigger("IsHit");
            _health.damageCheck = false;
        }
    }

    private void BarHP()
    {
        for (int i = 0; i < _hearts.Length; i++)
        {     
            if (i < _numOfHearts)
            {
                _hearts[i].enabled = true;
            } 
            else
            {
                _hearts[i].enabled = false;
            }
        }
    }

    private void IsAliveCheck()
    {
        if(_health.isAlive == false)
        {
            _hp.SetActive(false);   
            _textLose.SetActive(true);
            Destroy(_hero);
        }
    }
}
