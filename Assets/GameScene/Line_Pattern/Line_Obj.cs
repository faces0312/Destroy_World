 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Line_Obj : MonoBehaviour
{
    void OnEnable()
    {
        StartCoroutine(nameof(Dis_Line_Block));
    }

    private void Update()
    {
        transform.Translate(Vector3.right * Time.deltaTime * 4.5f);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Manager.manager.hp--;
            Manager.manager.Hit_Player();
        }
    }

    IEnumerator Dis_Line_Block()
    {
        yield return new WaitForSeconds(8f);
        gameObject.SetActive(false);
    }
}
