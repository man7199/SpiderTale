using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AimRifle : MonoBehaviour
{
    [SerializeField] private GameObject bullet;
    [SerializeField] public int ShootTimes;
    [SerializeField] private int Count=1;
    [SerializeField] private GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        ShootTimes = 2;
        StartCoroutine(Fire());
        Destroy(gameObject, 9f);
        player = GameObject.Find("Player");
    }

     private IEnumerator Fire() {
        yield return new WaitForSeconds(1);
        AudioManager.Instance.Play("shot");
        Instantiate(bullet, transform.position,transform.rotation).transform.right = transform.right;
        Count++;
        
        yield return new WaitForSeconds(3);
        if (Count<=ShootTimes)        StartCoroutine(Fire());
    }
   

    // Update is called once per frame
    void Update()
    {
        transform.right =  transform.position - player.transform.position;
    }
}
