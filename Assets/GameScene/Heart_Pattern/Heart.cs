using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Heart : MonoBehaviour
{
    float speed;

    void OnEnable()
    {
        speed = 0f;
        StartCoroutine(nameof(Heart_Speed));
        StartCoroutine(nameof(Dis_Heart_Block));
    }

    private void Update()
    {
        transform.Translate(Vector3.right * Time.deltaTime * speed);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Heart")
        {
            Manager.manager.hp--;
            gameObject.SetActive(false);
        }
        if (collision.gameObject.tag == "Player")
        {
            gameObject.SetActive(false);
        }
    }

    IEnumerator Dis_Heart_Block()
    {
        yield return new WaitForSeconds(8f);
        gameObject.SetActive(false);
    }

    IEnumerator Heart_Speed()
    {
        speed = 0f;
        yield return new WaitForSeconds(0.3f);
        Manager.manager.heart_Pattern.Stop();
        Manager.manager.heart_Pattern.Play();
        speed = 15f;
    }
}
