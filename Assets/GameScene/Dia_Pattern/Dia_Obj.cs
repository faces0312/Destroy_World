using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dia_Obj : MonoBehaviour
{
    // Start is called before the first frame update
    void OnEnable()
    {
        StartCoroutine(nameof(Dis_Dia_Block));
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.right * Time.deltaTime * 8);
    }

    IEnumerator Dis_Dia_Block()
    {
        yield return new WaitForSeconds(13f);
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
