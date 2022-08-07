using UnityEngine;

public class StartCutscene : MonoBehaviour
{
    public static bool IsCutsceneOn;
    [SerializeField] private Animator _anim;
    [SerializeField] private GameObject _cutsceneText;
    
    private void OnTriggerEnter2D(Collider2D colision) 
    {
        if(colision.CompareTag("Damageable"))
        {   PlayerMovement.speed = 0;
            IsCutsceneOn = true;
            _anim.SetBool("CutsceneOne", true);
            _cutsceneText.SetActive(true);
            Invoke(nameof(StopCutscene), 3f);
        }
    }

    public void StopCutscene()
    {
        PlayerMovement.speed = 1;
        IsCutsceneOn = false;
        _anim.SetBool("CutsceneOne", false);        
        _cutsceneText.SetActive(false);
        Destroy(gameObject);
    }
}
