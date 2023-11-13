using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Star_Block_Obj : MonoBehaviour
{
    public GameObject[] star_block;

    int block_ran;

    private void OnEnable()
    {
        StartCoroutine(nameof(Dis_Star_Block));

        for (int i = 0; i < 3; i++)
        {
            star_block[i].gameObject.SetActive(false);
        }

        for (int i = 0; i < 2; i++)
        {
            block_ran = Random.Range(0, 3);
            star_block[block_ran].gameObject.SetActive(true);
        }
    }

    private void Update()
    {
        transform.Translate(Vector3.left * Time.deltaTime * 6);
    }

    IEnumerator Dis_Star_Block()
    {
        yield return new WaitForSeconds(8f);
        gameObject.SetActive(false);
    }
}
