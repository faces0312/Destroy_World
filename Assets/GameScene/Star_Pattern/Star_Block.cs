using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Star_Block : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Manager.manager.hp--;
            Manager.manager.Hit_Player();
        }
    }
}
