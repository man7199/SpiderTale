using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    
    [SerializeField] private new Rigidbody2D rigidbody2D;
    [SerializeField] private float speed;
    private bool IsStopTime = false;
    private bool UsedStopTime = false;
    public int Stage1;
    public bool IsCanMove { get; private set; }
    public GameObject symbol;

    private Vector2 input;
     float xMin = -3.77f;
     float xMax = 5.76f;
    float yMin = -2.42f;
     float yMax = 2.42f;

    private void Start()
    {
        EnablePlayerMovement();
        speed = 200;
    }
    private void Update()
    {
        CalculatePlayerInput();
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if(!UsedStopTime)
            StopTime();
        }
        if (IsCanMove)
            MovePlayer();
        else
            MovePlayerStopTime();
    }

    private void FixedUpdate()
    {
        
    }

    
    public void EnablePlayerMovement()
    {
        IsCanMove = true;
    }


    private void MovePlayer()
    {
        rigidbody2D.velocity = input * speed * Time.fixedDeltaTime;
        float xPosition = Mathf.Clamp(rigidbody2D.position.x, xMin, xMax);
        float yPosition = Mathf.Clamp(rigidbody2D.position.y, yMin, yMax);
        rigidbody2D.position = new Vector2(xPosition, yPosition);
    }
    private void MovePlayerStopTime()
    {
        input = input * 0.02f;
        float xPosition = Mathf.Clamp(transform.position.x+input.x, xMin, xMax);
        float yPosition = Mathf.Clamp(transform.position.y+input.y, yMin, yMax);
        transform.position = new Vector2(xPosition, yPosition);
    }

    private void CalculatePlayerInput()
    {
        input = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
    }
    public Vector2 GetPlayerVelocity()
    {
        return rigidbody2D.velocity;
    }

    public void SetPlayerPosition(Vector2 newPosition)
    {
        transform.position = newPosition;
    }

    public void DisablePlayerMovement()
    {
        rigidbody2D.velocity = Vector2.zero;
        IsCanMove = false;
    }
    private void StopTime() {
        //foreach (GameObject obj in Object.FindObjectsOfType<GameObject>())
        //{
        //    if (obj != gameObject && obj.layer == 3)
        //    {
        //        obj.GetComponent<MonoBehaviour>().enabled = false;
        //    }
        //}
        if (!IsStopTime)
        {
            Time.timeScale = 0;
            IsStopTime = true;
            UsedStopTime = true;
            AudioManager.Instance.Play("time");
            symbol.SetActive(false);
            if (Stage1 == 1)
            AudioManager.Instance.Stop("song1");
            else
            AudioManager.Instance.Stop("song2");
            StartCoroutine(Resume());
            IsCanMove = false;
        }
        else {
            Time.timeScale = 1;
            IsStopTime = false;
            if (Stage1 == 1)
                AudioManager.Instance.Play("song1");
            else
                AudioManager.Instance.Play("song2");
            IsCanMove = true;
        }
    }
    private IEnumerator Resume() {
        yield return new WaitForSecondsRealtime(3f);
        StopTime();
    }
}
/*
  public float speed = 0.5f;
  public float xMin = -5f;
  public float xMax = 5f;
  public float yMin = -5f;
  public float yMax = 5f;

  void Update()
  {
      float horizontalInput = Input.GetAxis("Horizontal");
      float verticalInput = Input.GetAxis("Vertical");

      Vector3 position = transform.position;
      position.x += horizontalInput * speed * Time.deltaTime;
      position.y += verticalInput * speed * Time.deltaTime;

      position.x = Mathf.Clamp(position.x, xMin, xMax);
      position.y = Mathf.Clamp(position.y, yMin, yMax);

      transform.position = position;
  }
}
*/