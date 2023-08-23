using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class dialogbox : MonoBehaviour
{
    public static dialogbox Instance;

    private TMP_Text text;
    // Start is called before the first frame update
    void Start()
    {
        Instance = this;
        text = GameObject.Find("dialog").GetComponent<TMP_Text>();
        gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Text(string x, float y) {
        gameObject.SetActive(true);
        text.SetText(x);
        StartCoroutine(Disappear(y));
    }

    IEnumerator Disappear(float y) {
        yield return new WaitForSeconds(y);
        gameObject.SetActive(false);
    }
}
