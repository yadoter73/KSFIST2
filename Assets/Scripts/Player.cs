using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using static UnityEditor.Timeline.TimelinePlaybackControls;

public class Player : MonoBehaviour
{
    private Animator _animator;
    private Rigidbody _rb;
    [SerializeField] private float speed = 2f;
    [SerializeField] private float turningSpeed = 150f;
    public static float vertical, horizontal;
    double max_x = 9.63;
    double min_x = -1.3;
    public GameObject gameObject;
    public TMP_Text Coin_text;
    [SerializeField] private int coins = 0;

    void Start()
    {
        _animator = GetComponent<Animator>();
        _rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        float movementDirection = Input.GetAxis("Vertical");
        float verticalAxis = Input.GetAxis("Vertical");
        if (verticalAxis > 0)
        {
            vertical = verticalAxis * Time.deltaTime * speed;
            transform.Translate(0, 0, vertical);
        }
        horizontal = Input.GetAxis("Horizontal") * turningSpeed * Time.deltaTime;
        transform.Rotate(0, horizontal, 0);
        _animator.SetBool("Walk", movementDirection > 0);
        if (Input.GetKey(KeyCode.LeftShift))
        {
            speed = 4;
            _animator.SetBool("Run", true);
        }
        else
        {
            speed = 2f;
            _animator.SetBool("Run", false);
        }
        if (gameObject.transform.position.x > max_x)
        {
            SceneManager.LoadScene(1);
        }
        else if (gameObject.transform.position.x < min_x)
        {
            SceneManager.LoadScene(1);
        }

    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "die")
        {
            //StartCoroutine(GetComponent<SpikeRemove>().WaitForSeconds());
            SceneManager.LoadScene(1);
        }
    }
    public void AddCoin()
    {
        coins++;
        Coin_text.text = coins.ToString();
    }
    public void StartGame()
    {
 
        SceneManager.LoadScene(1);
    }
    private void OnTriggerStay(Collider collider)
    {
        if (collider.tag == "Finish" && coins == 5)
        {
            //StartCoroutine(GetComponent<SpikeRemove>().WaitForSeconds());
            SceneManager.LoadScene(0);
        }

    }

}
