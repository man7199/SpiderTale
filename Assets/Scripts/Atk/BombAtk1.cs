using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombAtk1 : MonoBehaviour
{
    public GameObject bomb;
    public float xMin = -4f;
    public float xMax = 6f;
    public float yMin = -2.5f;
    public float yMax = 2.5f;
    // Start is called before the first frame update
    void Start()
    {
        bomb = Resources.Load<GameObject>("Prefab/bomb");
        Vector2 randomVector2 = new Vector2(Random.Range(xMin, xMax), Random.Range(yMin, yMax));
        Instantiate(bomb, randomVector2, Quaternion.identity);
        randomVector2 = new Vector2(Random.Range(xMin, xMax), Random.Range(yMin, yMax));
        Instantiate(bomb, randomVector2, Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    
    

}
