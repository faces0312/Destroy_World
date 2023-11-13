using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Laser_Obj : MonoBehaviour
{
    public GameObject laser;
    public GameObject laser_Ready;

    public void OnEnable()
    {
        laser.gameObject.SetActive(false);
        laser_Ready.gameObject.SetActive(true);
    }
}
