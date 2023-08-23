using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sword : EnemyBullet
{
   
    [SerializeField] private float speed = 5f;
    [SerializeField] private GameObject player;
    [SerializeField] private Vector3 direction;
    // Start is called before the first frame update
    protected override void Start()
    {
        disappearTime = 3;
        player = GameObject.Find("Player");
        direction = (player.transform.position - transform.position).normalized;
        base.Start();
        transform.right=  GameObject.Find("Player").transform.position - transform.position ;
        transform.Rotate(0, 0, -45);
    }

    // Update is called once per frame
    void Update()
    {
          transform.position += direction * speed * Time.deltaTime;
              
        }
        
    
}
