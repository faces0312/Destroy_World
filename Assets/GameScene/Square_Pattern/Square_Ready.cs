using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Square_Ready : MonoBehaviour
{
    public GameObject square;
    public GameObject square_Ready;
    private void OnEnable()
    {
        gameObject.transform.localScale = new Vector3(0, 0);
        StartCoroutine(nameof(Square_Effect));
    }

    IEnumerator Square_Effect()
    {
        for (int i = 0; i < 15; i++)
        {
            gameObject.transform.localScale = new Vector3(i * 0.1f, i * 0.1f);
            yield return new WaitForSeconds(0.02f);
        }
        yield return new WaitForSeconds(0.15f);
        square.gameObject.SetActive(true);
        square_Ready.gameObject.SetActive(false);
    }
}
