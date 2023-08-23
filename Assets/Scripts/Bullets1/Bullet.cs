using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : EnemyBullet
{
    [SerializeField] private float speed = 2.5f;
    enum Direction
    {
        Right, Left, Up, Down
    }
    [SerializeField] private Direction direction;
    // Start is called before the first frame update
    protected override void Start()
    {
        disappearTime = 10;
        base.Start();
        if (transform.parent.position.x == 8.5)
        {
            direction = Direction.Left;
        }
        else if (transform.parent.position.y == 4) {
            direction = Direction.Down;
        }
        else if (transform.parent.position.x == -6.5)
        {
            direction = Direction.Right;
        }
        else if (transform.parent.position.y == -4)
        {
            direction = Direction.Up;
        }
    }

    // Update is called once per frame
    void Update()
    {
        switch (direction)
        {
            case Direction.Up:
                transform.position += Vector3.up * speed * Time.deltaTime;
                break;
            case Direction.Down:
                transform.position += Vector3.down * speed * Time.deltaTime;
                break;
            case Direction.Left:
                transform.position += Vector3.left * speed * Time.deltaTime;
                break;
            case Direction.Right:
                transform.position += Vector3.right * speed * Time.deltaTime;
                break;
            
        }
        
    }
}
