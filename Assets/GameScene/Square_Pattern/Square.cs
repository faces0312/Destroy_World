using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Square : MonoBehaviour
{
    public GameObject square;
    public GameObject square_obj;


    private void OnEnable()
    {
        StartCoroutine(nameof(Square_Ing));
    }

    IEnumerator Square_Ing()
    {
        yield return new WaitForSeconds(0.6f);
        square_obj.gameObject.SetActive(false);
        square.gameObject.SetActive(false);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Manager.manager.hp--;
            Manager.manager.Hit_Player();
        }
    }
}
