using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Square_Obj : MonoBehaviour
{
    public GameObject square;
    public GameObject square_Ready;

    public void OnEnable()
    {
        square.gameObject.SetActive(false);
        square_Ready.gameObject.SetActive(true);
    }

}
