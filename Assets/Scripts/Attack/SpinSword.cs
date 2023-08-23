using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinSword : EnemyBullet
{
    private float SpinningSpeed = 0.05f;
    private float time = 0f;
    private Collider2D self;
    // Start is called before the first frame update
    protected private void Start()
    {
        disappearTime = 28;
        base.Start();
        self = GetComponent<Collider2D>();
        Invoke("attack", 2f);
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        float t = time / 20f;
        float value = Mathf.Lerp(SpinningSpeed, 0.2f, t);
        transform.Rotate(0, 0, SpinningSpeed * Time.deltaTime*400 );
    }
    private void attack() {
        self.enabled = true;
        
    }
}
