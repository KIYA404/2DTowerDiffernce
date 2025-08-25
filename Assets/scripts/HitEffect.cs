using UnityEngine;

public class AttackEffectTrigger : MonoBehaviour
{
    public ParticleSystem attackEffect;

    public void PlayEffect()
    {
        Debug.Log("PlayEffect called!");
        attackEffect.Play();
    }
}
