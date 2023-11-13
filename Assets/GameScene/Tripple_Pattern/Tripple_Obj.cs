using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tripple_Obj : MonoBehaviour
{
    public GameObject[] tripple_Pos;

    int[] tripple_array;
    int ran_pos;

    public GameObject tripple1;
    public GameObject tripple2;
    public GameObject tripple3;
    public GameObject tripple4;

    private void OnEnable()
    {
        tripple_array = new int[9] { 0, 1, 2, 3, 4, 5, 6, 7, 8 };
        tripple1.gameObject.SetActive(false);
        tripple2.gameObject.SetActive(false);
        tripple3.gameObject.SetActive(false);
        tripple4.gameObject.SetActive(false);

        Tripple1_Pos();
        Tripple2_Pos();
        Tripple3_Pos();
        Tripple4_Pos();
    }

    void Tripple1_Pos()
    {
        do
        {
            ran_pos = Random.Range(0, 9);
        } while (tripple_array[ran_pos] == 100);

        tripple1.transform.position = tripple_Pos[tripple_array[ran_pos]].transform.position;
        tripple1.gameObject.SetActive(true);

        tripple_array[ran_pos] = 100;
    }

    void Tripple2_Pos()
    {
        do
        {
            ran_pos = Random.Range(0, 9);
        } while (tripple_array[ran_pos] == 100);

        tripple2.transform.position = tripple_Pos[tripple_array[ran_pos]].transform.position;
        tripple2.gameObject.SetActive(true);

        tripple_array[ran_pos] = 100;

    }

    void Tripple3_Pos()
    {
        do
        {
            ran_pos = Random.Range(0, 9);
        } while (tripple_array[ran_pos] == 100);

        tripple3.transform.position = tripple_Pos[tripple_array[ran_pos]].transform.position;
        tripple3.gameObject.SetActive(true);

        tripple_array[ran_pos] = 100;

    }

    void Tripple4_Pos()
    {
        do
        {
            ran_pos = Random.Range(0, 9);
        } while (tripple_array[ran_pos] == 100);

        tripple4.transform.position = tripple_Pos[tripple_array[ran_pos]].transform.position;
        tripple4.gameObject.SetActive(true);

        tripple_array[ran_pos] = 100;

    }
}