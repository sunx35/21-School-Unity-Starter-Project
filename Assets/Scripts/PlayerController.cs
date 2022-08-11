using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {
    // Moving, jumping.
    public int speed = 1;
    
    // Start is called before the first frame update
    void Start() {
    }

    // Update is called once per frame
    void Update() {
        Move();
    }

    void Move() {
        float movementForce = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
        transform.Translate(movementForce * Vector2.right);
        Debug.Log("movementForce: " + movementForce);
        Debug.Log("Input Horizontal: " + Input.GetAxis("Horizontal"));
    }
}
