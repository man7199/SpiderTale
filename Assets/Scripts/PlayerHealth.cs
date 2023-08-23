using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    private bool isInvincible = false;
    private float InvincibleTime = 1.5f;
    public GameObject Prefab;
    private int Health = 5;
    private int MaxHealth = 3;
    public SpriteRenderer player;
    public GameObject lose;
    // Start is called before the first frame update
    void Start()
    {
        for (int x = 0; x < Health; x++) {
           GameObject a= Instantiate(Prefab, new Vector3(0,0,0),Quaternion.identity,this.GetComponent<Transform>());
            a.transform.localPosition = new Vector3(50 * x, 0, 0);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public void TakeDamage() {
        if (!isInvincible)
        {
            AudioManager.Instance.Play("damage");
            Health -= 1;
            if (Health == 0) {
                Lose();
            }
            Destroy(transform.GetChild(transform.childCount - 1).gameObject);
            isInvincible = true;
            StartCoroutine(Invincible(InvincibleTime));
            StartCoroutine(Blink(InvincibleTime));
        }

    }

    private IEnumerator Invincible(float waitTime)
    {        
            yield return new WaitForSeconds(waitTime);
        isInvincible = false;
    }
    private IEnumerator Blink(float time) {
        for (int x = 0; x < 10; x++) {
            yield return new WaitForSeconds(time/10);
            player.enabled = !player.enabled;
        }
    }
    private void Lose() {

        Time.timeScale = 0;
        lose.SetActive(true);
    }
}
