using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RifleAtk1 : MonoBehaviour
{
    public GameObject Rifle;
    [SerializeField]  private Vector2 pos;
    private int Count = 0;
    [SerializeField] private int HorizontalRifle = 4;
    [SerializeField] private int VerticalRifle = 5;
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
        for (int i = 0; i < HorizontalRifle; i++)
        {
            Instantiate(Rifle, pos, Quaternion.identity);
            pos.y += 1.5f;            
            yield return new WaitForSeconds(0.1f);
        }
        pos = new Vector2(5, 7);
        for (int i = 0; i < VerticalRifle; i++)
        {
            Instantiate(Rifle, pos, Quaternion.Euler(0f, 0f, 90f));
            pos.x -= 2;
            yield return new WaitForSeconds(0.1f);
        }
        pos = new Vector2(-11, 2.5f);
        for (int i = 0; i < HorizontalRifle; i++)
        {
            Instantiate(Rifle, pos, Quaternion.Euler(0f, 180f, 0f));
            pos.y -= 1.5f;
            yield return new WaitForSeconds(0.1f);
        }
        pos = new Vector2(-3.5f, -6);
        for (int i = 0; i < VerticalRifle; i++)
        {
            Instantiate(Rifle, pos, Quaternion.Euler(0f, 0f, 270f));
            pos.x += 2;
            yield return new WaitForSeconds(0.1f);
        }


    }
    

}
