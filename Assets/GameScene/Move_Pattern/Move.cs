using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public Move_Obj move_Obj;

    int ran_Dir;
    // Start is called before the first frame update
    void OnEnable()
    {
        if(move_Obj.gameObject.transform.position.x == -1.8f && move_Obj.gameObject.transform.position.y < 0)
        {
            gameObject.transform.rotation = Quaternion.Euler(0, 0, -180);
        }
        else if (move_Obj.gameObject.transform.position.x == 0 && move_Obj.gameObject.transform.position.y < 0)
        {
            ran_Dir = Random.Range(0, 2);
            if(ran_Dir == 0)
                gameObject.transform.rotation = Quaternion.Euler(0, 0, -180);
            else
                gameObject.transform.rotation = Quaternion.Euler(0, 0, 180);
        }
        else if (move_Obj.gameObject.transform.position.x == 1.8f && move_Obj.gameObject.transform.position.y < 0)
        {
            gameObject.transform.rotation = Quaternion.Euler(0, 0, 180);
        }
        else if (move_Obj.gameObject.transform.position.x < 0 && move_Obj.gameObject.transform.position.y == -1.8f)
        {
            gameObject.transform.rotation = Quaternion.Euler(0, 0, 180);
        }
        else if (move_Obj.gameObject.transform.position.x < 0 && move_Obj.gameObject.transform.position.y == 0)
        {
            ran_Dir = Random.Range(0, 2);
            if (ran_Dir == 0)
                gameObject.transform.rotation = Quaternion.Euler(0, 0, -180);
            else
                gameObject.transform.rotation = Quaternion.Euler(0, 0, 180);
        }
        else if (move_Obj.gameObject.transform.position.x < 0 && move_Obj.gameObject.transform.position.y == 1.8f)
        {
            gameObject.transform.rotation = Quaternion.Euler(0, 0, -180);
        }
        else if (move_Obj.gameObject.transform.position.x > 0 && move_Obj.gameObject.transform.position.y == -1.8f)
        {
            gameObject.transform.rotation = Quaternion.Euler(0, 0, -180);
        }
        else if (move_Obj.gameObject.transform.position.x > 0 && move_Obj.gameObject.transform.position.y == 0)
        {
            ran_Dir = Random.Range(0, 2);
            if (ran_Dir == 0)
                gameObject.transform.rotation = Quaternion.Euler(0, 0, -180);
            else
                gameObject.transform.rotation = Quaternion.Euler(0, 0, 180);
        }
        else if (move_Obj.gameObject.transform.position.x > 0 && move_Obj.gameObject.transform.position.y == 1.8f)
        {
            gameObject.transform.rotation = Quaternion.Euler(0, 0, 180);
        }
        else if (move_Obj.gameObject.transform.position.x == -1.8f && move_Obj.gameObject.transform.position.y > 0)
        {
            gameObject.transform.rotation = Quaternion.Euler(0, 0, 180);
        }
        else if (move_Obj.gameObject.transform.position.x == 0 && move_Obj.gameObject.transform.position.y > 0)
        {
            ran_Dir = Random.Range(0, 2);
            if (ran_Dir == 0)
                gameObject.transform.rotation = Quaternion.Euler(0, 0, -180);
            else
                gameObject.transform.rotation = Quaternion.Euler(0, 0, 180);
        }
        else if (move_Obj.gameObject.transform.position.x == 1.8f && move_Obj.gameObject.transform.position.y > 0)
        {
            gameObject.transform.rotation = Quaternion.Euler(0, 0, -180);
        }
    }

}
