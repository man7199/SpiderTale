using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedSword : EnemyBullet
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
            transform.position += Vector3.right * 5.0f * Time.deltaTime;

        else if (transform.rotation.eulerAngles.z <= 160f && transform.rotation.eulerAngles.z>=150) { }

        else
            transform.Rotate(0, 0, 540f * Time.deltaTime );
    }

    void Slash()
    {
        slash = !slash;
    }
}
