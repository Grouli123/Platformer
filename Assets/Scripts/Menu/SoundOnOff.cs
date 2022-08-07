using UnityEngine;
using UnityEngine.UI;

public class SoundOnOff : MonoBehaviour
{
    [SerializeField] private Sprite _spriteSoundOff;
    [SerializeField] private Sprite _spriteSoundOn;
    [SerializeField] private AudioSource _backgroundSound;
    private Image _soundOn;
    private bool _change;

    private void Start()
    {
        _soundOn = GetComponent<Image>();
        _change = true;
    }

    public void ChangeSprite()
    {
        if (_change)
        {
            _change = false;
            _soundOn.sprite = _spriteSoundOff;
            _backgroundSound.Pause();
        }
        else
        {
            _change = true;
            _soundOn.sprite = _spriteSoundOn;
            _backgroundSound.Play();
        }
    }
}
