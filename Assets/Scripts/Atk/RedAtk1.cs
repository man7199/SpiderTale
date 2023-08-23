using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedAtk1 : MonoBehaviour
{
    public GameObject bomb;
    public float xMin = -8f;
    public float xMax = -6.5f;
    public float yMin = -1.7f;
    public float yMax = -0.75f;
    // Start is called before the first frame update
    void Start()
    {
        bomb = Resources.Load<GameObject>("Prefab/RedSword");
        Vector2 randomVector2 = new Vector2(Random.Range(xMin, xMax), Random.Range(yMin, yMax));
        Instantiate(bomb, randomVector2, Quaternion.identity).transform.Rotate(new Vector3(0,0,330));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    
    

}
