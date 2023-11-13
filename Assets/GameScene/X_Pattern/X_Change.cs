using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class X_Change : MonoBehaviour
{
    public GameObject x_red;
    public GameObject x_gray;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            if (x_red.gameObject.activeSelf == true)
            {
                x_red.gameObject.SetActive(false);
                x_gray.gameObject.SetActive(true);
            }
            else
            {
                x_red.gameObject.SetActive(true);
                x_gray.gameObject.SetActive(false);
            }
        }
    }
}
