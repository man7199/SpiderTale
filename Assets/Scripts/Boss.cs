using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
public class Boss : MonoBehaviour
{
    public GameObject Wined;
    [SerializeField] private float MaxHP = 1000;
    [SerializeField] private float HP;
    [SerializeField] protected TMP_Text hpText;
    [SerializeField] protected Image hpImage;
    [SerializeField] private int stage = 1;
    // Start is called before the first frame update
    void Start()
    {
        HP = MaxHP;
    }

    // Update is called once per frame
    void Update()
    {
        //if (Input.GetKeyDown(KeyCode.Escape)) {
        //    Death();
        //}
            hpText.SetText("HP:" + HP + "/" + MaxHP);
        hpImage.fillAmount = HP / MaxHP;
    }
    public void TakeDamage(int x) {
        HP -= x;
        if (HP <= 0) {
            Death();
        }
    }
    public void Death() {

        dialogbox.Instance.Text("You have won.", 100f);
        Time.timeScale = 0;
        Wined.SetActive(true);
    }
}
