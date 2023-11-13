using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Laser_Ready : MonoBehaviour
{
    public GameObject laser;
    public GameObject laser_Ready;

    private void OnEnable()
    {
        gameObject.transform.localScale = new Vector3(0, 7);
        StartCoroutine(nameof(Laser_Effect));
    }

    IEnumerator Laser_Effect()
    {
        for(int i=0; i<50; i++)
        {
            gameObject.transform.localScale = new Vector3(i * 0.01f, 7);
            yield return new WaitForSeconds(0.005f);
        }
        yield return new WaitForSeconds(0.2f);
        laser.gameObject.SetActive(true);
        laser_Ready.gameObject.SetActive(false);
    }
}
