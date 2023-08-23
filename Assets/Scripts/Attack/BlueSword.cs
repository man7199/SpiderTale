using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlueSword : EnemyBullet
{
    private bool slash = false;
    // Start is called before the first frame update
    protected override void Start()
    {
        base.Start();
        disappearTime = 3;
        Invoke("Slash", 2f);
    }

    // Update is called once per frame
    void Update()
    {
        if (!slash)
            transform.position += Vector3.left * 5.0f * Time.deltaTime;

        
        else
            transform.Rotate(0, 0, 1f * Time.deltaTime *400);

    }

    void Slash() {
        slash = !slash;
    }
}
