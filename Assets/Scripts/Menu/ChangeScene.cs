using UnityEngine;
using Scriptable;

public class ChangeScene : MonoBehaviour
{    
    [SerializeField] private GameObject _finishScene;
    [SerializeField] private UserInterface _userInterface;
    [SerializeField] private GameObject _gameObjectsScene;
    [SerializeField] private AudioSource _finishSound;

    [SerializeField] private IntegerVariable _sumScore;
    [SerializeField] private IntegerVariable _timeScore;
    [SerializeField] private IntegerVariable _bonusesScore;

    private int _summScore;
    
    private void Start()
    {
        _userInterface.GetComponent<UserInterface>();
        Time.timeScale = 1f;
        _finishScene.SetActive(false);
        _gameObjectsScene.SetActive(true); 
        _timeScore.SetValue(0);
        _bonusesScore.SetValue(0);
    }

    private void OnTriggerEnter2D(Collider2D collision) 
    {
        if(collision.CompareTag("NewLvl"))
        {
            _finishSound.Play();
            _finishScene.SetActive(true);
            _gameObjectsScene.SetActive(false);   

            
            if (_userInterface.isLose == true)
            {
                _timeScore.SetValue(0);
                _bonusesScore.SetValue(0);
            }
            else
            {
                _timeScore.ApplyChange(_userInterface.endTime);
                _summScore = _timeScore.GetValue() + _bonusesScore.GetValue();
                _sumScore.SetValue(_summScore);
            }

            Time.timeScale = 0f;
        }
    }
}