using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    public Rigidbody rb;

    [SerializeField]
    float speed = 20f;

    [SerializeField]
    float xSpeed = 10f;

    float horizontalInput;

    public float leftSide;
    public float rightSide;

    public GameManager gameManager;

    void FixedUpdate()
    {

        if (gameManager.isPlaying)
        {
            Move();
        }
    }

    public void Move()
    {
        horizontalInput = Input.GetAxisRaw("Horizontal");

        transform.Translate(Vector3.forward * Time.deltaTime * speed);

        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * xSpeed);

        Vector3 position = transform.position;

        if (transform.position.x < leftSide)
        {
            position.x = leftSide;
        }


        else if (transform.position.x > rightSide)
        {
            position.x = rightSide;
        }

        transform.position = position;
    }
}