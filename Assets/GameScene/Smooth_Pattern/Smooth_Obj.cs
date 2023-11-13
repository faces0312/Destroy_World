using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Smooth_Obj : MonoBehaviour
{
    float speed;

    void OnEnable()
    {
        speed = 3.5f;
        StartCoroutine(nameof(Dis_Smooth_Block));
    }

    private void Update()
    {
        transform.Translate(Vector3.right * Time.deltaTime * speed);
    }


    IEnumerator Dis_Smooth_Block()
    {
        yield return new WaitForSeconds(8f);
        gameObject.SetActive(false);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Smooth")
        {
            StartCoroutine(nameof(Smooth_Pause));
        }
        if (collision.gameObject.tag == "Player")
        {
            Manager.manager.hp--;
            Manager.manager.Hit_Player();
        }
    }

    IEnumerator Smooth_Pause()
    {
        speed = 0;
        yield return new WaitForSeconds(0.5f);
        Manager.manager.drop_Pattern.Stop();
        Manager.manager.drop_Pattern.Play();
        speed = 17f;
    }
}
