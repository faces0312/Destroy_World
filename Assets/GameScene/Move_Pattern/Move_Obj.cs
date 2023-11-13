using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move_Obj : MonoBehaviour
{
    int ran_move;
    int ran_Dir;

    public GameObject stay;
    public GameObject move;

    void OnEnable()
    {
        StartCoroutine(nameof(Dis_Move_Block));
        stay.gameObject.SetActive(false);
        move.gameObject.SetActive(false);

        ran_move = Random.Range(0, 2);
        if (ran_move == 0)
            stay.gameObject.SetActive(true);
        else
            move.gameObject.SetActive(true);

        if (gameObject.transform.position.x == -1.8f && gameObject.transform.position.y < 0)
            move.transform.rotation = Quaternion.Euler(0, 0, -275);
        if (gameObject.transform.position.x == 0 && gameObject.transform.position.y < 0)
        {
            ran_Dir = Random.Range(0, 2);
            if (ran_Dir == 0)
                move.transform.rotation = Quaternion.Euler(0, 0, 275);
            else if (ran_Dir == 1)
                move.transform.rotation = Quaternion.Euler(0, 0, -275);
        }
        if (gameObject.transform.position.x == 1.8f && gameObject.transform.position.y < 0)
            move.transform.rotation = Quaternion.Euler(0, 0, 275);

        if (gameObject.transform.position.x < 0 && gameObject.transform.position.y == -1.8f)
            move.transform.rotation = Quaternion.Euler(0, 0, 275);
        if (gameObject.transform.position.x < 0 && gameObject.transform.position.y == 0)
        {
            ran_Dir = Random.Range(0, 2);
            if (ran_Dir == 0)
                move.transform.rotation = Quaternion.Euler(0, 0, 275);
            else if (ran_Dir == 1)
                move.transform.rotation = Quaternion.Euler(0, 0, -275);
        }
        if (gameObject.transform.position.x < 0 && gameObject.transform.position.y == 1.8f)
            move.transform.rotation = Quaternion.Euler(0, 0, -275);

        if (gameObject.transform.position.x == -1.8f && gameObject.transform.position.y > 0)
            move.transform.rotation = Quaternion.Euler(0, 0, 275);
        if (gameObject.transform.position.x == 0 && gameObject.transform.position.y > 0)
        {
            ran_Dir = Random.Range(0, 2);
            if (ran_Dir == 0)
                move.transform.rotation = Quaternion.Euler(0, 0, 275);
            else if (ran_Dir == 1)
                move.transform.rotation = Quaternion.Euler(0, 0, -275);
        }
        if (gameObject.transform.position.x == 1.8f && gameObject.transform.position.y > 0)
            move.transform.rotation = Quaternion.Euler(0, 0, -275);

        if (gameObject.transform.position.x > 0 && gameObject.transform.position.y == -1.8f)
            move.transform.rotation = Quaternion.Euler(0, 0, -275);
        if (gameObject.transform.position.x > 0 && gameObject.transform.position.y == 0)
        {
            ran_Dir = Random.Range(0, 2);
            if (ran_Dir == 0)
                move.transform.rotation = Quaternion.Euler(0, 0, 275);
            else if (ran_Dir == 1)
                move.transform.rotation = Quaternion.Euler(0, 0, -275);
        }
        if (gameObject.transform.position.x > 0 && gameObject.transform.position.y == 1.8f)
            move.transform.rotation = Quaternion.Euler(0, 0, 275);
    }

    private void Update()
    {
        transform.Translate(Vector3.right * Time.deltaTime * 3.5f);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Manager.manager.hp--;
        }
    }

    IEnumerator Dis_Move_Block()
    {
        yield return new WaitForSeconds(8f);
        gameObject.SetActive(false);
    }

    /*void adf()
    {
        if (gameObject.transform.position.x == -1.8f && gameObject.transform.position.y < 0)
            move.transform.localEulerAngles = new Vector3(0, 0, -90);
        if (gameObject.transform.position.x == 0 && gameObject.transform.position.y < 0)
        {
            ran_Dir = Random.Range(0, 2);
            if (ran_Dir == 0)
                move.transform.localEulerAngles = new Vector3(0, 0, 90);
            else if (ran_Dir == 1)
                move.transform.localEulerAngles = new Vector3(0, 0, -90);
        }
        if (gameObject.transform.position.x == 1.8f && gameObject.transform.position.y < 0)
            move.transform.localEulerAngles = new Vector3(0, 0, 90);

        if (gameObject.transform.position.x < 0 && gameObject.transform.position.y == -1.8f)
            move.transform.localEulerAngles = new Vector3(0, 0, 90);
        if (gameObject.transform.position.x < 0 && gameObject.transform.position.y == 0)
        {
            ran_Dir = Random.Range(0, 2);
            if (ran_Dir == 0)
                move.transform.localEulerAngles = new Vector3(0, 0, 90);
            else if (ran_Dir == 1)
                move.transform.localEulerAngles = new Vector3(0, 0, -90);
        }
        if (gameObject.transform.position.x < 0 && gameObject.transform.position.y == 1.8f)
            move.transform.localEulerAngles = new Vector3(0, 0, -90);

        if (gameObject.transform.position.x == -1.8f && gameObject.transform.position.y > 0)
            move.transform.localEulerAngles = new Vector3(0, 0, 90);
        if (gameObject.transform.position.x == 0 && gameObject.transform.position.y > 0)
        {
            ran_Dir = Random.Range(0, 2);
            if (ran_Dir == 0)
                move.transform.localEulerAngles = new Vector3(0, 0, 90);
            else if (ran_Dir == 1)
                move.transform.localEulerAngles = new Vector3(0, 0, -90);
        }
        if (gameObject.transform.position.x == 1.8f && gameObject.transform.position.y > 0)
            move.transform.localEulerAngles = new Vector3(0, 0, -90);

        if (gameObject.transform.position.x > 0 && gameObject.transform.position.y == -1.8f)
            move.transform.localEulerAngles = new Vector3(0, 0, -90);
        if (gameObject.transform.position.x > 0 && gameObject.transform.position.y == 0)
        {
            ran_Dir = Random.Range(0, 2);
            if (ran_Dir == 0)
                move.transform.localEulerAngles = new Vector3(0, 0, 90);
            else if (ran_Dir == 1)
                move.transform.localEulerAngles = new Vector3(0, 0, -90);
        }
        if (gameObject.transform.position.x > 0 && gameObject.transform.position.y == 1.8f)
            move.transform.localEulerAngles = new Vector3(0, 0, 90);
    }*/
}
