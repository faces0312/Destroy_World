using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Laser : MonoBehaviour
{
    public GameObject laser;
    public GameObject laser_obj;

    private void OnEnable()
    {
        Manager.manager.laser_Pattern.Stop();
        Manager.manager.laser_Pattern.Play();
        StartCoroutine(nameof(Laser_Ing));
    }

    IEnumerator Laser_Ing()
    {
        yield return new WaitForSeconds(1f);
        laser_obj.gameObject.SetActive(false);
        laser.gameObject.SetActive(false);
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
