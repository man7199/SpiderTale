using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossAttack2 : MonoBehaviour
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
        yield return new WaitForSeconds(1f);
        dialogbox.Instance.Text("Welcome to level 2",3f);
        yield return new WaitForSeconds(3.0f);
        AudioManager.Instance.Play("katana");
        Instantiate(bossAttack[0]);
        Instantiate(bossAttack[1]);
        yield return new WaitForSeconds(3.0f);
        Instantiate(bossAttack[0]);
        Instantiate(bossAttack[1]);
        Instantiate(bossAttack[2]);
        yield return new WaitForSeconds(5.0f);
        dialogbox.Instance.Text("Watch out", 3f);
        yield return new WaitForSeconds(3.0f);
        Instantiate(bossAttack[3]);
        yield return new WaitForSeconds(2.0f);
        Instantiate(bossAttack[4]);
        yield return new WaitForSeconds(2.0f);
        Instantiate(bossAttack[3]);
        yield return new WaitForSeconds(2.0f);
        Instantiate(bossAttack[4]);
        yield return new WaitForSeconds(5.0f);

        yield return new WaitForSeconds(2.0f);
        Instantiate(bossAttack[5]);        
        yield return new WaitForSeconds(3.0f); 
        Instantiate(bossAttack[0]);
        Instantiate(bossAttack[1]);
        Instantiate(bossAttack[2]);
        yield return new WaitForSeconds(6.0f);        
        Instantiate(bossAttack[3]);
        yield return new WaitForSeconds(5.0f);
        Instantiate(bossAttack[4]);
        yield return new WaitForSeconds(8.0f);
        Instantiate(bossAttack[2]);
        yield return new WaitForSeconds(2f); 
        Instantiate(bossAttack[2]);
        yield return new WaitForSeconds(2f);
        Instantiate(bossAttack[2]);
        yield return new WaitForSeconds(2.0f);
        dialogbox.Instance.Text("How about this!", 3f);
        yield return new WaitForSeconds(2.0f);
        AudioManager.Instance.Play("katana");
        yield return new WaitForSeconds(1.0f);
        Instantiate(bossAttack[6]);
        Instantiate(bossAttack[3]);
        yield return new WaitForSeconds(2.0f);
        Instantiate(bossAttack[4]);
        yield return new WaitForSeconds(2.0f);
        Instantiate(bossAttack[3]);
        yield return new WaitForSeconds(2.0f);
        Instantiate(bossAttack[4]);
        yield return new WaitForSeconds(5.0f);
        GameObject.Find("Enemy").GetComponent<Boss>().Death();
    }
}
