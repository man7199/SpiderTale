using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossAttack : MonoBehaviour
{
    [SerializeField] private GameObject[] bossAttack;
    // Start is called before the first frame update
    void Start()
    {
       
        StartCoroutine(Attack());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private IEnumerator Attack() {
        yield return new WaitForSeconds(1.0f);
        Instantiate(bossAttack[0]);
        yield return new WaitForSeconds(12.0f);
        Instantiate(bossAttack[0]);
        Instantiate(bossAttack[2]);
        yield return new WaitForSeconds(12.0f);
        dialogbox.Instance.Text("How about bombs", 3f);
        yield return new WaitForSeconds(3.0f);
        Instantiate(bossAttack[0]);
        Instantiate(bossAttack[1]);
        Instantiate(bossAttack[2]);
        yield return new WaitForSeconds(12.0f);
        dialogbox.Instance.Text("Sniper time", 3f);
        yield return new WaitForSeconds(3.0f);
        Instantiate(bossAttack[2]);        
        yield return new WaitForSeconds(2.0f);
        Instantiate(bossAttack[1]);
        Instantiate(bossAttack[3]);
        yield return new WaitForSeconds(10.0f);
        GameObject.Find("Enemy").GetComponent<Boss>().Death();
    }
}
