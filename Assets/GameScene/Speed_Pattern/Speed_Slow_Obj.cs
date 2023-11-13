using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Speed_Slow_Obj : MonoBehaviour
{
    // Start is called before the first frame update
    void OnEnable()
    {
        StartCoroutine(nameof(Dis_Speed_Block));
    }

    private void Update()
    {
        transform.Translate(Vector3.right * Time.deltaTime * 4f);
    }


    IEnumerator Dis_Speed_Block()
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
