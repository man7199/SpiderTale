using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwordAtk1 : MonoBehaviour
{
    public GameObject bomb;
    public float xMin = -5f;
    public float xMax = 7f;
    public float yMin = 5f;
    public float yMax = 5f;
    // Start is called before the first frame update
    void Start()
    {
        bomb = Resources.Load<GameObject>("Prefab/Sword");
        Vector2 randomVector2 = new Vector2(Random.Range(xMin, xMax), Random.Range(yMin, yMax));
        Instantiate(bomb, randomVector2, Quaternion.identity).transform.Rotate(new Vector3(0,0,150));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    
    

}
