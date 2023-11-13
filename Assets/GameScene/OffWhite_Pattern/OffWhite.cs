using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OffWhite : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Manager.manager.Hit_Player();
            Manager.manager.hp--;
        }
    }
}
