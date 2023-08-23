using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SniperCursor : MonoBehaviour
{
    public float timeToExplode = 3f;
    private float _timeElapsed;
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
      
        
    }

    private void Explode()
    {
        explosion.SetActive(true);
        GetComponent<SpriteRenderer>().enabled = false;
        Destroy(gameObject,1f/3f);
        Vector3 explosionPos = transform.position;
        Collider2D[] colliders = Physics2D.OverlapCircleAll(explosionPos, radius);
        foreach (Collider2D hit in colliders)
        {
            if (hit.GetComponent<PlayerControl>()) {
                GameObject.Find("PlayerHealth").GetComponent<PlayerHealth>().TakeDamage();
            }
        }
        }

}
