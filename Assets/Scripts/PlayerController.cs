using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {
    // Moving, jumping.
    public int speed = 5;
    public int jumpForce = 500;
    Rigidbody2D rigidbody2D;
    
    // Start is called before the first frame update
    void Start() {
        rigidbody2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update() {
        Move();
        Jump();
    }

    void Move() {
        float movementForce = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
        transform.Translate(movementForce * Vector2.right);
    }

    void Jump() {
        if (Input.GetButtonDown("Jump")) {
            rigidbody2D.AddForce(Vector2.up * jumpForce);
        }
    }
}
