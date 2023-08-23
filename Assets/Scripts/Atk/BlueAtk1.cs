using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlueAtk1 : MonoBehaviour
{
    public GameObject bomb;
    public float xMin = 8.5f;
    public float xMax = 10f;
    public float yMin = 0.5f;
    public float yMax = 2f;
    // Start is called before the first frame update
    void Start()
    {
        bomb = Resources.Load<GameObject>("Prefab/BlueSword");
        Vector2 randomVector2 = new Vector2(Random.Range(xMin, xMax), Random.Range(yMin, yMax));
        Instantiate(bomb, randomVector2, Quaternion.identity).transform.Rotate(new Vector3(0,0,150));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    
    

}
