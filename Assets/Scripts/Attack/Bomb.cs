using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bomb : MonoBehaviour
{
    public float timeToExplode = 3f;
    public float timeToFlash = 2.5f;
    private float _timeElapsed;
    private bool _isFlashing;
    private bool _isWhite = true;
    private GameObject explosion;
    [SerializeField] float radius;

    private void Awake()
    {
        explosion = GameObject.Find("Explosion");
        explosion.SetActive(false);
    }
    private void Update()
    {
        _timeElapsed += Time.deltaTime;

        if (_timeElapsed >= timeToExplode)
        {
            Explode();
        }
        else if (_timeElapsed >=  timeToFlash)
        {
            if (!_isFlashing)
            {
                _isFlashing = true;
                InvokeRepeating("ToggleSprite", 0f, 0.1f);
            }
        }
    }

    private void ToggleSprite()
    {
        if (_isWhite)
        {
            _isWhite = false;
            GetComponent<SpriteRenderer>().color = Color.red;
        }
        else {
            _isWhite = true;
            GetComponent<SpriteRenderer>().color = Color.white;
        }
    }

    private void Explode()
    {
        explosion.SetActive(true);
        GetComponent<SpriteRenderer>().enabled = false;
        Destroy(gameObject,1f/3f);
        Vector3 explosionPos = transform.position;
        Collider2D[] colliders = Physics2D.OverlapCircleAll(explosionPos, radius);
        AudioManager.Instance.Play("bomb");
        foreach (Collider2D hit in colliders)
        {
            if (hit.GetComponent<PlayerControl>()) {
                GameObject.Find("PlayerHealth").GetComponent<PlayerHealth>().TakeDamage();
            }
        }
        }

}
