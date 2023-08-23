using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class RhythmAttack: MonoBehaviour
{
   
    [SerializeField] private float bpm;
    [SerializeField] private float secondPerBeat;
    [SerializeField] private float nextClickTime = 0f;
    [SerializeField] private float timeBetweenClicks;
    public Boss boss;
    [SerializeField] private TMP_Text text;
    private bool clicked = false;
    [SerializeField]  private float nextBeatTime;
    public Image Effect;
    private float pad;

    void Start()
    {
        if (bpm == 80f)
            AudioManager.Instance.Play("song1");
        else
            AudioManager.Instance.Play("song2");
        secondPerBeat = 60f / bpm;
        nextBeatTime = Time.timeSinceLevelLoad + secondPerBeat;
    }

    void Update()
    {



        if (Input.GetButtonDown("Fire1") && Time.timeSinceLevelLoad > nextClickTime)
        {
            nextClickTime = Time.timeSinceLevelLoad + timeBetweenClicks;
            float songPositionInBeats = Time.timeSinceLevelLoad / secondPerBeat;
            float beatOfThisClick = songPositionInBeats % 1;
            int damage = 0;
            if (beatOfThisClick < 0.2f || beatOfThisClick > 0.8f)
            {
                damage = 30;
                Show();
                text.text = "Perfect!";
            }
            else if (beatOfThisClick < 0.4f || beatOfThisClick > 0.6f)
            {
                damage = 25;
                Show();
                text.text = "Great!";
            }
            else
            {
                damage = 20;
                Show();
                text.text = "Cool!";
            }
            boss.TakeDamage(damage);
        }       
        if (Time.timeSinceLevelLoad > nextBeatTime) {            
            if (!clicked)
            {
                Invoke("Check", (secondPerBeat / 2f));
            }
            clicked = false;
            Effect.enabled = true;
            Invoke("UI", 0.1f);
            AudioManager.Instance.Play("beat");
            nextBeatTime += (60f / bpm);
        }
    }
    void Miss() {
        text.enabled = true;
        Invoke("Hide", 0.2f);
    }
    void Check() {
        if (!clicked)
        {
            Show();
            text.text = "Miss!";
        }
    }
    void Show() {
        clicked = true;
        text.enabled = true;
        Invoke("Hide", 0.2f);
    }
    void UI() {
        Effect.enabled = false;
    }
    void Hide()
    {
        text.enabled = false;
    }

}