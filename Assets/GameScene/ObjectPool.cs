using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPool : MonoBehaviour
{
    GameObject[] targetPool;

    public GameObject laser_Prefab;
    GameObject[] laser;

    public GameObject square_Prefab;
    GameObject[] square;

    public GameObject starBlock_Prefab;
    GameObject[] starBlock;

    public GameObject dropBlock_Prefab;
    GameObject[] dropBlock;

    public GameObject diaBlock_Prefab;
    GameObject[] diaBlock;

    public GameObject turnBlock_Prefab;
    GameObject[] turnBlock;

    public GameObject bigBlock_Prefab;
    GameObject[] bigBlock;

    public GameObject lineBlock_Prefab;
    GameObject[] lineBlock;

    public GameObject speed_Fast_Block_Prefab;
    GameObject[] speed_Fast_Block;
    public GameObject speed_Slow_Block_Prefab;
    GameObject[] speed_Slow_Block;

    public GameObject smoothBlock_Prefab;
    GameObject[] smoothBlock;

    public GameObject rbrBlock_Prefab;
    GameObject[] rbrBlock;

    public GameObject cannonBlock_Prefab;
    GameObject[] cannonBlock;

    public GameObject heartBlock_Prefab;
    GameObject[] heartBlock;

    public GameObject moveBlock_Prefab;
    GameObject[] moveBlock;

    public GameObject viewBlock_Prefab;
    GameObject[] viewBlock;

    private void Awake()
    {
        laser = new GameObject[5];
        square = new GameObject[20];
        starBlock = new GameObject[30];
        dropBlock = new GameObject[20];
        diaBlock = new GameObject[50];
        turnBlock = new GameObject[50];
        bigBlock = new GameObject[30];
        lineBlock = new GameObject[20];
        speed_Fast_Block = new GameObject[30];
        speed_Slow_Block = new GameObject[30];
        smoothBlock = new GameObject[30];
        rbrBlock = new GameObject[30];
        cannonBlock = new GameObject[30];
        heartBlock = new GameObject[20];
        moveBlock = new GameObject[20];
        viewBlock = new GameObject[60];

        Generate();
    }
    void Generate()
    {
        for (int index = 0; index < laser.Length; index++)
        {
            laser[index] = Instantiate(laser_Prefab);
            laser[index].SetActive(false);
        }
        for (int index = 0; index < square.Length; index++)
        {
            square[index] = Instantiate(square_Prefab);
            square[index].SetActive(false);
        }
        for (int index = 0; index < starBlock.Length; index++)
        {
            starBlock[index] = Instantiate(starBlock_Prefab);
            starBlock[index].SetActive(false);
        }
        for (int index = 0; index < dropBlock.Length; index++)
        {
            dropBlock[index] = Instantiate(dropBlock_Prefab);
            dropBlock[index].SetActive(false);
        }
        for (int index = 0; index < diaBlock.Length; index++)
        {
            diaBlock[index] = Instantiate(diaBlock_Prefab);
            diaBlock[index].SetActive(false);
        }
        for (int index = 0; index < turnBlock.Length; index++)
        {
            turnBlock[index] = Instantiate(turnBlock_Prefab);
            turnBlock[index].SetActive(false);
        }
        for (int index = 0; index < bigBlock.Length; index++)
        {
            bigBlock[index] = Instantiate(bigBlock_Prefab);
            bigBlock[index].SetActive(false);
        }
        for (int index = 0; index < lineBlock.Length; index++)
        {
            lineBlock[index] = Instantiate(lineBlock_Prefab);
            lineBlock[index].SetActive(false);
        }
        for (int index = 0; index < speed_Fast_Block.Length; index++)
        {
            speed_Fast_Block[index] = Instantiate(speed_Fast_Block_Prefab);
            speed_Fast_Block[index].SetActive(false);
        }
        for (int index = 0; index < speed_Slow_Block.Length; index++)
        {
            speed_Slow_Block[index] = Instantiate(speed_Slow_Block_Prefab);
            speed_Slow_Block[index].SetActive(false);
        }
        for (int index = 0; index < smoothBlock.Length; index++)
        {
            smoothBlock[index] = Instantiate(smoothBlock_Prefab);
            smoothBlock[index].SetActive(false);
        }
        for (int index = 0; index < rbrBlock.Length; index++)
        {
            rbrBlock[index] = Instantiate(rbrBlock_Prefab);
            rbrBlock[index].SetActive(false);
        }
        for (int index = 0; index < cannonBlock.Length; index++)
        {
            cannonBlock[index] = Instantiate(cannonBlock_Prefab);
            cannonBlock[index].SetActive(false);
        }
        for (int index = 0; index < heartBlock.Length; index++)
        {
            heartBlock[index] = Instantiate(heartBlock_Prefab);
            heartBlock[index].SetActive(false);
        }
        for (int index = 0; index < moveBlock.Length; index++)
        {
            moveBlock[index] = Instantiate(moveBlock_Prefab);
            moveBlock[index].SetActive(false);
        }
        for (int index = 0; index < viewBlock.Length; index++)
        {
            viewBlock[index] = Instantiate(viewBlock_Prefab);
            viewBlock[index].SetActive(false);
        }
    }

    public GameObject MakeObj(string type)
    {
        switch (type)
        {
            case "Laser":
                targetPool = laser;  //积己秦扼
                break;
            case "Square":
                targetPool = square;  //积己秦扼
                break;
            case "StarBlock":
                targetPool = starBlock;  //积己秦扼
                break;
            case "DropBlock":
                targetPool = dropBlock;  //积己秦扼
                break;
            case "DiaBlock":
                targetPool = diaBlock;  //积己秦扼
                break;
            case "TurnBlock":
                targetPool = turnBlock;  //积己秦扼
                break;
            case "BigBlock":
                targetPool = bigBlock;  //积己秦扼
                break;
            case "LineBlock":
                targetPool = lineBlock;  //积己秦扼
                break;
            case "SpeedFastBlock":
                targetPool = speed_Fast_Block;  //积己秦扼
                break;
            case "SpeedSlowBlock":
                targetPool = speed_Slow_Block;  //积己秦扼
                break;
            case "SmoothBlock":
                targetPool = smoothBlock;  //积己秦扼
                break;
            case "RBRBlock":
                targetPool = rbrBlock;  //积己秦扼
                break;
            case "CannonBlock":
                targetPool = cannonBlock;  //积己秦扼
                break;
            case "HeartBlock":
                targetPool = heartBlock;  //积己秦扼
                break;
            case "MoveBlock":
                targetPool = moveBlock;  //积己秦扼
                break;
            case "ViewBlock":
                targetPool = viewBlock;  //积己秦扼
                break;
        }
        for (int index = 0; index < targetPool.Length; index++)
        {
            if (!targetPool[index].activeSelf)
            {
                targetPool[index].SetActive(true);
                return targetPool[index];
            }
        }
        return null;
    }
}
