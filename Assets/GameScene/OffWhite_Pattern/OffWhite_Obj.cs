using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OffWhite_Obj : MonoBehaviour
{
    public GameObject offWhite1;
    public GameObject offWhite2;

    public GameObject ready1;
    public GameObject ready2;

    public Vector3 move_Pos1;
    int move_ran1;
    public Vector3 move_Pos2;
    int move_ran2;

    float move_speed;

    int turn_ran;
    float turn_speed;

    bool is_turn;

    // Start is called before the first frame update
    void OnEnable()
    {
        is_turn = false;

        offWhite1.gameObject.SetActive(false);
        offWhite2.gameObject.SetActive(false);
        ready1.gameObject.SetActive(false);
        ready2.gameObject.SetActive(false);

        ready1.gameObject.SetActive(true);

        offWhite1.transform.localEulerAngles = new Vector3(0, 0, 45);
        offWhite2.transform.localEulerAngles = new Vector3(0, 0, 135);

        offWhite1.gameObject.transform.position = new Vector3(0, 0, 0);
        offWhite2.gameObject.transform.position = new Vector3(0, 0, 0);

        move_Pos1 = new Vector3(0, 0, 0);
        move_Pos2 = new Vector3(0, 0, 0);

        move_speed = 2.2f;

        StartCoroutine(nameof(OffWhite_General));
    }

    private void Update()
    {
        if (is_turn == false)
        {
            offWhite1.gameObject.transform.position = Vector3.MoveTowards(offWhite1.gameObject.transform.position, move_Pos1, move_speed * Time.deltaTime);
            offWhite2.gameObject.transform.position = Vector3.MoveTowards(offWhite2.gameObject.transform.position, move_Pos2, move_speed * Time.deltaTime);
        }
        else
        {
            offWhite1.gameObject.transform.Rotate(Vector3.forward * Time.deltaTime * turn_speed);
            offWhite2.gameObject.transform.Rotate(Vector3.forward * Time.deltaTime * turn_speed);
        }
    }

    IEnumerator OffWhite_General()
    {
        yield return new WaitForSeconds(0.5f);
        ready1.gameObject.SetActive(false);
        offWhite1.gameObject.SetActive(true);

        yield return new WaitForSeconds(0.5f);
        ready2.gameObject.SetActive(true);

        yield return new WaitForSeconds(0.5f);
        ready2.gameObject.SetActive(false);
        offWhite2.gameObject.SetActive(true);

        StartCoroutine(nameof(OffWhite1_Move1));
    }

    IEnumerator OffWhite1_Move1()
    {
        yield return new WaitForSeconds(0.1f);
        move_ran1 = Random.Range(0, 2);
        if (move_ran1 == 0)//위
        {
            move_Pos1 = new Vector3(1.8f, 1.8f);
        }
        else//아래
        {
            move_Pos1 = new Vector3(-1.8f, -1.8f);
        }

        StartCoroutine(nameof(OffWhite2_Move1));
    }

    IEnumerator OffWhite2_Move1()
    {
        yield return new WaitForSeconds(1.5f);
        move_ran2 = Random.Range(0, 2);
        if (move_ran2 == 0)//위
        {
            move_Pos2 = new Vector3(-1.8f, 1.8f);
        }
        else//아래
        {
            move_Pos2 = new Vector3(1.8f, -1.8f);
        }

        StartCoroutine(nameof(OffWhite1_Move2));
    }

    IEnumerator OffWhite1_Move2()
    {
        yield return new WaitForSeconds(1f);

        move_speed = 6.2f;
        if (move_ran1 == 0)//위
        {
            move_Pos1 = new Vector3(-1.8f, -1.8f);
        }
        else//아래
        {
            move_Pos1 = new Vector3(1.8f, 1.8f);
        }

        StartCoroutine(nameof(OffWhite2_Move2));
    }

    IEnumerator OffWhite2_Move2()
    {
        yield return new WaitForSeconds(1f);
        if (move_ran2 == 0)//위
        {
            move_Pos2 = new Vector3(1.8f, -1.8f);
        }
        else//아래
        {
            move_Pos2 = new Vector3(-1.8f, 1.8f);
        }

        StartCoroutine(nameof(OffWhite_Move));
    }


    IEnumerator OffWhite_Move()
    {
        yield return new WaitForSeconds(2f);
        move_Pos1 = new Vector3(0, 0, 0);
        move_Pos2 = new Vector3(0, 0, 0);

        StartCoroutine(nameof(OffWhite_Turn));
    }

    IEnumerator OffWhite_Turn()
    {
        yield return new WaitForSeconds(2f);
        turn_ran = Random.Range(0, 2);
        if (turn_ran == 0)
            turn_speed = 75;
        else
            turn_speed = -75;
        is_turn = true;

        yield return new WaitForSeconds(6f);
        Manager.manager.Explain();
        gameObject.SetActive(false);
    }
}
