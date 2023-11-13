using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fan_Obj : MonoBehaviour
{
    public GameObject fan;
    public GameObject fan_Ready;

    public float speed;
    private void OnEnable()
    {
        fan.gameObject.SetActive(false);
        fan_Ready.gameObject.SetActive(true);

        fan.transform.localEulerAngles = new Vector3(0, 0, 0);
        speed = 40f;

        StartCoroutine(nameof(Fan_Ready));
    }

    private void Update()
    {
        if (fan.gameObject.activeSelf == true)
        {
            fan.gameObject.transform.Rotate(Vector3.forward * Time.deltaTime * speed);
        }
    }

    IEnumerator Fan_Ready()
    {
        for(float i=0; i<=0.6f; i+=0.05f)
        {
            fan_Ready.gameObject.transform.localScale = new Vector3(i, fan_Ready.gameObject.transform.localScale.y);
            yield return new WaitForSeconds(0.05f);
        }
        yield return new WaitForSeconds(0.5f);
        fan.gameObject.SetActive(true);
        fan_Ready.gameObject.SetActive(false);
        StartCoroutine(nameof(Fan_Speed));
    }

    IEnumerator Fan_Speed()
    {
        for (int i = 0; i < 20; i++)
        {
            speed += 13f;
            yield return new WaitForSeconds(0.5f);
        }

        yield return new WaitForSeconds(0.5f);

        for (int i = 0; i < 15; i++)
        {
            speed -= 20f;
            yield return new WaitForSeconds(0.5f);
        }

        Manager.manager.Explain();
        gameObject.SetActive(false);
    }
}
