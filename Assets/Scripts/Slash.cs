using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slash : MonoBehaviour
{
    public GameObject MainCam;
    public Transform cam1;
    public Transform cam2;
    public GameObject slash;
    // Start is called before the first frame update
    public float speed = 2.5f; // Speed of movement
    public float stopTime = 0.7f; // Time to stop movement
    private bool slashed = false;
    private float timer = 0.0f; // Timer to track duration of movement

    private void Start()
    {
        MainCam = GameObject.Find("Main Camera");
        MainCam.SetActive(false);
        slash.SetActive(true);
        AudioManager.Instance.Play("slash");
        Invoke("Endslash", 0.5f);
        StartCoroutine(SelfDestroy());
}
    void Update()
    {
        // Update timer
        timer += Time.deltaTime;

        // Move objects
        if (timer <= stopTime&& slashed)
        {
            cam1.transform.Translate(Vector3.left * speed * Time.deltaTime);
            cam2.transform.Translate(Vector3.right * speed * Time.deltaTime);
        }
    }
    private void Endslash() {
        slash.SetActive(false);
        slashed = true;
    }
    private IEnumerator SelfDestroy() {
        yield return new WaitForSecondsRealtime(10f);
        Destroy(gameObject);
    }
    private void OnDestroy()
    {
        MainCam.SetActive(true);
    }
}
