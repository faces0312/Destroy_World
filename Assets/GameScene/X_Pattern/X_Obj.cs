using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class X_Obj : MonoBehaviour
{
    public float time;
    public GameObject time_obj;
    public Text time_Text;

    private void OnEnable()
    {
        Manager.manager.x_Pattern.Pause();
        Manager.manager.x_Pattern.Play();
        time_obj.gameObject.SetActive(false);
        time_obj.gameObject.SetActive(true);
        time = 2f;
    }

    private void Update()
    {
        time_Text.text = time.ToString("F1");
        if (time > 0)
        {
            time -= Time.deltaTime;
        }
        else
        {
            CheckX();
            time = 2f;
        }
    }

    public void CheckX()
    {
        for(int i=0; i<9; i++)
        {
            if(Manager.manager.objectManager.x_Sample_red[i].activeSelf == true &&
                Manager.manager.objectManager.x_red[i].activeSelf == false)
            {
                Manager.manager.hp--;
                if(Manager.manager.objectManager.x_cnt > 0)
                {
                    Manager.manager.objectManager.x_cnt--;
                    Manager.manager.objectManager.XPattern();
                }
                else
                {
                    Manager.manager.objectManager.x_cnt = 4;
                    time_obj.gameObject.SetActive(false);
                    gameObject.SetActive(false);
                    Manager.manager.Explain();
                }
                return;
            }
            if (Manager.manager.objectManager.x_Sample_gray[i].activeSelf == true &&
                Manager.manager.objectManager.x_gray[i].activeSelf == false)
            {
                Manager.manager.hp--;
                if (Manager.manager.objectManager.x_cnt > 0)
                {
                    Manager.manager.objectManager.x_cnt--;
                    Manager.manager.objectManager.XPattern();
                }
                else
                {
                    Manager.manager.objectManager.x_cnt = 4;
                    time_obj.gameObject.SetActive(false);
                    gameObject.SetActive(false);
                    Manager.manager.Explain();
                }
                return;
            }
        }

        if (Manager.manager.objectManager.x_cnt > 0)
        {
            Manager.manager.objectManager.x_cnt--;
            Manager.manager.objectManager.XPattern();
        }
        else
        {
            Manager.manager.objectManager.x_cnt = 4;
            time_obj.gameObject.SetActive(false);
            gameObject.SetActive(false);
            Manager.manager.Explain();
        }
    }
}
