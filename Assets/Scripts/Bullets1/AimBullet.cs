using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AimBullet : EnemyBullet
{
   
    [SerializeField] private float speed = 2.5f;
    [SerializeField] private GameObject player;
    [SerializeField] private Vector3 direction;
    // Start is called before the first frame update
    protected override void Start()
    {
        disappearTime = 6;
        player = GameObject.Find("Player");
        direction = (player.transform.position - transform.position).normalized;
        base.Start();
    }

    // Update is called once per frame
    void Update()
    {
          transform.position += direction * speed * Time.deltaTime;
              
        }
        
    
}
