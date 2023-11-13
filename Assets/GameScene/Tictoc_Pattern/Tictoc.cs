using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tictoc : MonoBehaviour
{
    public float speed;
    private int ran_speed;

    public Tictoc_Obj tictoc_Obj;

    private void OnEnable()
    {
        speed = 0;
        StartCoroutine(nameof(Move));
    }
    private void Update()
    {
        transform.Translate(Vector3.right * Time.deltaTime * speed);
    }

    IEnumerator Move()
    {
        yield return new WaitForSeconds(0.4f);
        ran_speed = Random.Range(0,3);
        if (ran_speed == 0)
            speed = 3f;
        else if (ran_speed == 1)
            speed = 4f;
        else if (ran_speed == 2)
            speed = 5f;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Manager.manager.hp--;
            Manager.manager.Hit_Player();
        }
        if (collision.gameObject.tag == "Tictoc")
        {
            speed = speed * -1;
        }
    }
}
