using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class View_Obj : MonoBehaviour
{
    int ran_obj;
    float speed;
    public GameObject red;
    public GameObject blue;
    public GameObject green;

    void OnEnable()
    {
        speed = 0;

        red.gameObject.SetActive(false);
        blue.gameObject.SetActive(false);
        green.gameObject.SetActive(false);

        ran_obj = Random.Range(0, 3);

        if(ran_obj == 0)
        {
            red.gameObject.SetActive(true);
            speed = 27;
        }
        else if (ran_obj == 1)
        {
            blue.gameObject.SetActive(true);
            speed = 22f;
        }
        else if (ran_obj == 2)
        {
            green.gameObject.SetActive(true);
            speed = 17f;
        }
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.Translate(Vector3.down * speed * Time.deltaTime);
    }
}
