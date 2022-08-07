using UnityEngine;

public class FansSelfController : MonoBehaviour
{

    [SerializeField] private GameObject _fan;

    [SerializeField] private Animator _anim;

    [SerializeField] private float _time;
    [SerializeField] private float _currentTime;

    private void Start()
    {
        _anim.GetComponents<Animator>();
        _time = _currentTime;
        _fan.SetActive(true);
    }

    private void Update()
    {
        _time -= Time.deltaTime;

        if(_time < 3)
        {
            _fan.SetActive(false);            
            _anim.SetBool("IsFan", false);
        }

        if(_time < 0)
        {
            _time = 6;
        }

        if(_time > 3)
        {
            _anim.SetBool("IsFan", true);
            _fan.SetActive(true);
        }
    }
}
