using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turn_Obj : MonoBehaviour
{

    private void OnEnable()
    {
        StartCoroutine(nameof(Dis_Turn_Block));
    }
    void Update()
    {
        transform.Translate(Vector3.right * Time.deltaTime * 4);
    }

    IEnumerator Dis_Turn_Block()
    {
        yield return new WaitForSeconds(8f);
        gameObject.SetActive(false);
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
