using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharMOver : MonoBehaviour
{
    public float speed = 1.0f; 
    private Animator anim = null;
    private Rigidbody2D rb = null;

    public enum TYPE
    {
        PLAYER,
        ENEMY
    }
    public TYPE type = TYPE.PLAYER;
    Vector3 pos;

    bool isMove = true;

    float direction;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponentInChildren<Animator>();
        rb = GetComponent<Rigidbody2D>();
        switch (type)
        {
            case TYPE.PLAYER:

                direction = speed * -1;

                break;

            case TYPE.ENEMY:

                direction = speed;

                break;
        }
    }

    private void Update()
    {
        if (isMove == true)
        {
            transform.localPosition += new Vector3(direction, 0, 0) * Time.deltaTime;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Enemy" && type == TYPE.PLAYER
            || collision.gameObject.tag == "Player" && type == TYPE.ENEMY)
        {
            isMove = false;
            Hitpoint hitpoint = collision.gameObject.GetComponent<Hitpoint>();
            StartCoroutine(AttackAction(hitpoint));
            anim.SetTrigger("AttackTrigger");
        }
        else
        {
            isMove = true;
        }
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Enemy" && type == TYPE.PLAYER
            || collision.gameObject.tag == "Player" && type == TYPE.ENEMY)
        {
            anim.SetTrigger("StartWalking");
        }
    }


    IEnumerator AttackAction(Hitpoint hitpoint)
    {
        while(hitpoint.hp > 0)
        {
            yield return new WaitForSeconds(1f);
            hitpoint.Damage(1);
        }
    }
}
