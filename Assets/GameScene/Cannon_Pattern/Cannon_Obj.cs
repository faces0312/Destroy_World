using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cannon_Obj : MonoBehaviour
{
    public GameObject cannon1_1;
    public GameObject cannon1_2;
    public GameObject cannon2_1;
    public GameObject cannon2_2;

    public Vector3 cannon_pos1;
    public Vector3 cannon_pos2;
    public Vector3 cannon_pos3;
    public Vector3 cannon_pos4;

    private void OnEnable()
    {
        cannon1_1.gameObject.transform.position = new Vector3(0, 4.2f);
        cannon1_2.gameObject.transform.position = new Vector3(0, -4.2f);
        cannon2_1.gameObject.transform.position = new Vector3(4.2f, 0);
        cannon2_2.gameObject.transform.position = new Vector3(-4.2f, 0);

        cannon_pos1 = new Vector3(0, 4.2f);
        cannon_pos2 = new Vector3(0, -4.2f);
        cannon_pos3 = new Vector3(4.2f, 0);
        cannon_pos4 = new Vector3(-4.2f, 0);
    }

    private void Update()
    {
        cannon1_1.transform.position = Vector3.MoveTowards(cannon1_1.transform.position, cannon_pos1, 3 * Time.deltaTime);
        cannon1_2.transform.position = Vector3.MoveTowards(cannon1_2.transform.position, cannon_pos2, 3 * Time.deltaTime);
        cannon2_1.transform.position = Vector3.MoveTowards(cannon2_1.transform.position, cannon_pos3, 3 * Time.deltaTime);
        cannon2_2.transform.position = Vector3.MoveTowards(cannon2_2.transform.position, cannon_pos4, 3 * Time.deltaTime);
    }
}
