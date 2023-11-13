using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Tripple : MonoBehaviour
{
    public Tripple_Obj tripple;

    public BoxCollider2D boxCollider2D;

    public SpriteRenderer render;

    Vector3 move_Pos;

    bool is_move;//움직임 여부
    int move_dir;//left, right, up, down


    private void OnEnable()
    {
        is_move = false;
        move_Pos = gameObject.transform.position;

        boxCollider2D.enabled = false;
        render.color = new Color(1, 1, 1, 0);
        StartCoroutine(nameof(Alpha_Up));
    }

    private void Update()
    {
        if(is_move == true)
        {
            gameObject.transform.position = Vector3.MoveTowards(gameObject.transform.position, move_Pos, 2.8f * Time.deltaTime);
            if (gameObject.transform.position == move_Pos)
                is_move = false;
        }
    }
    IEnumerator Alpha_Up()
    {
        for (float i = 0; i <= 1; i += 0.05f)
        {
            render.color = new Color(1, 1, 1, i);
            yield return new WaitForSeconds(0.1f);
        }
        boxCollider2D.enabled = true;
        StartCoroutine(nameof(Move_Tripple));
    }

    IEnumerator Move_Tripple()
    {
        yield return new WaitForSeconds(0.5f);
        Move_Function();
        yield return new WaitForSeconds(1f);
        Move_Function();
        yield return new WaitForSeconds(1f);
        Move_Function();
        yield return new WaitForSeconds(1f);
        Move_Function();
        yield return new WaitForSeconds(1f);
        Move_Function();
        yield return new WaitForSeconds(1f);
        Move_Function();
        yield return new WaitForSeconds(1f);
        Move_Function();
        yield return new WaitForSeconds(1f);
        Move_Function();
        yield return new WaitForSeconds(1f);
        Move_Function();
        yield return new WaitForSeconds(1f);
        Move_Function();
        yield return new WaitForSeconds(1f);
        Move_Function();
        yield return new WaitForSeconds(1f);
        Move_Function();
        yield return new WaitForSeconds(1f);
        Move_Function();
        yield return new WaitForSeconds(1f);
        Move_Function();
        yield return new WaitForSeconds(1f);
        Move_Function();
        yield return new WaitForSeconds(1f);
        Move_Function();
        yield return new WaitForSeconds(1f);
        Move_Function();
        yield return new WaitForSeconds(1f);
        Move_Function();


        yield return new WaitForSeconds(1f);
        Manager.manager.Explain();
        tripple.gameObject.SetActive(false);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Manager.manager.hp--;
            Manager.manager.Hit_Player();
        }
    }

    void Move_Function()
    {
        if (gameObject.transform.position == tripple.tripple_Pos[0].transform.position)//위 오른쪽
        {
            move_dir = Random.Range(0, 2);
            if (move_dir == 0)
            {
                move_Pos = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y + 1.8f);
                is_move = true;
            }
            else if (move_dir == 1)
            {
                move_Pos = new Vector3(gameObject.transform.position.x + 1.8f, gameObject.transform.position.y);
                is_move = true;
            }
        }
        else if (gameObject.transform.position == tripple.tripple_Pos[1].transform.position)//왼쪽 위 오른쪽
        {
            move_dir = Random.Range(0, 3);
            if (move_dir == 0)
            {
                move_Pos = new Vector3(gameObject.transform.position.x - 1.8f, gameObject.transform.position.y);
                is_move = true;
            }
            else if (move_dir == 1)
            {
                move_Pos = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y + 1.8f);
                is_move = true;
            }
            else if (move_dir == 2)
            {
                move_Pos = new Vector3(gameObject.transform.position.x + 1.8f, gameObject.transform.position.y);
                is_move = true;
            }
        }
        else if (gameObject.transform.position == tripple.tripple_Pos[2].transform.position)//왼쪽 위
        {
            move_dir = Random.Range(0, 2);
            if (move_dir == 0)
            {
                move_Pos = new Vector3(gameObject.transform.position.x - 1.8f, gameObject.transform.position.y);
                is_move = true;
            }
            else if (move_dir == 1)
            {
                move_Pos = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y + 1.8f);
                is_move = true;
            }
        }
        else if (gameObject.transform.position == tripple.tripple_Pos[3].transform.position)//위 오른쪽 아래
        {
            move_dir = Random.Range(0, 3);
            if (move_dir == 0)
            {
                move_Pos = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y + 1.8f);
                is_move = true;
            }
            else if (move_dir == 1)
            {
                move_Pos = new Vector3(gameObject.transform.position.x + 1.8f, gameObject.transform.position.y);
                is_move = true;
            }
            else if (move_dir == 2)
            {
                move_Pos = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y - 1.8f);
                is_move = true;
            }
        }
        else if (gameObject.transform.position == tripple.tripple_Pos[4].transform.position)//왼쪽 위 오른쪽 아래
        {
            move_dir = Random.Range(0, 4);
            if (move_dir == 0)
            {
                move_Pos = new Vector3(gameObject.transform.position.x - 1.8f, gameObject.transform.position.y);
                is_move = true;
            }
            else if (move_dir == 1)
            {
                move_Pos = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y + 1.8f);
                is_move = true;
            }
            else if (move_dir == 2)
            {
                move_Pos = new Vector3(gameObject.transform.position.x + 1.8f, gameObject.transform.position.y);
                is_move = true;
            }
            else if (move_dir == 3)
            {
                move_Pos = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y - 1.8f);
                is_move = true;
            }
        }
        else if (gameObject.transform.position == tripple.tripple_Pos[5].transform.position)//왼쪽 위 아래
        {
            move_dir = Random.Range(0, 3);
            if (move_dir == 0)
            {
                move_Pos = new Vector3(gameObject.transform.position.x - 1.8f, gameObject.transform.position.y);
                is_move = true;
            }
            else if (move_dir == 1)
            {
                move_Pos = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y + 1.8f);
                is_move = true;
            }
            else if (move_dir == 2)
            {
                move_Pos = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y - 1.8f);
                is_move = true;
            }
        }
        else if (gameObject.transform.position == tripple.tripple_Pos[6].transform.position)//오른쪽 아래
        {
            move_dir = Random.Range(0, 2);
            if (move_dir == 0)
            {
                move_Pos = new Vector3(gameObject.transform.position.x + 1.8f, gameObject.transform.position.y);
                is_move = true;
            }
            else if (move_dir == 1)
            {
                move_Pos = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y - 1.8f);
                is_move = true;
            }
        }
        else if (gameObject.transform.position == tripple.tripple_Pos[7].transform.position)//왼쪽 오른쪽 아래
        {
            move_dir = Random.Range(0, 3);
            if (move_dir == 0)
            {
                move_Pos = new Vector3(gameObject.transform.position.x - 1.8f, gameObject.transform.position.y);
                is_move = true;
            }
            else if (move_dir == 1)
            {
                move_Pos = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y - 1.8f);
                is_move = true;
            }
            else if (move_dir == 2)
            {
                move_Pos = new Vector3(gameObject.transform.position.x + 1.8f, gameObject.transform.position.y);
                is_move = true;
            }
        }
        else if (gameObject.transform.position == tripple.tripple_Pos[8].transform.position)//왼쪽 아래
        {
            move_dir = Random.Range(0, 2);
            if (move_dir == 0)
            {
                move_Pos = new Vector3(gameObject.transform.position.x - 1.8f, gameObject.transform.position.y);
                is_move = true;
            }
            else if (move_dir == 1)
            {
                move_Pos = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y - 1.8f);
                is_move = true;
            }
        }
    }
}
