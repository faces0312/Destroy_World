using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tictoc_Obj : MonoBehaviour
{

    public GameObject tictoc1;
    public GameObject tictoc2;
    public GameObject tictoc3;
    public GameObject tictoc4;
    public GameObject tictoc5;
    public GameObject tictoc6;

    // Start is called before the first frame update
    void OnEnable()
    {
        tictoc1.gameObject.SetActive(false);
        tictoc2.gameObject.SetActive(false);
        tictoc3.gameObject.SetActive(false);
        tictoc4.gameObject.SetActive(false);
        tictoc5.gameObject.SetActive(false);
        tictoc6.gameObject.SetActive(false);

        tictoc1.gameObject.transform.position = new Vector3(-7.5f, 0, 0);
        tictoc2.gameObject.transform.position = new Vector3(7.5f, 1.8f, 0);
        tictoc3.gameObject.transform.position = new Vector3(7.5f, -1.8f, 0);
        tictoc4.gameObject.transform.position = new Vector3(1.8f, 4.5f, 0);
        tictoc5.gameObject.transform.position = new Vector3(-1.8f, 4.5f, 0);
        tictoc6.gameObject.transform.position = new Vector3(0, -4.5f, 0);

        StartCoroutine(nameof(TicToc_Ing));
    }

    IEnumerator TicToc_Ing()
    {
        tictoc1.gameObject.SetActive(true);
        yield return new WaitForSeconds(1f);
        tictoc2.gameObject.SetActive(true);
        tictoc3.gameObject.SetActive(true);
        yield return new WaitForSeconds(5f);
        tictoc6.gameObject.SetActive(true);
        yield return new WaitForSeconds(2f);
        tictoc4.gameObject.SetActive(true);
        tictoc5.gameObject.SetActive(true);
    }
}
