using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MathewMover : MonoBehaviour
{
    public enum TYPE
    {
        PLAYER,
        ENEMY
    }
    public TYPE type = TYPE.PLAYER;

    bool isMove = true;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (isMove)
        {
            Rigidbody2D rb = GetComponent<Rigidbody2D>();

            Vector2 force = new Vector2(-45, 0);

            rb.AddForce(force);

        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Enemy" && type == TYPE.PLAYER
            || collision.gameObject.tag == "Player" && type == TYPE.ENEMY)
        {
            isMove = false;
        }
    }
}
