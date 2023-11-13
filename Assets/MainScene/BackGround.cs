using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackGround : MonoBehaviour
{
    public Main_Manager manager;

    public float camera_size;
    float move_Time;
    int move_Ran;

    public GameObject player_BackGround;

    private void OnEnable()
    {
        Time.timeScale = 1f;
        move_Time = 0.8f;
        camera_size = 6f;
        manager.main_Camera.orthographicSize = camera_size;
    }

    private void Update()
    {
        if(move_Time >= 0)
        {
            move_Time -= Time.deltaTime;
        }
        else
        {
            move_Ran = Random.Range(0, 5);
            if(move_Ran == 0 )
            {
                W();
            }
            else if (move_Ran == 1)
            {
                S();
            }
            else if (move_Ran == 2)
            {
                A();
            }
            else
            {
                D();
            }
            move_Time = 0.8f;
        }
    }

    public void W()
    {
        manager.main_Camera.orthographicSize = camera_size;
        StartCoroutine(nameof(MoveEffect));
        if (gameObject.transform.position.y <= 0)
        {
            gameObject.transform.position = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y + 2.7f);
        }
        else
        {
            gameObject.transform.position = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y - 5.4f);
        }

    }

    public void S()
    {
        manager.main_Camera.orthographicSize = camera_size;
        StartCoroutine(nameof(MoveEffect));
        if (gameObject.transform.position.y >= 0)
        {
            gameObject.transform.position = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y - 2.7f);
        }
        else
        {
            gameObject.transform.position = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y + 5.4f);
        }
    }

    public void A()
    {
        manager.main_Camera.orthographicSize = camera_size;
        StartCoroutine(nameof(MoveEffect));
        if (gameObject.transform.position.x >= 0)
        {
            gameObject.transform.position = new Vector3(gameObject.transform.position.x - 2.7f, gameObject.transform.position.y);
        }
        else
        {
            gameObject.transform.position = new Vector3(gameObject.transform.position.x + 5.4f, gameObject.transform.position.y);
        }
    }

    public void D()
    {
        manager.main_Camera.orthographicSize = camera_size;
        StartCoroutine(nameof(MoveEffect));
        if (gameObject.transform.position.x <= 0)
        {
            gameObject.transform.position = new Vector3(gameObject.transform.position.x + 2.7f, gameObject.transform.position.y);
        }
        else
        {
            gameObject.transform.position = new Vector3(gameObject.transform.position.x - 5.4f, gameObject.transform.position.y);
        }
    }

    IEnumerator MoveEffect()
    {
        for (float i = camera_size; i >= camera_size - 0.3f; i -= 0.1f)
        {
            manager.main_Camera.orthographicSize = i;
            yield return new WaitForSeconds(0.02f);
        }
        for (float i = camera_size - 0.3f; i <= camera_size; i += 0.1f)
        {
            manager.main_Camera.orthographicSize = i;
            yield return new WaitForSeconds(0.02f);
        }
    }

}
