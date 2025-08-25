using UnityEngine;

public class UnitBlink : MonoBehaviour
{
    Animator anim;
    float blinkInterval = 3.0f; // ‰½•b‚²‚Æ‚É‚Ü‚Î‚½‚«‚·‚é‚©
    float timer;

    void Start()
    {
        anim = GetComponent<Animator>();
        timer = Random.Range(1f, blinkInterval); // ƒ‰ƒ“ƒ_ƒ€‚ÉŠJŽn
    }

    void Update()
    {
        timer -= Time.deltaTime;
        if (timer <= 0f)
        {
            anim.SetTrigger("Blink");
            timer = Random.Range(2f, 4f); // ŽŸ‚Ì‚Ü‚Î‚½‚«‚Ü‚Å‚ÌŠÔŠu
        }
    }
}
