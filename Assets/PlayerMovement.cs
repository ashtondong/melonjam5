using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody2D body;
    public float speed = 5;
    public GameEnd gameEnd;

    // Start is called before the first frame update
    void Start() {
    }

    // Update is called once per frame
    void Update() {
        float xInput = Input.GetAxis("Horizontal");
        float yInput = Input.GetAxis("Vertical");
        Vector2 direction = new Vector2(xInput, yInput);

        body.velocity = direction * speed;
    }

    // End game when player hits obstacle
    void OnCollisionEnter2D(Collision2D collision) {
        if (collision.gameObject.CompareTag("Obstacle")) {
            gameEnd.gameOver();
        }
    }
}