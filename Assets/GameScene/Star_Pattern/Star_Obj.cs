using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Star_Obj : MonoBehaviour
{
    public int yellow_cnt;
    public GameObject yellowStar1;
    public GameObject yellowStar2;

    public int red_cnt;
    public GameObject redStar1;
    public GameObject redStar2;

    public int[] star_array;//star위치에 대한 이중 배열
    int star_ran;//배열의 몇번째
    public int star_num;//결정된 번호

    private void OnEnable()
    {
        star_array = new int[9] { 0, 1, 2, 3, 4, 5, 6, 7, 8 };
        yellow_cnt = 2;
        red_cnt = 2;

        YellowStar1_Pos();
        YellowStar2_Pos();
        RedStar1_Pos();
        RedStar2_Pos();
    }

    public void YellowStar1_Pos()
    {
        do
        {
            star_ran = Random.Range(0, 9);
        } while (star_array[star_ran] == 100);

        star_num = star_array[star_ran];
        star_array[star_ran] = 100;

        yellowStar1.gameObject.transform.position = Manager.manager.objectManager.box[star_num].transform.position;

    }
    public void YellowStar2_Pos()
    {
        do
        {
            star_ran = Random.Range(0, 9);
        } while (star_array[star_ran] == 100);

        star_num = star_array[star_ran];
        star_array[star_ran] = 100;

        yellowStar2.gameObject.transform.position = Manager.manager.objectManager.box[star_num].transform.position;

        if(yellowStar1.gameObject.transform.position.y == yellowStar2.gameObject.transform.position.y)
        {
            YellowStar2_Pos();
        }
    }

    public void RedStar1_Pos()
    {
        do
        {
            star_ran = Random.Range(0, 9);
        } while (star_array[star_ran] == 100);

        star_num = star_array[star_ran];
        star_array[star_ran] = 100;

        redStar1.gameObject.transform.position = Manager.manager.objectManager.box[star_num].transform.position;
    }
    public void RedStar2_Pos()
    {
        do
        {
            star_ran = Random.Range(0, 9);
        } while (star_array[star_ran] == 100);

        star_num = star_array[star_ran];
        star_array[star_ran] = 100;

        redStar2.gameObject.transform.position = Manager.manager.objectManager.box[star_num].transform.position;

        if (redStar1.gameObject.transform.position.y == redStar2.gameObject.transform.position.y)
        {
            RedStar2_Pos();
        }
    }
}
