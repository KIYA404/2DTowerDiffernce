using UnityEngine;

public class UnitAnimator : MonoBehaviour
{
    Animator anim;

    void Start()
    {
        anim = GetComponent<Animator>();
    }

    public void PlayAttack()
    {
        anim.SetTrigger("AttackTrigger");
    }
}
