using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Big_Obj : MonoBehaviour
{
    private void OnEnable()
    {
        gameObject.transform.localScale = new Vector3(2, 2);
    }
    private void Update()
    {
        transform.Translate(Vector3.right * Time.deltaTime * 5.5f);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Manager.manager.hp--;
            Manager.manager.Hit_Player();
        }

        if(collision.gameObject.tag == "Big")
        {
            Manager.manager.big_Pattern.Stop();
            Manager.manager.big_Pattern.Play();
            StartCoroutine(nameof(Big_Ing));
        }
    }

    IEnumerator Big_Ing()
    {
        for (float i = 2; i <= 10; i += 0.5f)
        {
            gameObject.transform.localScale = new Vector3(i, i);
            yield return new WaitForSeconds(0.01f);
        }
    }
}
