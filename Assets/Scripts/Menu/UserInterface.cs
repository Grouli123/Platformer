using UnityEngine;
using UnityEngine.UI;
using Scriptable;

public class UserInterface : MonoBehaviour
{   
    [SerializeField] private Health _health;
    [SerializeField] private GameObject _loseScreen;
    [SerializeField] private GameObject _gamePanel;
    [SerializeField] private Text _textTime;
    
    [SerializeField] private IntegerVariable _timeScore;

    [SerializeField] private float _timeToEnd;

    public int endTime;
    public bool isLose;

    private void Start() 
    {
        isLose = false;    
        _health.GetComponent<Heal>();
    }

    private void Update()
    {        
        _timeToEnd -= Time.deltaTime;
        endTime = Mathf.RoundToInt(_timeToEnd);
        _textTime.text = endTime.ToString();

        if(_health.isAlive == false || _timeToEnd <= 0) 
        {
            _timeScore.SetValue(0);
            _gamePanel.SetActive(false);
            _loseScreen.SetActive(true);
            isLose = true;
            _timeToEnd = 0;
        }
    }
}