using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBullet : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] protected float disappearTime=3;
    [SerializeField] private PlayerHealth playerHealth;
    
    protected virtual void Start()
    {
        playerHealth = GameObject.Find("PlayerHealth").GetComponent<PlayerHealth>();
        Destroy(gameObject, disappearTime);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.GetComponent<PlayerControl>()) {
            playerHealth.TakeDamage();
        }
    }
}
