using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinAtk : MonoBehaviour
{
    public GameObject bomb;
    // Start is called before the first frame update
    void Start()
    {
        bomb = Resources.Load<GameObject>("Prefab/SpinSword");
        Instantiate(bomb, new Vector3(1,0,0), Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
