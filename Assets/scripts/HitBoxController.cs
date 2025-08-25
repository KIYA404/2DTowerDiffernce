using UnityEngine;

public class HitBoxController : MonoBehaviour
{
    public GameObject hitBox; // �� �q��HitBox��Inspector�Ŏw��

    // �U���A�j�����̓���̃t���[���ŌĂяo��
    public void EnableHitBox()
    {
        hitBox.SetActive(true);
    }

    // �U���I�����ɌĂяo��
    public void DisableHitBox()
    {
        hitBox.SetActive(false);
    }
}
