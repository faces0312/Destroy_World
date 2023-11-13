using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drop_Obj : MonoBehaviour
{
    Vector3 end_Pos;
    int move_Point;
    int ran_endPos;
    
    public void OnEnable()
    {
        StartCoroutine(nameof(Dis_Drop_Block));

        move_Point = 0;
        ran_endPos = Random.Range(0, 3);
        if(ran_endPos == 0)
        {
            end_Pos = new Vector3(-1.8f, 4.5f);
        }
        else if (ran_endPos == 1)
        {
            end_Pos = new Vector3(0, 4.5f);
        }
        else if (ran_endPos == 2)
        {
            end_Pos = new Vector3(1.8f, 4.5f);
        }
    }

    private void Update()
    {

        if (transform.position == end_Pos)
        {
            move_Point = 1;
        }
        if (move_Point == 0)
        {
            gameObject.transform.position = Vector3.MoveTowards(transform.position, end_Pos, Time.deltaTime * 5.5f);
        }
        else if( move_Point == 1)
        {
            transform.Translate(Vector3.down * Time.deltaTime * 8);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Manager.manager.hp--;
            Manager.manager.Hit_Player();
        }
    }

    IEnumerator Dis_Drop_Block()
    {
        yield return new WaitForSeconds(8f);
        gameObject.SetActive(false);
    }
}
