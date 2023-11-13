using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Leaf_Obj : MonoBehaviour
{
    int dir;
    public Vector3 left_Pos;
    public Vector3 right_Pos;

    // Start is called before the first frame update
    void Start()
    {
        dir = 0;
        left_Pos = new Vector3(-4, 5);
        right_Pos = new Vector3(4, 5);
    }

    // Update is called once per frame
    void Update()
    {
        if(dir == 0 )
        {
            transform.position = Vector3.Slerp(transform.position, left_Pos, 1.5f * Time.deltaTime);
            if (transform.position == left_Pos)
                dir = 1;
        }

        if (dir == 1)
        {
            transform.position = Vector3.Slerp(transform.position, right_Pos, 1.5f * Time.deltaTime);
            if (transform.position == right_Pos)
                dir = 0;
        }
    }
}
