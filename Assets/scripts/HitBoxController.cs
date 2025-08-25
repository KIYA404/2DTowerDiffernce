using UnityEngine;

public class HitBoxController : MonoBehaviour
{
    public GameObject hitBox; // ← 子のHitBoxをInspectorで指定

    // 攻撃アニメ中の特定のフレームで呼び出す
    public void EnableHitBox()
    {
        hitBox.SetActive(true);
    }

    // 攻撃終了時に呼び出す
    public void DisableHitBox()
    {
        hitBox.SetActive(false);
    }
}
