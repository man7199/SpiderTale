using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlueAtk2 : MonoBehaviour
{
    public GameObject bomb;
    // Start is called before the first frame update
    void Start()
    {
        bomb = Resources.Load<GameObject>("Prefab/BlueSword");
        Vector2 randomVector2 = new Vector2(10f, 2f);
        Instantiate(bomb, randomVector2, Quaternion.identity).transform.Rotate(new Vector3(0,0,150));
        randomVector2.y -= 1.5f;
        Instantiate(bomb, randomVector2, Quaternion.identity).transform.Rotate(new Vector3(0, 0, 150));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    
    

}
