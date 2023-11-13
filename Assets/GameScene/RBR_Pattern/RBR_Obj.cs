using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RBR_Obj : MonoBehaviour
{
    int[] pos_array;
    int pos_ran;

    public BoxCollider2D red_collider;
    public BoxCollider2D blue_collider;
    public BoxCollider2D green_collider;

    public GameObject[] color;

    void OnEnable()
    {
        StartCoroutine(nameof(Dis_RBR_Block));
        pos_array = new int[3] { 0, 1, 2 };

        for(int i=0;i<3;i++)
        {
            color[i].gameObject.SetActive(false);
        }
        Pick_RBR();

        if(Manager.manager.objectManager.rbr_ran == 0)
        {
            red_collider.enabled = false;
            blue_collider.enabled = true;
            green_collider.enabled = true;
        }
        if (Manager.manager.objectManager.rbr_ran == 1)
        {
            red_collider.enabled = true;
            blue_collider.enabled = false;
            green_collider.enabled = true;
        }
        if (Manager.manager.objectManager.rbr_ran == 2)
        {
            red_collider.enabled = true;
            blue_collider.enabled = true;
            green_collider.enabled = false;
        }
    }

    private void Update()
    {
        transform.Translate(Vector3.left * Time.deltaTime * 12f);
    }


    IEnumerator Dis_RBR_Block()
    {
        yield return new WaitForSeconds(8f);
        gameObject.SetActive(false);
    }

    void Pick_RBR()
    {
        for (int i = 0; i < 3; i++)
        {
            do
            {
                pos_ran = Random.Range(0, 3);
            } while (pos_array[pos_ran] == 100);
            if (pos_ran == 0)
            {
                color[i].gameObject.SetActive(true);
                color[i].gameObject.transform.position = new Vector3(gameObject.transform.position.x, 1.8f);
            }
            else if (pos_ran == 1)
            {
                color[i].gameObject.SetActive(true);
                color[i].gameObject.transform.position = new Vector3(gameObject.transform.position.x, 0);
            }
            else if (pos_ran == 2)
            {
                color[i].gameObject.SetActive(true);
                color[i].gameObject.transform.position = new Vector3(gameObject.transform.position.x, -1.8f);
            }
            pos_array[pos_ran] = 100;
        }
    }
}
