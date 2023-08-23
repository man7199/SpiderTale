using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sniper : MonoBehaviour
{
    [SerializeField] private GameObject player;
    [SerializeField] private float RotationSpeed = 100f;
    [SerializeField] private float MovingSpeed = 0.5f;
    [SerializeField] private float distance = 5.0f;
    [SerializeField] private GameObject bullet;
    [SerializeField] private Camera camera;
    [SerializeField] private float disappearTime = 7f;
    // Start is called before the first frame update
    void Start()
    {
        AudioManager.Instance.Play("aim");
        camera = GameObject.Find("Main Camera").GetComponent<Camera>();
        camera.orthographicSize = 3;
        player = GameObject.Find("Player");
        bullet = Resources.Load<GameObject>("Prefab/SniperBullet");
        StartCoroutine(SelfDestroy());
    }

    // Update is called once per frame
    void Update()
    {
        camera.transform.position = new Vector3( transform.position.x,transform.position.y,-10);
        transform.RotateAround(player.transform.position, Vector3.back, RotationSpeed * Time.deltaTime);
        transform.rotation = Quaternion.identity;
        transform.position = Vector3.MoveTowards(transform.position, player.transform.position, MovingSpeed * Time.deltaTime);
        MovingSpeed += 0.001f;
    }
    private IEnumerator SelfDestroy()
    {
        yield return new WaitForSecondsRealtime(disappearTime);
        Destroy(gameObject);
    }
    private void OnDestroy()
    {
        AudioManager.Instance.Play("bulletdrop");
        Instantiate(bullet, transform.position, Quaternion.identity);
        camera.orthographicSize = 5;
        camera.transform.position = new Vector3(1, 0, -10);
    }
}
