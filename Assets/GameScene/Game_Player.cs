using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game_Player : MonoBehaviour
{
    public float camera_size;

    public GameObject hp3;
    public GameObject hp2;
    public GameObject hp1;

    public Arrow_Obj arrow_Obj;

    private void Start()
    {
        arrow_Obj.arrow_array = new int[5] { 100, 100, 100, 100, 100 };
        arrow_Obj.arrow_Uner_array = new int[5] { 100, 100, 100, 100, 100 };

        camera_size = 5;
        Manager.manager.game_Camera.orthographicSize = camera_size;
    }

    // Update is called once per frame
    void Update()
    {
        if(Manager.manager.hp == 3)
        {
            hp3.gameObject.SetActive(true);
            hp2.gameObject.SetActive(false);
            hp1.gameObject.SetActive(false);
        }
        else if (Manager.manager.hp == 2)
        {
            hp3.gameObject.SetActive(false);
            hp2.gameObject.SetActive(true);
            hp1.gameObject.SetActive(false);
        }
        else if (Manager.manager.hp == 1)
        {
            hp3.gameObject.SetActive(false);
            hp2.gameObject.SetActive(false);
            hp1.gameObject.SetActive(true);
        }


        if (Manager.manager.hp <= 0)
        {
            Manager.manager.objectManager.view_Camera.gameObject.SetActive(false);
            Manager.manager.game_Camera.gameObject.SetActive(true);
            Manager.manager.retry.gameObject.SetActive(true);
            Manager.manager.time_Text.gameObject.SetActive(false);
            Manager.manager.stage_cnt_Text.gameObject.SetActive(false);
            gameObject.SetActive(false);
        }
        if(Input.GetKeyDown(KeyCode.W))
        {
            W();
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            S();
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            D();
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            A();
        }
    }
    IEnumerator MoveEffect()
    {
        for(float i = camera_size; i >= camera_size-0.3f; i-= 0.1f)
        {
            Manager.manager.game_Camera.orthographicSize = i;
            yield return new WaitForSeconds(0.02f);
        }
        for (float i = camera_size-0.3f; i <= camera_size; i += 0.1f)
        {
            Manager.manager.game_Camera.orthographicSize = i;
            yield return new WaitForSeconds(0.02f);
        }
    }

    public void W()
    {
        Manager.manager.move_Sound.Stop();
        Manager.manager.move_Sound.Play();
        Manager.manager.game_Camera.orthographicSize = camera_size;
        StartCoroutine(nameof(MoveEffect));
        if (gameObject.transform.position.y <= 0)
        {
            gameObject.transform.position = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y + 1.8f);
        }
        else
        {
            gameObject.transform.position = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y - 3.6f);
        }

        if (arrow_Obj.arrow_User.gameObject.activeSelf == true && arrow_Obj.gameObject.activeSelf == true)
            arrow_Obj.arrow_User.Arrow_Up();
    }

    public void S()
    {
        Manager.manager.move_Sound.Stop();
        Manager.manager.move_Sound.Play();
        Manager.manager.game_Camera.orthographicSize = camera_size;
        StartCoroutine(nameof(MoveEffect));
        if (gameObject.transform.position.y >= 0)
        {
            gameObject.transform.position = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y - 1.8f);
        }
        else
        {
            gameObject.transform.position = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y + 3.6f);
        }
        if (arrow_Obj.arrow_User.gameObject.activeSelf == true && arrow_Obj.gameObject.activeSelf == true)
            arrow_Obj.arrow_User.Arrow_Down();
    }

    public void A()
    {
        Manager.manager.move_Sound.Stop();
        Manager.manager.move_Sound.Play();
        Manager.manager.game_Camera.orthographicSize = camera_size;
        StartCoroutine(nameof(MoveEffect));
        if (gameObject.transform.position.x >= 0)
        {
            gameObject.transform.position = new Vector3(gameObject.transform.position.x - 1.8f, gameObject.transform.position.y);
        }
        else
        {
            gameObject.transform.position = new Vector3(gameObject.transform.position.x + 3.6f, gameObject.transform.position.y);
        }
        if (arrow_Obj.arrow_User.gameObject.activeSelf == true && arrow_Obj.gameObject.activeSelf == true)
            arrow_Obj.arrow_User.Arrow_Left();
    }

    public void D()
    {
        Manager.manager.move_Sound.Stop();
        Manager.manager.move_Sound.Play();
        Manager.manager.game_Camera.orthographicSize = camera_size;
        StartCoroutine(nameof(MoveEffect));
        if (gameObject.transform.position.x <= 0)
        {
            gameObject.transform.position = new Vector3(gameObject.transform.position.x + 1.8f, gameObject.transform.position.y);
        }
        else
        {
            gameObject.transform.position = new Vector3(gameObject.transform.position.x - 3.6f, gameObject.transform.position.y);
        }
        if (arrow_Obj.arrow_User.gameObject.activeSelf == true && arrow_Obj.gameObject.activeSelf == true)
            arrow_Obj.arrow_User.Arrow_Right();
    }
}
