using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrow : MonoBehaviour
{
    public Arrow_Obj arrow_Obj;

    public int[] sprite_array;

    int ran_num;
    int ran_sprite;

    public GameObject[] arrow1_dir;//left right up down
    public GameObject[] arrow2_dir;//left right up down
    public GameObject[] arrow3_dir;//left right up down
    public GameObject[] arrow4_dir;//left right up down
    public GameObject[] arrow5_dir;//left right up down

    public GameObject[] arrow1_sprite;
    public GameObject[] arrow2_sprite;
    public GameObject[] arrow3_sprite;
    public GameObject[] arrow4_sprite;
    public GameObject[] arrow5_sprite;

    private void OnEnable()
    {
        sprite_array = new int[5] { 100, 100, 100, 100, 100 };

        for (int i=0; i<4; i++)
        {
            arrow1_dir[i].gameObject.SetActive(false);
            arrow2_dir[i].gameObject.SetActive(false);
            arrow3_dir[i].gameObject.SetActive(false);
            arrow4_dir[i].gameObject.SetActive(false);
            arrow5_dir[i].gameObject.SetActive(false);
        }

        for (int i = 0; i < 16; i++)
        {
            arrow1_sprite[i].gameObject.SetActive(false);
            arrow2_sprite[i].gameObject.SetActive(false);
            arrow3_sprite[i].gameObject.SetActive(false);
            arrow4_sprite[i].gameObject.SetActive(false);
            arrow5_sprite[i].gameObject.SetActive(false);
        }

        RandomArrow1();
        RandomArrow2();
        RandomArrow3();
        RandomArrow4();
        RandomArrow5();
    }

    public void RandomArrow1()
    {
        ran_num = Random.Range(0, 4);
        if(ran_num == 0)
        {
            ran_sprite = Random.Range(0, 4);
            arrow1_sprite[ran_sprite].gameObject.SetActive(true);
            sprite_array[0] = ran_sprite;
        }
        else if (ran_num == 1)
        {
            ran_sprite = Random.Range(4, 8);
            arrow1_sprite[ran_sprite].gameObject.SetActive(true);
            sprite_array[0] = ran_sprite;
        }
        else if (ran_num == 2)
        {
            ran_sprite = Random.Range(8, 12);
            arrow1_sprite[ran_sprite].gameObject.SetActive(true);
            sprite_array[0] = ran_sprite;
        }
        else if (ran_num == 3)
        {
            ran_sprite = Random.Range(12, 16);
            arrow1_sprite[ran_sprite].gameObject.SetActive(true);
            sprite_array[0] = ran_sprite;
        }
        arrow_Obj.arrow_array[0] = ran_num;
        arrow1_dir[ran_num].gameObject.SetActive(true);

    }
    public void RandomArrow2()
    {
        ran_num = Random.Range(0, 4);
        if (ran_num == 0)
        {
            ran_sprite = Random.Range(0, 4);
            arrow2_sprite[ran_sprite].gameObject.SetActive(true);
            sprite_array[1] = ran_sprite;
        }
        else if (ran_num == 1)
        {
            ran_sprite = Random.Range(4, 8);
            arrow2_sprite[ran_sprite].gameObject.SetActive(true);
            sprite_array[1] = ran_sprite;
        }
        else if (ran_num == 2)
        {
            ran_sprite = Random.Range(8, 12);
            arrow2_sprite[ran_sprite].gameObject.SetActive(true);
            sprite_array[1] = ran_sprite;
        }
        else if (ran_num == 3)
        {
            ran_sprite = Random.Range(12, 16);
            arrow2_sprite[ran_sprite].gameObject.SetActive(true);
            sprite_array[1] = ran_sprite;
        }
        arrow_Obj.arrow_array[1] = ran_num;
        arrow2_dir[ran_num].gameObject.SetActive(true);
    }
    public void RandomArrow3()
    {
        ran_num = Random.Range(0, 4);
        if (ran_num == 0)
        {
            ran_sprite = Random.Range(0, 4);
            arrow3_sprite[ran_sprite].gameObject.SetActive(true);
            sprite_array[2] = ran_sprite;
        }
        else if (ran_num == 1)
        {
            ran_sprite = Random.Range(4, 8);
            arrow3_sprite[ran_sprite].gameObject.SetActive(true);
            sprite_array[2] = ran_sprite;
        }
        else if (ran_num == 2)
        {
            ran_sprite = Random.Range(8, 12);
            arrow3_sprite[ran_sprite].gameObject.SetActive(true);
            sprite_array[2] = ran_sprite;
        }
        else if (ran_num == 3)
        {
            ran_sprite = Random.Range(12, 16);
            arrow3_sprite[ran_sprite].gameObject.SetActive(true);
            sprite_array[2] = ran_sprite;
        }
        arrow_Obj.arrow_array[2] = ran_num;
        arrow3_dir[ran_num].gameObject.SetActive(true);
    }
    public void RandomArrow4()
    {
        ran_num = Random.Range(0, 4);
        if (ran_num == 0)
        {
            ran_sprite = Random.Range(0, 4);
            arrow4_sprite[ran_sprite].gameObject.SetActive(true);
            sprite_array[3] = ran_sprite;
        }
        else if (ran_num == 1)
        {
            ran_sprite = Random.Range(4, 8);
            arrow4_sprite[ran_sprite].gameObject.SetActive(true);
            sprite_array[3] = ran_sprite;
        }
        else if (ran_num == 2)
        {
            ran_sprite = Random.Range(8, 12);
            arrow4_sprite[ran_sprite].gameObject.SetActive(true);
            sprite_array[3] = ran_sprite;
        }
        else if (ran_num == 3)
        {
            ran_sprite = Random.Range(12, 16);
            arrow4_sprite[ran_sprite].gameObject.SetActive(true);
            sprite_array[3] = ran_sprite;
        }
        arrow_Obj.arrow_array[3] = ran_num;
        arrow4_dir[ran_num].gameObject.SetActive(true);
    }
    public void RandomArrow5()
    {
        ran_num = Random.Range(0, 4);
        if (ran_num == 0)
        {
            ran_sprite = Random.Range(0, 4);
            arrow5_sprite[ran_sprite].gameObject.SetActive(true);
            sprite_array[4] = ran_sprite;
        }
        else if (ran_num == 1)
        {
            ran_sprite = Random.Range(4, 8);
            arrow5_sprite[ran_sprite].gameObject.SetActive(true);
            sprite_array[4] = ran_sprite;
        }
        else if (ran_num == 2)
        {
            ran_sprite = Random.Range(8, 12);
            arrow5_sprite[ran_sprite].gameObject.SetActive(true);
            sprite_array[4] = ran_sprite;
        }
        else if (ran_num == 3)
        {
            ran_sprite = Random.Range(12, 16);
            arrow5_sprite[ran_sprite].gameObject.SetActive(true);
            sprite_array[4] = ran_sprite;
        }
        arrow_Obj.arrow_array[4] = ran_num;
        arrow5_dir[ran_num].gameObject.SetActive(true);
    }
}
