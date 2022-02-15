using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdFly : MonoBehaviour
{

    [SerializeField] float velocity = 1;
    Rigidbody2D rigidbody2D;
    private bool alreadyTouched = false;

    // Start is called before the first frame update
    void Start()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();
        rigidbody2D.isKinematic = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0) && alreadyTouched == false)
        {
            Debug.Log("touched");
            rigidbody2D.isKinematic = false;
            alreadyTouched = true;
            FindObjectOfType<PipeSpawner>().StartSpawning();
        }

        if (Input.GetMouseButtonDown(0))
        {
            rigidbody2D.velocity = Vector2.up * velocity;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        FindObjectOfType<Manager>().gameOver();
        Time.timeScale = 0;
    }
}
