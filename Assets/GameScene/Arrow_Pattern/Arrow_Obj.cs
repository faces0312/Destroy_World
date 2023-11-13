using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrow_Obj : MonoBehaviour
{
    public GameObject[] fail;

    public Arrow_User arrow_User;

    public int[] arrow_array;
    public int[] arrow_Uner_array;

    
    private void OnEnable()
    {
        for(int i=0; i<5; i++)
        {
            fail[i].gameObject.SetActive(false);
        }
        arrow_array = new int[5] { 100, 100, 100, 100, 100 };
        arrow_Uner_array = new int[5] { 100, 100, 100, 100, 100 };
    }

    public void Check_Arrow()
    {
        for(int i=0; i<5; i++)
        {
            if(arrow_array[i] != arrow_Uner_array[i])
            {
                Manager.manager.hp--;
                return;
            }
        }
    }
}
