using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AimRifleAtk1 : MonoBehaviour
{
    public GameObject Rifle;
    [SerializeField]  private Vector2 pos;
    private int Count = 0;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnObject());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private IEnumerator SpawnObject() {
       
            Instantiate(Rifle, pos, Quaternion.identity);
            pos.x = -7.0f;            
            yield return new WaitForSeconds(1.0f);
           Instantiate(Rifle, pos, Quaternion.identity);
          pos.y = -4.0f;
              yield return new WaitForSeconds(1.0f);
             Instantiate(Rifle, pos, Quaternion.identity);
            pos.x = 7.0f;
            yield return new WaitForSeconds(1.0f);
        Instantiate(Rifle, pos, Quaternion.identity);
    }
}
