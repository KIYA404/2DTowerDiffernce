using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonDate : MonoBehaviour
{
    [SerializeField] GameObject player;
    public void OnClick()
    {
        PlayerSpawn();
    }

    void PlayerSpawn()
    {
        float y = Random.Range(-1.7f, -2.5f);
        Instantiate(player, new Vector3(13, y, 0), transform.rotation);
    }
}
