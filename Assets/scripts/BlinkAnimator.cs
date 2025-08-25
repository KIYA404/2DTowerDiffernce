using UnityEngine;

public class UnitBlink : MonoBehaviour
{
    Animator anim;
    float blinkInterval = 3.0f; // ���b���Ƃɂ܂΂������邩
    float timer;

    void Start()
    {
        anim = GetComponent<Animator>();
        timer = Random.Range(1f, blinkInterval); // �����_���ɊJ�n
    }

    void Update()
    {
        timer -= Time.deltaTime;
        if (timer <= 0f)
        {
            anim.SetTrigger("Blink");
            timer = Random.Range(2f, 4f); // ���̂܂΂����܂ł̊Ԋu
        }
    }
}
