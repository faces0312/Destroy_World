using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrow_User : MonoBehaviour
{
    public Arrow_Obj arrow_Obj;
    public Arrow arrow;

    public int arrow_cnt;

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

    public void OnEnable()
    {
        arrow_cnt = 0;
        arrow_Obj.arrow_Uner_array = new int[5] { 100, 100, 100, 100, 100 };

        for (int i = 0; i < 4; i++)
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
    }

    public void Arrow_Up()
    {
        if(arrow_cnt == 0)
        {
            arrow1_dir[2].gameObject.SetActive(true);
            arrow1_sprite[arrow.sprite_array[0]].gameObject.SetActive(true);
            arrow_Obj.arrow_Uner_array[0] = 2;
            if(arrow_Obj.arrow_Uner_array[0] != arrow_Obj.arrow_array[0])
                arrow_Obj.fail[0].gameObject.SetActive(true);
        }
        else if (arrow_cnt == 1)
        {
            arrow2_dir[2].gameObject.SetActive(true);
            arrow2_sprite[arrow.sprite_array[1]].gameObject.SetActive(true);
            arrow_Obj.arrow_Uner_array[1] = 2;
            if (arrow_Obj.arrow_Uner_array[1] != arrow_Obj.arrow_array[1])
                arrow_Obj.fail[1].gameObject.SetActive(true);
        }
        else if (arrow_cnt == 2)
        {
            arrow3_dir[2].gameObject.SetActive(true);
            arrow3_sprite[arrow.sprite_array[2]].gameObject.SetActive(true);
            arrow_Obj.arrow_Uner_array[2] = 2;
            if (arrow_Obj.arrow_Uner_array[2] != arrow_Obj.arrow_array[2])
                arrow_Obj.fail[2].gameObject.SetActive(true);
        }
        else if (arrow_cnt == 3)
        {
            arrow4_dir[2].gameObject.SetActive(true);
            arrow4_sprite[arrow.sprite_array[3]].gameObject.SetActive(true);
            arrow_Obj.arrow_Uner_array[3] = 2;
            if (arrow_Obj.arrow_Uner_array[3] != arrow_Obj.arrow_array[3])
                arrow_Obj.fail[3].gameObject.SetActive(true);
        }
        else if (arrow_cnt == 4)
        {
            arrow5_dir[2].gameObject.SetActive(true);
            arrow5_sprite[arrow.sprite_array[4]].gameObject.SetActive(true);
            arrow_Obj.arrow_Uner_array[4] = 2;
            if (arrow_Obj.arrow_Uner_array[4] != arrow_Obj.arrow_array[4])
                arrow_Obj.fail[4].gameObject.SetActive(true);
        }
        arrow_cnt++;
    }

    public void Arrow_Down()
    {
        if (arrow_cnt == 0)
        {
            arrow1_dir[3].gameObject.SetActive(true);
            arrow1_sprite[arrow.sprite_array[0]].gameObject.SetActive(true);
            arrow_Obj.arrow_Uner_array[0] = 3;
            if (arrow_Obj.arrow_Uner_array[0] != arrow_Obj.arrow_array[0])
                arrow_Obj.fail[0].gameObject.SetActive(true);
        }
        else if (arrow_cnt == 1)
        {
            arrow2_dir[3].gameObject.SetActive(true);
            arrow2_sprite[arrow.sprite_array[1]].gameObject.SetActive(true);
            arrow_Obj.arrow_Uner_array[1] = 3;
            if (arrow_Obj.arrow_Uner_array[1] != arrow_Obj.arrow_array[1])
                arrow_Obj.fail[1].gameObject.SetActive(true);
        }
        else if (arrow_cnt == 2)
        {
            arrow3_dir[3].gameObject.SetActive(true);
            arrow3_sprite[arrow.sprite_array[2]].gameObject.SetActive(true);
            arrow_Obj.arrow_Uner_array[2] = 3;
            if (arrow_Obj.arrow_Uner_array[2] != arrow_Obj.arrow_array[2])
                arrow_Obj.fail[2].gameObject.SetActive(true);
        }
        else if (arrow_cnt == 3)
        {
            arrow4_dir[3].gameObject.SetActive(true);
            arrow4_sprite[arrow.sprite_array[3]].gameObject.SetActive(true);
            arrow_Obj.arrow_Uner_array[3] = 3;
            if (arrow_Obj.arrow_Uner_array[3] != arrow_Obj.arrow_array[3])
                arrow_Obj.fail[3].gameObject.SetActive(true);
        }
        else if (arrow_cnt == 4)
        {
            arrow5_dir[3].gameObject.SetActive(true);
            arrow5_sprite[arrow.sprite_array[4]].gameObject.SetActive(true);
            arrow_Obj.arrow_Uner_array[4] = 3;
            if (arrow_Obj.arrow_Uner_array[4] != arrow_Obj.arrow_array[4])
                arrow_Obj.fail[4].gameObject.SetActive(true);
        }
        arrow_cnt++;
    }

    public void Arrow_Left()
    {
        if (arrow_cnt == 0)
        {
            arrow1_dir[0].gameObject.SetActive(true);
            arrow1_sprite[arrow.sprite_array[0]].gameObject.SetActive(true);
            arrow_Obj.arrow_Uner_array[0] = 0;
            if (arrow_Obj.arrow_Uner_array[0] != arrow_Obj.arrow_array[0])
                arrow_Obj.fail[0].gameObject.SetActive(true);
        }
        else if (arrow_cnt == 1)
        {
            arrow2_dir[0].gameObject.SetActive(true);
            arrow2_sprite[arrow.sprite_array[1]].gameObject.SetActive(true);
            arrow_Obj.arrow_Uner_array[1] = 0;
            if (arrow_Obj.arrow_Uner_array[1] != arrow_Obj.arrow_array[1])
                arrow_Obj.fail[1].gameObject.SetActive(true);
        }
        else if (arrow_cnt == 2)
        {
            arrow3_dir[0].gameObject.SetActive(true);
            arrow3_sprite[arrow.sprite_array[2]].gameObject.SetActive(true);
            arrow_Obj.arrow_Uner_array[2] = 0;
            if (arrow_Obj.arrow_Uner_array[2] != arrow_Obj.arrow_array[2])
                arrow_Obj.fail[2].gameObject.SetActive(true);
        }
        else if (arrow_cnt == 3)
        {
            arrow4_dir[0].gameObject.SetActive(true);
            arrow4_sprite[arrow.sprite_array[3]].gameObject.SetActive(true);
            arrow_Obj.arrow_Uner_array[3] = 0;
            if (arrow_Obj.arrow_Uner_array[3] != arrow_Obj.arrow_array[3])
                arrow_Obj.fail[3].gameObject.SetActive(true);
        }
        else if (arrow_cnt == 4)
        {
            arrow5_dir[0].gameObject.SetActive(true);
            arrow5_sprite[arrow.sprite_array[4]].gameObject.SetActive(true);
            arrow_Obj.arrow_Uner_array[4] = 0;
            if (arrow_Obj.arrow_Uner_array[4] != arrow_Obj.arrow_array[4])
                arrow_Obj.fail[4].gameObject.SetActive(true);
        }
        arrow_cnt++;
    }

    public void Arrow_Right()
    {
        if (arrow_cnt == 0)
        {
            arrow1_dir[1].gameObject.SetActive(true);
            arrow1_sprite[arrow.sprite_array[0]].gameObject.SetActive(true);
            arrow_Obj.arrow_Uner_array[0] = 1;
            if (arrow_Obj.arrow_Uner_array[0] != arrow_Obj.arrow_array[0])
                arrow_Obj.fail[0].gameObject.SetActive(true);
        }
        else if (arrow_cnt == 1)
        {
            arrow2_dir[1].gameObject.SetActive(true);
            arrow2_sprite[arrow.sprite_array[1]].gameObject.SetActive(true);
            arrow_Obj.arrow_Uner_array[1] = 1;
            if (arrow_Obj.arrow_Uner_array[1] != arrow_Obj.arrow_array[1])
                arrow_Obj.fail[1].gameObject.SetActive(true);
        }
        else if (arrow_cnt == 2)
        {
            arrow3_dir[1].gameObject.SetActive(true);
            arrow3_sprite[arrow.sprite_array[2]].gameObject.SetActive(true);
            arrow_Obj.arrow_Uner_array[2] = 1;
            if (arrow_Obj.arrow_Uner_array[2] != arrow_Obj.arrow_array[2])
                arrow_Obj.fail[2].gameObject.SetActive(true);
        }
        else if (arrow_cnt == 3)
        {
            arrow4_dir[1].gameObject.SetActive(true);
            arrow4_sprite[arrow.sprite_array[3]].gameObject.SetActive(true);
            arrow_Obj.arrow_Uner_array[3] = 1;
            if (arrow_Obj.arrow_Uner_array[3] != arrow_Obj.arrow_array[3])
                arrow_Obj.fail[3].gameObject.SetActive(true);
        }
        else if (arrow_cnt == 4)
        {
            arrow5_dir[1].gameObject.SetActive(true);
            arrow5_sprite[arrow.sprite_array[4]].gameObject.SetActive(true);
            arrow_Obj.arrow_Uner_array[4] = 1;
            if (arrow_Obj.arrow_Uner_array[4] != arrow_Obj.arrow_array[4])
                arrow_Obj.fail[4].gameObject.SetActive(true);
        }
        arrow_cnt++;
    }

}
