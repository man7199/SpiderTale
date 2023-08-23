using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedAtk2 : MonoBehaviour
{
    public GameObject bomb;
    // Start is called before the first frame update
    void Start()
    {
        bomb = Resources.Load<GameObject>("Prefab/RedSword");
        Vector2 randomVector2 = new Vector2(-6.5f, -3f);
        Instantiate(bomb, randomVector2, Quaternion.identity).transform.Rotate(new Vector3(0,0,330));
        randomVector2.y += 1.5f;
        Instantiate(bomb, randomVector2, Quaternion.identity).transform.Rotate(new Vector3(0, 0, 330)); 
        randomVector2.y += 1.5f;
        Instantiate(bomb, randomVector2, Quaternion.identity).transform.Rotate(new Vector3(0, 0, 330));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    
    

}
