using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rifle : MonoBehaviour
{
    [SerializeField] private GameObject bullet;
    [SerializeField] public int ShootTimes;
    [SerializeField] private int Count=1;
    // Start is called before the first frame update
    void Start()
    {
        ShootTimes = 2;
        StartCoroutine(Move());               
        Destroy(gameObject, 10f);
    }

     private IEnumerator Fire() {
        AudioManager.Instance.Play("shot");
        Instantiate(bullet, transform);
        Count++;
        
        yield return new WaitForSeconds(4);
        if (Count<=ShootTimes)        StartCoroutine(Fire());
    }
    private IEnumerator Move()
    {
        if (transform.position.x == 14)
        {
            while (transform.position.x >8.5f) {
                transform.position = new Vector3(transform.position.x-0.25f,transform.position.y,transform.position.z);
                yield return new WaitForSeconds(0.02f);
            }
        }
        else if (transform.position.y == 7) {
            transform.localScale = new Vector3(0.15f, 0.15f, 0.15f);
            while (transform.position.y > 4)
            {
                transform.position = new Vector3(transform.position.x, transform.position.y- 0.25f, transform.position.z);
                yield return new WaitForSeconds(0.02f);
            }
        }
        else if (transform.position.x == -11)
        {
            while (transform.position.x < -6.5)
            {
                transform.position = new Vector3(transform.position.x + 0.25f, transform.position.y, transform.position.z);
                yield return new WaitForSeconds(0.02f);
            }
        }
        else if (transform.position.y == -6)
        {
            transform.localScale = new Vector3(0.15f, 0.15f, 0.15f);
            while (transform.position.y < -4)
            {
                transform.position = new Vector3(transform.position.x , transform.position.y+ 0.25f, transform.position.z);
                yield return new WaitForSeconds(0.02f);
            }
        }
        StartCoroutine(Fire());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
