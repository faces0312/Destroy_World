using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectManager : MonoBehaviour
{
    public Manager manager;
    public ObjectPool objectPool;

    public GameObject[] box;//box 위치

    //레이저 패턴
    private string[] laser;
    //박스 패턴
    private string[] square;
    int[] square_array;
    //X 패턴
    public GameObject x_Obj;
    public GameObject x;
    public GameObject[] x_change;
    public GameObject[] x_red;
    public GameObject[] x_gray;
    public GameObject x_Sample;
    public GameObject[] x_Sample_red;
    public GameObject[] x_Sample_gray;
    int[] x_array;
    public int x_cnt;
    //별 패턴
    private string[] starBlock;
    public GameObject star_Obj;
    //드랍 패턴
    private string[] dropBlock;
    public GameObject drop_Obj;
    public GameObject[] drop_StartPos;
    int drop_ran_pos;
    //다이아 패턴
    private string[] diaBlock;
    public GameObject dia_Obj;
    public GameObject[] dia_StartPos;
    int dia_ran_pos;
    //회전 패턴
    private string[] turnBlock;
    int[] turn_array;
    public GameObject turn_Obj;
    public GameObject[] turn_StartPos;
    //화살표패턴
    public int arrow_cnt;
    public Arrow_Obj arrow_Obj;
    public GameObject arrow;
    public GameObject arrow_user;
    //커짐 패턴
    private string[] bigBlock;
    public GameObject big_Obj;
    int big_ran;
    //줄 패턴
    private string[] lineBlock;
    //스피드 패턴
    private string[] speedBlock;
    int speed_ran;
    int speed_ran_pos;
    //사르르 탄 패턴
    public GameObject smooth_Obj;
    private string[] smoothBlock;
    int smooth_ran_pos;
    //똑딱 패턴
    public GameObject tictoc_Obj;
    //RBR 패턴
    public GameObject rbr_Obj;
    public GameObject[] rbr_Obj_block;
    private string[] rbrBlock;
    public int rbr_ran;
    int[] rbr_array;
    //팬 패턴
    public GameObject fan_Obj;
    //캐논 패턴
    public Cannon_Obj cannon_Obj;
    private string[] cannonBlock;
    int[] cannon_array;
    public int cannon_ran;
    //하트 패턴
    public GameObject heart_Obj;
    private string[] heartBlock;
    int heart_ran;
    //움직임 패턴
    private string[] moveBlock;
    int move_ran;
    //오프화이트 패턴
    public GameObject offWhite_Obj;
    //트리플 패턴
    public GameObject tripple_Obj;
    //시점 패턴
    public GameObject view_Camera;
    private string[] viewBlock;
    int view_ran;

    private void Awake()
    {
        laser = new string[] { "Laser" };

        square = new string[] { "Square" };

        starBlock = new string[] { "StarBlock" };

        dropBlock = new string[] { "DropBlock" };

        diaBlock = new string[] { "DiaBlock" };

        turnBlock = new string[] { "TurnBlock" };

        bigBlock = new string[] { "BigBlock" };

        lineBlock = new string[] { "LineBlock" };

        speedBlock = new string[] { "SpeedFastBlock", "SpeedSlowBlock" };

        smoothBlock = new string[] { "SmoothBlock" };

        rbrBlock = new string[] { "RBRBlock" };

        cannonBlock = new string[] { "CannonBlock" };

        heartBlock = new string[] { "HeartBlock" };

        moveBlock = new string[] { "MoveBlock" };
        
        viewBlock = new string[] { "ViewBlock" };

        x_Sample.gameObject.SetActive(false);
        x_cnt = 4;

        star_Obj.gameObject.SetActive(false);

        drop_Obj.gameObject.SetActive(false);

        dia_Obj.gameObject.SetActive(false);

        turn_Obj.gameObject.SetActive(false);

        arrow_cnt = 3;
        arrow_Obj.gameObject.SetActive(false);

        big_Obj.gameObject.SetActive(false);

        smooth_Obj.gameObject.SetActive(false);

        tictoc_Obj.gameObject.SetActive(false);

        rbr_Obj.gameObject.SetActive(false);

        fan_Obj.gameObject.SetActive(false);

        cannon_Obj.gameObject.SetActive(false);

        heart_Obj.gameObject.SetActive(false);

        offWhite_Obj.gameObject.SetActive(false);

        tripple_Obj.gameObject.SetActive(false);

        view_Camera.gameObject.SetActive(false);
    }

    public void LaserPattern()
    {
        StartCoroutine(nameof(Laser16));
    }
    public void SquarePattern()
    {
        StartCoroutine(nameof(Square8));
    }
    public void XPattern()
    {
        //초기화
        x_Obj.gameObject.SetActive(false);
        x_Obj.gameObject.SetActive(true);
        x.gameObject.SetActive(true);
        x_Sample.gameObject.SetActive(true);
        for (int j = 0; j < 9; j++)
        {
            x_change[j].gameObject.SetActive(false);
            x_red[j].gameObject.SetActive(false);
            x_gray[j].gameObject.SetActive(false);
            x_Sample_red[j].gameObject.SetActive(false);
            x_Sample_gray[j].gameObject.SetActive(false);
        }
        x_array = new int[9] { 0, 1, 2, 3, 4, 5, 6, 7, 8 };
        //

        for (int j = 0; j < 4; j++)
        {
            int x_ran;//배열의 몇번째
            int x_num;//결정된 번호
            do
            {
                x_ran = Random.Range(0, 9);
            } while (x_array[x_ran] == 100);

            x_num = x_array[x_ran];
            x_array[x_ran] = 100;

            x_change[x_num].gameObject.SetActive(true);

            int ran_sample;
            ran_sample = Random.Range(0, 2);
            if (ran_sample == 0)
                x_Sample_red[x_num].gameObject.SetActive(true);
            else
                x_Sample_gray[x_num].gameObject.SetActive(true);

            int ran_x;
            ran_x = Random.Range(0, 2);
            if (ran_x == 0)
                x_red[x_num].gameObject.SetActive(true);
            else
                x_gray[x_num].gameObject.SetActive(true);
        }
        
    }
    public void StarPattern()
    {
        star_Obj.gameObject.SetActive(true);
        StartCoroutine(nameof(Star10));
    }
    public void DropPattern()
    {
        drop_Obj.gameObject.SetActive(true);
        StartCoroutine(nameof(Drop10));
    }
    public void DiaPattern()
    {
        dia_Obj.gameObject.SetActive(true);
        StartCoroutine(nameof(StartDia));
    }
    public void TurnPattern()
    {
        turn_Obj.gameObject.SetActive(true);
        StartCoroutine(nameof(Turn6));
    }
    public void ArrowPattern()
    {
        if(arrow_cnt == 0)
        {
            manager.Explain();
            arrow_cnt = 3;
            return;
        }
        else
        {
            arrow_cnt--;
            StartCoroutine(nameof(Start_Arrow));
        }
    }
    public void BigPattern()
    {
        big_Obj.gameObject.SetActive(true);
        StartCoroutine(nameof(Big15));
    }
    public void LinePattern()
    {
        StartCoroutine(nameof(Line10));
    }
    public void SpeedPattern()
    {
        StartCoroutine(nameof(Speed30));
    }
    public void SmoothPattern()
    {
        smooth_Obj.gameObject.SetActive(true);
        StartCoroutine(nameof(Smooth28));
    }
    public void TictocPattern()
    {
        tictoc_Obj.gameObject.SetActive(true);
        StartCoroutine(nameof(Tictoc1));
    }
    public void RBRPattern()
    {
        rbr_Obj.gameObject.SetActive(true);
        rbr_array = new int[3] { 0, 1, 2 };
        StartCoroutine(nameof(RBR9));
    }
    public void FanPattern()
    {
        fan_Obj.gameObject.SetActive(true);
    }
    public void CannonPattern()
    {
        cannon_Obj.gameObject.SetActive(true);
        StartCoroutine(nameof(Cannon_Move));
    }
    public void HeartPattern()
    {
        heart_Obj.gameObject.SetActive(true);
        StartCoroutine(nameof(Heart15));
    }
    public void MovePattern()
    {
        StartCoroutine(nameof(Move15));
    }
    public void OffWhitePattern()
    {
        offWhite_Obj.gameObject.SetActive(true);
    }
    public void TripplePattern()
    {
        tripple_Obj.gameObject.SetActive(true);
    }
    public void ViewPattern()
    {
        view_Camera.gameObject.transform.localPosition = new Vector3(0, 0, -10);
        view_Camera.gameObject.transform.rotation = Quaternion.Euler(0, 0, 0);
        view_Camera.gameObject.SetActive(true);
        manager.game_Camera.gameObject.SetActive(false);

        StartCoroutine(nameof(View_Camera_Move));
    }

    IEnumerator Laser16()
    {
        GameObject laser1;
        laser1 = objectPool.MakeObj(laser[0]);
        laser1.gameObject.transform.position = new Vector3(-1.8f, 0);
        laser1.gameObject.transform.eulerAngles = new Vector3(0, 0, 0);
        yield return new WaitForSeconds(0.8f);
        GameObject laser2;
        laser2 = objectPool.MakeObj(laser[0]);
        laser2.gameObject.transform.position = new Vector3(0, 0);
        laser2.gameObject.transform.eulerAngles = new Vector3(0, 0, 0);
        yield return new WaitForSeconds(0.8f);
        GameObject laser3;
        laser3 = objectPool.MakeObj(laser[0]);
        laser3.gameObject.transform.position = new Vector3(1.8f, 0);
        laser3.gameObject.transform.eulerAngles = new Vector3(0, 0, 0);
        yield return new WaitForSeconds(0.8f);
        GameObject laser4;
        laser4 = objectPool.MakeObj(laser[0]);
        laser4.gameObject.transform.position = new Vector3(0, 0);
        laser4.gameObject.transform.eulerAngles = new Vector3(0, 0, -45);
        yield return new WaitForSeconds(0.8f);
        GameObject laser5;
        laser5 = objectPool.MakeObj(laser[0]);
        laser5.gameObject.transform.position = new Vector3(0, 1.8f);
        laser5.gameObject.transform.eulerAngles = new Vector3(0, 0, -90);
        yield return new WaitForSeconds(0.8f);
        GameObject laser6;
        laser6 = objectPool.MakeObj(laser[0]);
        laser6.gameObject.transform.position = new Vector3(0, 0);
        laser6.gameObject.transform.eulerAngles = new Vector3(0, 0, -90);
        yield return new WaitForSeconds(0.8f);
        GameObject laser7;
        laser7 = objectPool.MakeObj(laser[0]);
        laser7.gameObject.transform.position = new Vector3(0, -1.8f);
        laser7.gameObject.transform.eulerAngles = new Vector3(0, 0, -90);
        yield return new WaitForSeconds(0.8f);
        GameObject laser8;
        laser8 = objectPool.MakeObj(laser[0]);
        laser8.gameObject.transform.position = new Vector3(0, 0);
        laser8.gameObject.transform.eulerAngles = new Vector3(0, 0, -135);
        yield return new WaitForSeconds(0.8f);
        GameObject laser9;
        laser9 = objectPool.MakeObj(laser[0]);
        laser9.gameObject.transform.position = new Vector3(1.8f, 0);
        laser9.gameObject.transform.eulerAngles = new Vector3(0, 0, 180);
        yield return new WaitForSeconds(0.8f);
        GameObject laser10;
        laser10 = objectPool.MakeObj(laser[0]);
        laser10.gameObject.transform.position = new Vector3(0, 0);
        laser10.gameObject.transform.eulerAngles = new Vector3(0, 0, 180);
        yield return new WaitForSeconds(0.8f);
        GameObject laser11;
        laser11 = objectPool.MakeObj(laser[0]);
        laser11.gameObject.transform.position = new Vector3(-1.8f, 0);
        laser11.gameObject.transform.eulerAngles = new Vector3(0, 0, 180);
        yield return new WaitForSeconds(0.8f);
        GameObject laser12;
        laser12 = objectPool.MakeObj(laser[0]);
        laser12.gameObject.transform.position = new Vector3(0, 0);
        laser12.gameObject.transform.eulerAngles = new Vector3(0, 0, -225);
        yield return new WaitForSeconds(0.8f);
        GameObject laser13;
        laser13 = objectPool.MakeObj(laser[0]);
        laser13.gameObject.transform.position = new Vector3(0, -1.8f);
        laser13.gameObject.transform.eulerAngles = new Vector3(0, 0, 90);
        yield return new WaitForSeconds(0.8f);
        GameObject laser14;
        laser14 = objectPool.MakeObj(laser[0]);
        laser14.gameObject.transform.position = new Vector3(0, 0);
        laser14.gameObject.transform.eulerAngles = new Vector3(0, 0, 90);
        yield return new WaitForSeconds(0.8f);
        GameObject laser15;
        laser15= objectPool.MakeObj(laser[0]);
        laser15.gameObject.transform.position = new Vector3(0, 1.8f);
        laser15.gameObject.transform.eulerAngles = new Vector3(0, 0, 90);
        yield return new WaitForSeconds(0.8f);
        GameObject laser16;
        laser16 = objectPool.MakeObj(laser[0]);
        laser16.gameObject.transform.position = new Vector3(0, 0);
        laser16.gameObject.transform.eulerAngles = new Vector3(0, 0, 45);
        yield return new WaitForSeconds(2.5f);
        manager.Explain();
    }

    IEnumerator Square8()
    {
        for(int i =0; i<8; i++)
        {
            manager.square_Pattern.Stop();
            manager.square_Pattern.Play();

            square_array = new int[9] { 0, 1, 2, 3, 4, 5, 6, 7, 8 };
            
            for(int j = 0; j <4; j++)
            {
                int square_num;//결정된 번호
                int square_ran;//배열의 몇번째

                do
                {
                    square_ran = Random.Range(0, 9);
                } while (square_array[square_ran] == 100);
                
                square_num = square_array[square_ran];
                square_array[square_ran] = 100;

                GameObject square_obj;
                square_obj = objectPool.MakeObj(square[0]);
                square_obj.gameObject.transform.position = box[square_num].gameObject.transform.position;
            }

            yield return new WaitForSeconds(1f);
        }

        yield return new WaitForSeconds(1f);
        manager.Explain();
    }

    IEnumerator Star10()
    {
        GameObject starblock1;
        starblock1 = objectPool.MakeObj(starBlock[0]);
        starblock1.gameObject.transform.position = new Vector3(10, 0);
        yield return new WaitForSeconds(1.2f);
        GameObject starblock2;
        starblock2 = objectPool.MakeObj(starBlock[0]);
        starblock2.gameObject.transform.position = new Vector3(10, 0);
        yield return new WaitForSeconds(1.2f);
        GameObject starblock3;
        starblock3 = objectPool.MakeObj(starBlock[0]);
        starblock3.gameObject.transform.position = new Vector3(10, 0);
        yield return new WaitForSeconds(1.2f);
        GameObject starblock4;
        starblock4 = objectPool.MakeObj(starBlock[0]);
        starblock4.gameObject.transform.position = new Vector3(10, 0);
        yield return new WaitForSeconds(1.2f);
        GameObject starblock5;
        starblock5 = objectPool.MakeObj(starBlock[0]);
        starblock5.gameObject.transform.position = new Vector3(10, 0);
        yield return new WaitForSeconds(1.2f);
        GameObject starblock6;
        starblock6 = objectPool.MakeObj(starBlock[0]);
        starblock6.gameObject.transform.position = new Vector3(10, 0);
        yield return new WaitForSeconds(1.2f);
        GameObject starblock7;
        starblock7 = objectPool.MakeObj(starBlock[0]);
        starblock7.gameObject.transform.position = new Vector3(10, 0);
        yield return new WaitForSeconds(1.2f);
        GameObject starblock8;
        starblock8 = objectPool.MakeObj(starBlock[0]);
        starblock8.gameObject.transform.position = new Vector3(10, 0);
        yield return new WaitForSeconds(1.2f);
        GameObject starblock9;
        starblock9 = objectPool.MakeObj(starBlock[0]);
        starblock9.gameObject.transform.position = new Vector3(10, 0);
        yield return new WaitForSeconds(1.2f);
        GameObject starblock10;
        starblock10 = objectPool.MakeObj(starBlock[0]);
        starblock10.gameObject.transform.position = new Vector3(10, 0);
        yield return new WaitForSeconds(1.2f);

        yield return new WaitForSeconds(2f);
        star_Obj.gameObject.SetActive(false);
        yield return new WaitForSeconds(1.5f);
        manager.Explain();
    }

    IEnumerator Drop10()
    {
        manager.drop_Pattern.Stop();
        manager.drop_Pattern.Play();

        GameObject dropblock1;
        dropblock1 = objectPool.MakeObj(dropBlock[0]);
        drop_ran_pos = Random.Range(0, 3);
        dropblock1.gameObject.transform.position = drop_StartPos[drop_ran_pos].gameObject.transform.position;
        yield return new WaitForSeconds(0.8f);

        manager.drop_Pattern.Stop();
        manager.drop_Pattern.Play();

        GameObject dropblock2;
        dropblock2 = objectPool.MakeObj(dropBlock[0]);
        drop_ran_pos = Random.Range(0, 3);
        dropblock2.gameObject.transform.position = drop_StartPos[drop_ran_pos].gameObject.transform.position;
        yield return new WaitForSeconds(0.8f);

        manager.drop_Pattern.Stop();
        manager.drop_Pattern.Play();

        GameObject dropblock3;
        dropblock3 = objectPool.MakeObj(dropBlock[0]);
        drop_ran_pos = Random.Range(0, 3);
        dropblock3.gameObject.transform.position = drop_StartPos[drop_ran_pos].gameObject.transform.position;
        yield return new WaitForSeconds(0.8f);

        manager.drop_Pattern.Stop();
        manager.drop_Pattern.Play();

        GameObject dropblock4;
        dropblock4 = objectPool.MakeObj(dropBlock[0]);
        drop_ran_pos = Random.Range(0, 3);
        dropblock4.gameObject.transform.position = drop_StartPos[drop_ran_pos].gameObject.transform.position;
        yield return new WaitForSeconds(0.8f);

        manager.drop_Pattern.Stop();
        manager.drop_Pattern.Play();

        GameObject dropblock5;
        dropblock5 = objectPool.MakeObj(dropBlock[0]);
        drop_ran_pos = Random.Range(0, 3);
        dropblock5.gameObject.transform.position = drop_StartPos[drop_ran_pos].gameObject.transform.position;
        yield return new WaitForSeconds(0.8f);

        manager.drop_Pattern.Stop();
        manager.drop_Pattern.Play();

        GameObject dropblock6;
        dropblock6 = objectPool.MakeObj(dropBlock[0]);
        drop_ran_pos = Random.Range(0, 3);
        dropblock6.gameObject.transform.position = drop_StartPos[drop_ran_pos].gameObject.transform.position;
        yield return new WaitForSeconds(0.8f);

        manager.drop_Pattern.Stop();
        manager.drop_Pattern.Play();

        GameObject dropblock7;
        dropblock7 = objectPool.MakeObj(dropBlock[0]);
        drop_ran_pos = Random.Range(0, 3);
        dropblock7.gameObject.transform.position = drop_StartPos[drop_ran_pos].gameObject.transform.position;
        yield return new WaitForSeconds(0.8f);

        manager.drop_Pattern.Stop();
        manager.drop_Pattern.Play();

        GameObject dropblock8;
        dropblock8 = objectPool.MakeObj(dropBlock[0]);
        drop_ran_pos = Random.Range(0, 3);
        dropblock8.gameObject.transform.position = drop_StartPos[drop_ran_pos].gameObject.transform.position;
        yield return new WaitForSeconds(0.8f);

        manager.drop_Pattern.Stop();
        manager.drop_Pattern.Play();

        GameObject dropblock9;
        dropblock9 = objectPool.MakeObj(dropBlock[0]);
        drop_ran_pos = Random.Range(0, 3);
        dropblock9.gameObject.transform.position = drop_StartPos[drop_ran_pos].gameObject.transform.position;
        yield return new WaitForSeconds(0.8f);

        manager.drop_Pattern.Stop();
        manager.drop_Pattern.Play();

        GameObject dropblock10;
        dropblock10 = objectPool.MakeObj(dropBlock[0]);
        drop_ran_pos = Random.Range(0, 3);
        dropblock10.gameObject.transform.position = drop_StartPos[drop_ran_pos].gameObject.transform.position;
        yield return new WaitForSeconds(1.5f);

        drop_Obj.gameObject.SetActive(false);

        yield return new WaitForSeconds(2f);
        manager.Explain();
    }

    IEnumerator StartDia()
    {
        for(int i =0; i< 45; i++)
        {
            
            manager.game_Camera.transform.rotation = Quaternion.Euler(0, 0, i);
            yield return new WaitForSeconds(0.03f);
        }
        manager.game_Camera.transform.rotation = Quaternion.Euler(0, 0, 45);
        StartCoroutine(nameof(Dia20));
    }
    IEnumerator Dia20()
    {
        manager.drop_Pattern.Stop();
        manager.drop_Pattern.Play();

        GameObject diablock1;
        diablock1 = objectPool.MakeObj(diaBlock[0]);
        dia_ran_pos = Random.Range(0, 12);
        diablock1.gameObject.transform.position = dia_StartPos[dia_ran_pos].gameObject.transform.position;
        if(dia_ran_pos == 0 || dia_ran_pos == 1 || dia_ran_pos == 2)
            diablock1.transform.rotation = Quaternion.Euler(0,0,90);
        else if (dia_ran_pos == 3 || dia_ran_pos == 5 || dia_ran_pos == 7)
            diablock1.transform.rotation = Quaternion.Euler(0, 0, 0);
        else if (dia_ran_pos == 4 || dia_ran_pos == 6 || dia_ran_pos == 8)
            diablock1.transform.rotation = Quaternion.Euler(0, 0, 180);
        else if (dia_ran_pos == 9 || dia_ran_pos == 10 || dia_ran_pos == 11)
            diablock1.transform.rotation = Quaternion.Euler(0, 0, -90);
        yield return new WaitForSeconds(0.6f);

        manager.drop_Pattern.Stop();
        manager.drop_Pattern.Play();

        GameObject diablock2;
        diablock2 = objectPool.MakeObj(diaBlock[0]);
        dia_ran_pos = Random.Range(0, 12);
        diablock2.gameObject.transform.position = dia_StartPos[dia_ran_pos].gameObject.transform.position;
        if (dia_ran_pos == 0 || dia_ran_pos == 1 || dia_ran_pos == 2)
            diablock2.transform.rotation = Quaternion.Euler(0, 0, 90);
        else if (dia_ran_pos == 3 || dia_ran_pos == 5 || dia_ran_pos == 7)
            diablock2.transform.rotation = Quaternion.Euler(0, 0, 0);
        else if (dia_ran_pos == 4 || dia_ran_pos == 6 || dia_ran_pos == 8)
            diablock2.transform.rotation = Quaternion.Euler(0, 0, 180);
        else if (dia_ran_pos == 9 || dia_ran_pos == 10 || dia_ran_pos == 11)
            diablock2.transform.rotation = Quaternion.Euler(0, 0, -90);
        yield return new WaitForSeconds(0.6f);
        manager.drop_Pattern.Stop();
        manager.drop_Pattern.Play();

        GameObject diablock3;
        diablock3 = objectPool.MakeObj(diaBlock[0]);
        dia_ran_pos = Random.Range(0, 12);
        diablock3.gameObject.transform.position = dia_StartPos[dia_ran_pos].gameObject.transform.position;
        if (dia_ran_pos == 0 || dia_ran_pos == 1 || dia_ran_pos == 2)
            diablock3.transform.rotation = Quaternion.Euler(0, 0, 90);
        else if (dia_ran_pos == 3 || dia_ran_pos == 5 || dia_ran_pos == 7)
            diablock3.transform.rotation = Quaternion.Euler(0, 0, 0);
        else if (dia_ran_pos == 4 || dia_ran_pos == 6 || dia_ran_pos == 8)
            diablock3.transform.rotation = Quaternion.Euler(0, 0, 180);
        else if (dia_ran_pos == 9 || dia_ran_pos == 10 || dia_ran_pos == 11)
            diablock3.transform.rotation = Quaternion.Euler(0, 0, -90);
        yield return new WaitForSeconds(0.6f);
        manager.drop_Pattern.Stop();
        manager.drop_Pattern.Play();

        GameObject diablock4;
        diablock4 = objectPool.MakeObj(diaBlock[0]);
        dia_ran_pos = Random.Range(0, 12);
        diablock4.gameObject.transform.position = dia_StartPos[dia_ran_pos].gameObject.transform.position;
        if (dia_ran_pos == 0 || dia_ran_pos == 1 || dia_ran_pos == 2)
            diablock4.transform.rotation = Quaternion.Euler(0, 0, 90);
        else if (dia_ran_pos == 3 || dia_ran_pos == 5 || dia_ran_pos == 7)
            diablock4.transform.rotation = Quaternion.Euler(0, 0, 0);
        else if (dia_ran_pos == 4 || dia_ran_pos == 6 || dia_ran_pos == 8)
            diablock4.transform.rotation = Quaternion.Euler(0, 0, 180);
        else if (dia_ran_pos == 9 || dia_ran_pos == 10 || dia_ran_pos == 11)
            diablock4.transform.rotation = Quaternion.Euler(0, 0, -90);
        yield return new WaitForSeconds(0.6f);
        manager.drop_Pattern.Stop();
        manager.drop_Pattern.Play();

        GameObject diablock5;
        diablock5 = objectPool.MakeObj(diaBlock[0]);
        dia_ran_pos = Random.Range(0, 12);
        diablock5.gameObject.transform.position = dia_StartPos[dia_ran_pos].gameObject.transform.position;
        if (dia_ran_pos == 0 || dia_ran_pos == 1 || dia_ran_pos == 2)
            diablock5.transform.rotation = Quaternion.Euler(0, 0, 90);
        else if (dia_ran_pos == 3 || dia_ran_pos == 5 || dia_ran_pos == 7)
            diablock5.transform.rotation = Quaternion.Euler(0, 0, 0);
        else if (dia_ran_pos == 4 || dia_ran_pos == 6 || dia_ran_pos == 8)
            diablock5.transform.rotation = Quaternion.Euler(0, 0, 180);
        else if (dia_ran_pos == 9 || dia_ran_pos == 10 || dia_ran_pos == 11)
            diablock5.transform.rotation = Quaternion.Euler(0, 0, -90);
        yield return new WaitForSeconds(0.6f);
        manager.drop_Pattern.Stop();
        manager.drop_Pattern.Play();

        GameObject diablock6;
        diablock6 = objectPool.MakeObj(diaBlock[0]);
        dia_ran_pos = Random.Range(0, 12);
        diablock6.gameObject.transform.position = dia_StartPos[dia_ran_pos].gameObject.transform.position;
        if (dia_ran_pos == 0 || dia_ran_pos == 1 || dia_ran_pos == 2)
            diablock6.transform.rotation = Quaternion.Euler(0, 0, 90);
        else if (dia_ran_pos == 3 || dia_ran_pos == 5 || dia_ran_pos == 7)
            diablock6.transform.rotation = Quaternion.Euler(0, 0, 0);
        else if (dia_ran_pos == 4 || dia_ran_pos == 6 || dia_ran_pos == 8)
            diablock6.transform.rotation = Quaternion.Euler(0, 0, 180);
        else if (dia_ran_pos == 9 || dia_ran_pos == 10 || dia_ran_pos == 11)
            diablock6.transform.rotation = Quaternion.Euler(0, 0, -90);
        yield return new WaitForSeconds(0.6f);
        manager.drop_Pattern.Stop();
        manager.drop_Pattern.Play();

        GameObject diablock7;
        diablock7 = objectPool.MakeObj(diaBlock[0]);
        dia_ran_pos = Random.Range(0, 12);
        diablock7.gameObject.transform.position = dia_StartPos[dia_ran_pos].gameObject.transform.position;
        if (dia_ran_pos == 0 || dia_ran_pos == 1 || dia_ran_pos == 2)
            diablock7.transform.rotation = Quaternion.Euler(0, 0, 90);
        else if (dia_ran_pos == 3 || dia_ran_pos == 5 || dia_ran_pos == 7)
            diablock7.transform.rotation = Quaternion.Euler(0, 0, 0);
        else if (dia_ran_pos == 4 || dia_ran_pos == 6 || dia_ran_pos == 8)
            diablock7.transform.rotation = Quaternion.Euler(0, 0, 180);
        else if (dia_ran_pos == 9 || dia_ran_pos == 10 || dia_ran_pos == 11)
            diablock7.transform.rotation = Quaternion.Euler(0, 0, -90);
        yield return new WaitForSeconds(0.6f);
        manager.drop_Pattern.Stop();
        manager.drop_Pattern.Play();

        GameObject diablock8;
        diablock8 = objectPool.MakeObj(diaBlock[0]);
        dia_ran_pos = Random.Range(0, 12);
        diablock8.gameObject.transform.position = dia_StartPos[dia_ran_pos].gameObject.transform.position;
        if (dia_ran_pos == 0 || dia_ran_pos == 1 || dia_ran_pos == 2)
            diablock8.transform.rotation = Quaternion.Euler(0, 0, 90);
        else if (dia_ran_pos == 3 || dia_ran_pos == 5 || dia_ran_pos == 7)
            diablock8.transform.rotation = Quaternion.Euler(0, 0, 0);
        else if (dia_ran_pos == 4 || dia_ran_pos == 6 || dia_ran_pos == 8)
            diablock8.transform.rotation = Quaternion.Euler(0, 0, 180);
        else if (dia_ran_pos == 9 || dia_ran_pos == 10 || dia_ran_pos == 11)
            diablock8.transform.rotation = Quaternion.Euler(0, 0, -90);
        yield return new WaitForSeconds(0.6f);
        manager.drop_Pattern.Stop();
        manager.drop_Pattern.Play();

        GameObject diablock9;
        diablock9 = objectPool.MakeObj(diaBlock[0]);
        dia_ran_pos = Random.Range(0, 12);
        diablock9.gameObject.transform.position = dia_StartPos[dia_ran_pos].gameObject.transform.position;
        if (dia_ran_pos == 0 || dia_ran_pos == 1 || dia_ran_pos == 2)
            diablock9.transform.rotation = Quaternion.Euler(0, 0, 90);
        else if (dia_ran_pos == 3 || dia_ran_pos == 5 || dia_ran_pos == 7)
            diablock9.transform.rotation = Quaternion.Euler(0, 0, 0);
        else if (dia_ran_pos == 4 || dia_ran_pos == 6 || dia_ran_pos == 8)
            diablock9.transform.rotation = Quaternion.Euler(0, 0, 180);
        else if (dia_ran_pos == 9 || dia_ran_pos == 10 || dia_ran_pos == 11)
            diablock9.transform.rotation = Quaternion.Euler(0, 0, -90);
        yield return new WaitForSeconds(0.6f);
        manager.drop_Pattern.Stop();
        manager.drop_Pattern.Play();

        GameObject diablock10;
        diablock10 = objectPool.MakeObj(diaBlock[0]);
        dia_ran_pos = Random.Range(0, 12);
        diablock10.gameObject.transform.position = dia_StartPos[dia_ran_pos].gameObject.transform.position;
        if (dia_ran_pos == 0 || dia_ran_pos == 1 || dia_ran_pos == 2)
            diablock10.transform.rotation = Quaternion.Euler(0, 0, 90);
        else if (dia_ran_pos == 3 || dia_ran_pos == 5 || dia_ran_pos == 7)
            diablock10.transform.rotation = Quaternion.Euler(0, 0, 0);
        else if (dia_ran_pos == 4 || dia_ran_pos == 6 || dia_ran_pos == 8)
            diablock10.transform.rotation = Quaternion.Euler(0, 0, 180);
        else if (dia_ran_pos == 9 || dia_ran_pos == 10 || dia_ran_pos == 11)
            diablock10.transform.rotation = Quaternion.Euler(0, 0, -90);
        yield return new WaitForSeconds(0.6f);
        manager.drop_Pattern.Stop();
        manager.drop_Pattern.Play();

        GameObject diablock11;
        diablock11 = objectPool.MakeObj(diaBlock[0]);
        dia_ran_pos = Random.Range(0, 12);
        diablock11.gameObject.transform.position = dia_StartPos[dia_ran_pos].gameObject.transform.position;
        if (dia_ran_pos == 0 || dia_ran_pos == 1 || dia_ran_pos == 2)
            diablock11.transform.rotation = Quaternion.Euler(0, 0, 90);
        else if (dia_ran_pos == 3 || dia_ran_pos == 5 || dia_ran_pos == 7)
            diablock11.transform.rotation = Quaternion.Euler(0, 0, 0);
        else if (dia_ran_pos == 4 || dia_ran_pos == 6 || dia_ran_pos == 8)
            diablock11.transform.rotation = Quaternion.Euler(0, 0, 180);
        else if (dia_ran_pos == 9 || dia_ran_pos == 10 || dia_ran_pos == 11)
            diablock11.transform.rotation = Quaternion.Euler(0, 0, -90);
        yield return new WaitForSeconds(0.6f);
        manager.drop_Pattern.Stop();
        manager.drop_Pattern.Play();

        GameObject diablock12;
        diablock12 = objectPool.MakeObj(diaBlock[0]);
        dia_ran_pos = Random.Range(0, 12);
        diablock12.gameObject.transform.position = dia_StartPos[dia_ran_pos].gameObject.transform.position;
        if (dia_ran_pos == 0 || dia_ran_pos == 1 || dia_ran_pos == 2)
            diablock12.transform.rotation = Quaternion.Euler(0, 0, 90);
        else if (dia_ran_pos == 3 || dia_ran_pos == 5 || dia_ran_pos == 7)
            diablock12.transform.rotation = Quaternion.Euler(0, 0, 0);
        else if (dia_ran_pos == 4 || dia_ran_pos == 6 || dia_ran_pos == 8)
            diablock12.transform.rotation = Quaternion.Euler(0, 0, 180);
        else if (dia_ran_pos == 9 || dia_ran_pos == 10 || dia_ran_pos == 11)
            diablock12.transform.rotation = Quaternion.Euler(0, 0, -90);
        yield return new WaitForSeconds(0.6f);
        manager.drop_Pattern.Stop();
        manager.drop_Pattern.Play();

        GameObject diablock13;
        diablock13 = objectPool.MakeObj(diaBlock[0]);
        dia_ran_pos = Random.Range(0, 12);
        diablock13.gameObject.transform.position = dia_StartPos[dia_ran_pos].gameObject.transform.position;
        if (dia_ran_pos == 0 || dia_ran_pos == 1 || dia_ran_pos == 2)
            diablock13.transform.rotation = Quaternion.Euler(0, 0, 90);
        else if (dia_ran_pos == 3 || dia_ran_pos == 5 || dia_ran_pos == 7)
            diablock13.transform.rotation = Quaternion.Euler(0, 0, 0);
        else if (dia_ran_pos == 4 || dia_ran_pos == 6 || dia_ran_pos == 8)
            diablock13.transform.rotation = Quaternion.Euler(0, 0, 180);
        else if (dia_ran_pos == 9 || dia_ran_pos == 10 || dia_ran_pos == 11)
            diablock13.transform.rotation = Quaternion.Euler(0, 0, -90);
        yield return new WaitForSeconds(0.6f);
        manager.drop_Pattern.Stop();
        manager.drop_Pattern.Play();

        GameObject diablock14;
        diablock14 = objectPool.MakeObj(diaBlock[0]);
        dia_ran_pos = Random.Range(0, 12);
        diablock14.gameObject.transform.position = dia_StartPos[dia_ran_pos].gameObject.transform.position;
        if (dia_ran_pos == 0 || dia_ran_pos == 1 || dia_ran_pos == 2)
            diablock14.transform.rotation = Quaternion.Euler(0, 0, 90);
        else if (dia_ran_pos == 3 || dia_ran_pos == 5 || dia_ran_pos == 7)
            diablock14.transform.rotation = Quaternion.Euler(0, 0, 0);
        else if (dia_ran_pos == 4 || dia_ran_pos == 6 || dia_ran_pos == 8)
            diablock14.transform.rotation = Quaternion.Euler(0, 0, 180);
        else if (dia_ran_pos == 9 || dia_ran_pos == 10 || dia_ran_pos == 11)
            diablock14.transform.rotation = Quaternion.Euler(0, 0, -90);
        yield return new WaitForSeconds(0.6f);
        manager.drop_Pattern.Stop();
        manager.drop_Pattern.Play();

        GameObject diablock15;
        diablock15 = objectPool.MakeObj(diaBlock[0]);
        dia_ran_pos = Random.Range(0, 12);
        diablock15.gameObject.transform.position = dia_StartPos[dia_ran_pos].gameObject.transform.position;
        if (dia_ran_pos == 0 || dia_ran_pos == 1 || dia_ran_pos == 2)
            diablock15.transform.rotation = Quaternion.Euler(0, 0, 90);
        else if (dia_ran_pos == 3 || dia_ran_pos == 5 || dia_ran_pos == 7)
            diablock15.transform.rotation = Quaternion.Euler(0, 0, 0);
        else if (dia_ran_pos == 4 || dia_ran_pos == 6 || dia_ran_pos == 8)
            diablock15.transform.rotation = Quaternion.Euler(0, 0, 180);
        else if (dia_ran_pos == 9 || dia_ran_pos == 10 || dia_ran_pos == 11)
            diablock15.transform.rotation = Quaternion.Euler(0, 0, -90);
        yield return new WaitForSeconds(0.6f);
        manager.drop_Pattern.Stop();
        manager.drop_Pattern.Play();

        GameObject diablock16;
        diablock16 = objectPool.MakeObj(diaBlock[0]);
        dia_ran_pos = Random.Range(0, 12);
        diablock16.gameObject.transform.position = dia_StartPos[dia_ran_pos].gameObject.transform.position;
        if (dia_ran_pos == 0 || dia_ran_pos == 1 || dia_ran_pos == 2)
            diablock16.transform.rotation = Quaternion.Euler(0, 0, 90);
        else if (dia_ran_pos == 3 || dia_ran_pos == 5 || dia_ran_pos == 7)
            diablock16.transform.rotation = Quaternion.Euler(0, 0, 0);
        else if (dia_ran_pos == 4 || dia_ran_pos == 6 || dia_ran_pos == 8)
            diablock16.transform.rotation = Quaternion.Euler(0, 0, 180);
        else if (dia_ran_pos == 9 || dia_ran_pos == 10 || dia_ran_pos == 11)
            diablock16.transform.rotation = Quaternion.Euler(0, 0, -90);
        yield return new WaitForSeconds(0.6f);
        manager.drop_Pattern.Stop();
        manager.drop_Pattern.Play();

        GameObject diablock17;
        diablock17 = objectPool.MakeObj(diaBlock[0]);
        dia_ran_pos = Random.Range(0, 12);
        diablock17.gameObject.transform.position = dia_StartPos[dia_ran_pos].gameObject.transform.position;
        if (dia_ran_pos == 0 || dia_ran_pos == 1 || dia_ran_pos == 2)
            diablock17.transform.rotation = Quaternion.Euler(0, 0, 90);
        else if (dia_ran_pos == 3 || dia_ran_pos == 5 || dia_ran_pos == 7)
            diablock17.transform.rotation = Quaternion.Euler(0, 0, 0);
        else if (dia_ran_pos == 4 || dia_ran_pos == 6 || dia_ran_pos == 8)
            diablock17.transform.rotation = Quaternion.Euler(0, 0, 180);
        else if (dia_ran_pos == 9 || dia_ran_pos == 10 || dia_ran_pos == 11)
            diablock17.transform.rotation = Quaternion.Euler(0, 0, -90);
        yield return new WaitForSeconds(0.6f);
        manager.drop_Pattern.Stop();
        manager.drop_Pattern.Play();

        GameObject diablock18;
        diablock18 = objectPool.MakeObj(diaBlock[0]);
        dia_ran_pos = Random.Range(0, 12);
        diablock18.gameObject.transform.position = dia_StartPos[dia_ran_pos].gameObject.transform.position;
        if (dia_ran_pos == 0 || dia_ran_pos == 1 || dia_ran_pos == 2)
            diablock18.transform.rotation = Quaternion.Euler(0, 0, 90);
        else if (dia_ran_pos == 3 || dia_ran_pos == 5 || dia_ran_pos == 7)
            diablock18.transform.rotation = Quaternion.Euler(0, 0, 0);
        else if (dia_ran_pos == 4 || dia_ran_pos == 6 || dia_ran_pos == 8)
            diablock18.transform.rotation = Quaternion.Euler(0, 0, 180);
        else if (dia_ran_pos == 9 || dia_ran_pos == 10 || dia_ran_pos == 11)
            diablock18.transform.rotation = Quaternion.Euler(0, 0, -90);
        yield return new WaitForSeconds(0.6f);
        manager.drop_Pattern.Stop();
        manager.drop_Pattern.Play();

        GameObject diablock19;
        diablock19 = objectPool.MakeObj(diaBlock[0]);
        dia_ran_pos = Random.Range(0, 12);
        diablock19.gameObject.transform.position = dia_StartPos[dia_ran_pos].gameObject.transform.position;
        if (dia_ran_pos == 0 || dia_ran_pos == 1 || dia_ran_pos == 2)
            diablock19.transform.rotation = Quaternion.Euler(0, 0, 90);
        else if (dia_ran_pos == 3 || dia_ran_pos == 5 || dia_ran_pos == 7)
            diablock19.transform.rotation = Quaternion.Euler(0, 0, 0);
        else if (dia_ran_pos == 4 || dia_ran_pos == 6 || dia_ran_pos == 8)
            diablock19.transform.rotation = Quaternion.Euler(0, 0, 180);
        else if (dia_ran_pos == 9 || dia_ran_pos == 10 || dia_ran_pos == 11)
            diablock19.transform.rotation = Quaternion.Euler(0, 0, -90);
        yield return new WaitForSeconds(0.6f);
        manager.drop_Pattern.Stop();
        manager.drop_Pattern.Play();

        GameObject diablock20;
        diablock20 = objectPool.MakeObj(diaBlock[0]);
        dia_ran_pos = Random.Range(0, 12);
        diablock20.gameObject.transform.position = dia_StartPos[dia_ran_pos].gameObject.transform.position;
        if (dia_ran_pos == 0 || dia_ran_pos == 1 || dia_ran_pos == 2)
            diablock20.transform.rotation = Quaternion.Euler(0, 0, 90);
        else if (dia_ran_pos == 3 || dia_ran_pos == 5 || dia_ran_pos == 7)
            diablock20.transform.rotation = Quaternion.Euler(0, 0, 0);
        else if (dia_ran_pos == 4 || dia_ran_pos == 6 || dia_ran_pos == 8)
            diablock20.transform.rotation = Quaternion.Euler(0, 0, 180);
        else if (dia_ran_pos == 9 || dia_ran_pos == 10 || dia_ran_pos == 11)
            diablock20.transform.rotation = Quaternion.Euler(0, 0, -90);
        yield return new WaitForSeconds(0.6f);

        StartCoroutine(nameof(EndDia));
    }
    IEnumerator EndDia()
    {
        for (int i = 44; i >= 0; i--)
        {
            manager.game_Camera.transform.rotation = Quaternion.Euler(0, 0, i);
            yield return new WaitForSeconds(0.03f);
        }
        manager.game_Camera.transform.rotation = Quaternion.Euler(0, 0, 0);
        yield return new WaitForSeconds(1.5f);
        dia_Obj.gameObject.SetActive(false);
        yield return new WaitForSeconds(1.5f);
        manager.Explain();
    }

    IEnumerator Turn6()
    {
        for(int i=0; i<4; i++)
        {
            turn_array = new int[12] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 };

            for (int j=0; j<8; j++)//빈칸 뚫기
            {
                manager.turn_Pattern.Stop();
                manager.turn_Pattern.Play();

                int turn_ran;//배열의 몇번째
                int turn_num;//결정된 번호
                do
                {
                    turn_ran = Random.Range(0, 12);
                } while (turn_array[turn_ran] == 100);

                turn_num = turn_array[turn_ran];
                turn_array[turn_ran] = 100;

                GameObject turn_Block;
                turn_Block = objectPool.MakeObj(turnBlock[0]);

                turn_Block.gameObject.transform.position = turn_StartPos[turn_num].gameObject.transform.position;
                if (turn_num == 0 || turn_num == 1 || turn_num == 2)
                    turn_Block.transform.rotation = Quaternion.Euler(0, 0, 90);
                else if (turn_num == 3 || turn_num == 5 || turn_num == 7)
                    turn_Block.transform.rotation = Quaternion.Euler(0, 0, 0);
                else if (turn_num == 4 || turn_num == 6 || turn_num == 8)
                    turn_Block.transform.rotation = Quaternion.Euler(0, 0, 180);
                else if (turn_num == 9 || turn_num == 10 || turn_num == 11)
                    turn_Block.transform.rotation = Quaternion.Euler(0, 0, -90);

                yield return new WaitForSeconds(0.4f);
            }
            yield return new WaitForSeconds(1.2f);
        }
        yield return new WaitForSeconds(1.5f);
        turn_Obj.gameObject.SetActive(false);
        yield return new WaitForSeconds(1.5f);
        manager.Explain();
    }

    IEnumerator Start_Arrow()
    {
        arrow_Obj.gameObject.SetActive(true);
        arrow.gameObject.SetActive(false);
        arrow_user.gameObject.SetActive(false);

        arrow.gameObject.SetActive(true);
        yield return new WaitForSeconds(2f);
        arrow.gameObject.SetActive(false);
        arrow_user.gameObject.SetActive(true);

        StartCoroutine(nameof(End_Arrow));

    }
    IEnumerator End_Arrow()
    {
        yield return new WaitForSeconds(3f);
        arrow_Obj.Check_Arrow();

        arrow_Obj.gameObject.SetActive(false);
        arrow.gameObject.SetActive(false);
        arrow_user.gameObject.SetActive(false);


        ArrowPattern();
    }

    IEnumerator Big15()
    {
        for(int i=0; i<15; i++)
        {
            big_ran = Random.Range(0, 8);
            GameObject big;
            big = objectPool.MakeObj(bigBlock[0]);
            if (big_ran == 0)
            {
                big.transform.position = new Vector3(-0.9f, -9.5f);
                big.transform.localEulerAngles = new Vector3(0, 0, 90);
            }
            else if (big_ran == 1)
            {
                big.transform.position = new Vector3(0.9f, -9.5f);
                big.transform.localEulerAngles = new Vector3(0, 0, 90);
            }
            else if (big_ran == 2)
            {
                big.transform.position = new Vector3(-9.5f, -0.9f);
                big.transform.localEulerAngles = new Vector3(0, 0, 0);
            }
            else if (big_ran == 3)
            {
                big.transform.position = new Vector3(9.5f, -0.9f);
                big.transform.localEulerAngles = new Vector3(0, 0, 180);
            }
            else if (big_ran == 4)
            {
                big.transform.position = new Vector3(-9.5f, 0.9f);
                big.transform.localEulerAngles = new Vector3(0, 0, 0);
            }
            else if (big_ran == 5)
            {
                big.transform.position = new Vector3(9.5f, 0.9f);
                big.transform.localEulerAngles = new Vector3(0, 0, 180);
            }
            else if (big_ran == 6)
            {
                big.transform.position = new Vector3(-0.9f, 9.5f);
                big.transform.localEulerAngles = new Vector3(0, 0, -90);
            }
            else if (big_ran == 7)
            {
                big.transform.position = new Vector3(0.9f, 9.5f);
                big.transform.localEulerAngles = new Vector3(0, 0, -90);
            }

            yield return new WaitForSeconds(0.9f);
        }
        yield return new WaitForSeconds(2f);
        big_Obj.gameObject.SetActive(false);
        yield return new WaitForSeconds(2f);
        manager.Explain();
    }

    IEnumerator Line10()
    {
        manager.line_Pattern.Stop();
        manager.line_Pattern.Play();
        GameObject line1;//up
        line1 = objectPool.MakeObj(lineBlock[0]);
        line1.transform.position = new Vector3(0f, -9.5f);
        line1.transform.localEulerAngles = new Vector3(0, 0, 90);
        yield return new WaitForSeconds(1.2f);

        manager.line_Pattern.Stop();
        manager.line_Pattern.Play();
        GameObject line2;//right
        line2 = objectPool.MakeObj(lineBlock[0]);
        line2.transform.position = new Vector3(-9.5f, 0f);
        line2.transform.localEulerAngles = new Vector3(0, 0, 0);
        yield return new WaitForSeconds(1.2f);

        manager.line_Pattern.Stop();
        manager.line_Pattern.Play();
        GameObject line3;//down
        line3 = objectPool.MakeObj(lineBlock[0]);
        line3.transform.position = new Vector3(0f, 9.5f);
        line3.transform.localEulerAngles = new Vector3(0, 0, -90);
        yield return new WaitForSeconds(1.2f);

        manager.line_Pattern.Stop();
        manager.line_Pattern.Play();
        GameObject line4;//left
        line4 = objectPool.MakeObj(lineBlock[0]);
        line4.transform.position = new Vector3(9.5f, 0f);
        line4.transform.localEulerAngles = new Vector3(0, 0, 180);
        yield return new WaitForSeconds(1.2f);

        manager.line_Pattern.Stop();
        manager.line_Pattern.Play();
        GameObject line5;
        line5 = objectPool.MakeObj(lineBlock[0]);
        line5.transform.position = new Vector3(-9.5f, 0f);
        line5.transform.localEulerAngles = new Vector3(0, 0, 0);
        GameObject line6;
        line6 = objectPool.MakeObj(lineBlock[0]);
        line6.transform.position = new Vector3(0f, 9.5f);
        line6.transform.localEulerAngles = new Vector3(0, 0, -90);
        yield return new WaitForSeconds(1.2f);

        manager.line_Pattern.Stop();
        manager.line_Pattern.Play();
        GameObject line7;
        line7 = objectPool.MakeObj(lineBlock[0]);
        line7.transform.position = new Vector3(0f, -9.5f);
        line7.transform.localEulerAngles = new Vector3(0, 0, 90);
        yield return new WaitForSeconds(1.2f);

        manager.line_Pattern.Stop();
        manager.line_Pattern.Play();
        GameObject line8;//down
        line8 = objectPool.MakeObj(lineBlock[0]);
        line8.transform.position = new Vector3(0f, 9.5f);
        line8.transform.localEulerAngles = new Vector3(0, 0, -90);
        GameObject line9;//left
        line9 = objectPool.MakeObj(lineBlock[0]);
        line9.transform.position = new Vector3(9.5f, 0f);
        line9.transform.localEulerAngles = new Vector3(0, 0, 180);
        yield return new WaitForSeconds(1.2f);

        manager.line_Pattern.Stop();
        manager.line_Pattern.Play();
        GameObject line10;//right
        line10 = objectPool.MakeObj(lineBlock[0]);
        line10.transform.position = new Vector3(-9.5f, 0f);
        line10.transform.localEulerAngles = new Vector3(0, 0, 0);
        yield return new WaitForSeconds(1.2f);
        yield return new WaitForSeconds(5f);
        manager.Explain();
    }

    IEnumerator Speed30()
    {
        for(int i=0; i<30; i++)
        {
            manager.drop_Pattern.Stop();
            manager.drop_Pattern.Play();
            speed_ran = Random.Range(0, 2);//종류
            GameObject speed;//up
            speed = objectPool.MakeObj(speedBlock[speed_ran]);
            speed_ran_pos = Random.Range(0, 12);//위치
            if(speed_ran_pos == 0)
            {
                speed.transform.position = new Vector3(-1.8f, -9.5f);
                speed.transform.localEulerAngles = new Vector3(0, 0, 90);
            }
            else if (speed_ran_pos == 1)
            {
                speed.transform.position = new Vector3(0f, -9.5f);
                speed.transform.localEulerAngles = new Vector3(0, 0, 90);
            }
            else if (speed_ran_pos == 2)
            {
                speed.transform.position = new Vector3(1.8f, -9.5f);
                speed.transform.localEulerAngles = new Vector3(0, 0, 90);
            }
            else if (speed_ran_pos == 3)
            {
                speed.transform.position = new Vector3(-9.5f, -1.8f);
                speed.transform.localEulerAngles = new Vector3(0, 0, 0);
            }
            else if (speed_ran_pos == 4)
            {
                speed.transform.position = new Vector3(9.5f, -1.8f);
                speed.transform.localEulerAngles = new Vector3(0, 0, 180);
            }
            else if (speed_ran_pos == 5)
            {
                speed.transform.position = new Vector3(-9.5f, 0f);
                speed.transform.localEulerAngles = new Vector3(0, 0, 0);
            }
            else if (speed_ran_pos == 6)
            {
                speed.transform.position = new Vector3(9.5f, 0f);
                speed.transform.localEulerAngles = new Vector3(0, 0, 180);
            }
            else if (speed_ran_pos == 7)
            {
                speed.transform.position = new Vector3(-9.5f, 1.8f);
                speed.transform.localEulerAngles = new Vector3(0, 0, 0);
            }
            else if (speed_ran_pos == 8)
            {
                speed.transform.position = new Vector3(9.5f, 1.8f);
                speed.transform.localEulerAngles = new Vector3(0, 0, 180);
            }
            else if (speed_ran_pos == 9)
            {
                speed.transform.position = new Vector3(-1.8f, 9.5f);
                speed.transform.localEulerAngles = new Vector3(0, 0, -90);
            }
            else if (speed_ran_pos == 10)
            {
                speed.transform.position = new Vector3(0f, 9.5f);
                speed.transform.localEulerAngles = new Vector3(0, 0, -90);
            }
            else if (speed_ran_pos == 11)
            {
                speed.transform.position = new Vector3(1.8f, 9.5f);
                speed.transform.localEulerAngles = new Vector3(0, 0, -90);
            }

            yield return new WaitForSeconds(0.5f);
        }

        yield return new WaitForSeconds(3f);
        manager.Explain();
    }

    IEnumerator Smooth28()
    {
        for (int i = 0; i < 28; i++)
        {
            GameObject smooth;//up
            smooth = objectPool.MakeObj(smoothBlock[0]);
            smooth_ran_pos = Random.Range(0, 12);//위치
            if (smooth_ran_pos == 0)
            {
                smooth.transform.position = new Vector3(-1.8f, -9.5f);
                smooth.transform.localEulerAngles = new Vector3(0, 0, 90);
            }
            else if (smooth_ran_pos == 1)
            {
                smooth.transform.position = new Vector3(0f, -9.5f);
                smooth.transform.localEulerAngles = new Vector3(0, 0, 90);
            }
            else if (smooth_ran_pos == 2)
            {
                smooth.transform.position = new Vector3(1.8f, -9.5f);
                smooth.transform.localEulerAngles = new Vector3(0, 0, 90);
            }
            else if (smooth_ran_pos == 3)
            {
                smooth.transform.position = new Vector3(-9.5f, -1.8f);
                smooth.transform.localEulerAngles = new Vector3(0, 0, 0);
            }
            else if (smooth_ran_pos == 4)
            {
                smooth.transform.position = new Vector3(9.5f, -1.8f);
                smooth.transform.localEulerAngles = new Vector3(0, 0, 180);
            }
            else if (smooth_ran_pos == 5)
            {
                smooth.transform.position = new Vector3(-9.5f, 0f);
                smooth.transform.localEulerAngles = new Vector3(0, 0, 0);
            }
            else if (smooth_ran_pos == 6)
            {
                smooth.transform.position = new Vector3(9.5f, 0f);
                smooth.transform.localEulerAngles = new Vector3(0, 0, 180);
            }
            else if (smooth_ran_pos == 7)
            {
                smooth.transform.position = new Vector3(-9.5f, 1.8f);
                smooth.transform.localEulerAngles = new Vector3(0, 0, 0);
            }
            else if (smooth_ran_pos == 8)
            {
                smooth.transform.position = new Vector3(9.5f, 1.8f);
                smooth.transform.localEulerAngles = new Vector3(0, 0, 180);
            }
            else if (smooth_ran_pos == 9)
            {
                smooth.transform.position = new Vector3(-1.8f, 9.5f);
                smooth.transform.localEulerAngles = new Vector3(0, 0, -90);
            }
            else if (smooth_ran_pos == 10)
            {
                smooth.transform.position = new Vector3(0f, 9.5f);
                smooth.transform.localEulerAngles = new Vector3(0, 0, -90);
            }
            else if (smooth_ran_pos == 11)
            {
                smooth.transform.position = new Vector3(1.8f, 9.5f);
                smooth.transform.localEulerAngles = new Vector3(0, 0, -90);
            }

            yield return new WaitForSeconds(0.4f);
        }

        yield return new WaitForSeconds(2f);
        smooth_Obj.gameObject.SetActive(false);
        yield return new WaitForSeconds(1.5f);
        manager.Explain();
    }

    IEnumerator Tictoc1()
    {
        yield return new WaitForSeconds(18f);
        tictoc_Obj.gameObject.SetActive(false);
        yield return new WaitForSeconds(1.5f);

        manager.Explain();
    }

    IEnumerator RBR9()
    {
        for (int i = 0; i < 3; i++)
        {
            RBR_Obj_Block();
            yield return new WaitForSeconds(1f);
            for (int j = 0; j < 8; j++)
            {
                GameObject rbr;
                rbr = objectPool.MakeObj(rbrBlock[0]);
                rbr.gameObject.transform.position = new Vector3(10, 0, 0);
                yield return new WaitForSeconds(0.33f);
            }
            yield return new WaitForSeconds(1.5f);
        }
        yield return new WaitForSeconds(1.5f);
        rbr_Obj.gameObject.SetActive(false);
        yield return new WaitForSeconds(2f);
        manager.Explain();
    }

    public void RBR_Obj_Block()
    {
        do
        {
            rbr_ran = Random.Range(0, 3);
        } while (rbr_array[rbr_ran] == 100);

        rbr_array[rbr_ran] = 100;

        for (int i = 0; i < 3; i++)
            rbr_Obj_block[i].gameObject.SetActive(false);
        rbr_Obj_block[rbr_ran].gameObject.SetActive(true);
    }

    IEnumerator Cannon_Move()
    {
        for(int i=0; i<5; i++)
        {
            yield return new WaitForSeconds(0.5f);
            
            cannon_array = new int[3] { 0, 1, 2 };

            cannon_ran = Random.Range(0, 3);
            cannon_array[cannon_ran] = 100;

            if (cannon_ran == 0)
                cannon_Obj.cannon_pos1 = new Vector3(-1.8f, 4.2f);
            else if (cannon_ran == 1)
                cannon_Obj.cannon_pos1 = new Vector3(0, 4.2f);
            else if (cannon_ran == 2)
                cannon_Obj.cannon_pos1 = new Vector3(1.8f, 4.2f);

            do
            {
                cannon_ran = Random.Range(0, 3);
            } while (cannon_array[cannon_ran] == 100);

            if (cannon_ran == 0)
                cannon_Obj.cannon_pos2 = new Vector3(-1.8f, -4.2f);
            else if (cannon_ran == 1)
                cannon_Obj.cannon_pos2 = new Vector3(0, -4.2f);
            else if (cannon_ran == 2)
                cannon_Obj.cannon_pos2 = new Vector3(1.8f, -4.2f);

            cannon_array = new int[3] { 0, 1, 2 };

            cannon_ran = Random.Range(0, 3);
            cannon_array[cannon_ran] = 100;

            if (cannon_ran == 0)
                cannon_Obj.cannon_pos3 = new Vector3(4.2f, -1.8f);
            else if (cannon_ran == 1)
                cannon_Obj.cannon_pos3 = new Vector3(4.2f, 0);
            else if (cannon_ran == 2)
                cannon_Obj.cannon_pos3 = new Vector3(4.2f, 1.8f);

            do
            {
                cannon_ran = Random.Range(0, 3);
            } while (cannon_array[cannon_ran] == 100);

            if (cannon_ran == 0)
                cannon_Obj.cannon_pos4 = new Vector3(-4.2f, -1.8f);
            else if (cannon_ran == 1)
                cannon_Obj.cannon_pos4 = new Vector3(-4.2f, 0);
            else if (cannon_ran == 2)
                cannon_Obj.cannon_pos4 = new Vector3(-4.2f, 1.8f);

            yield return new WaitForSeconds(1.5f);

            manager.drop_Pattern.Stop();
            manager.drop_Pattern.Play();

            GameObject cannon1;//up
            cannon1 = objectPool.MakeObj(cannonBlock[0]);
            cannon1.transform.position = cannon_Obj.cannon1_1.transform.position;
            cannon1.transform.localEulerAngles = new Vector3(0, 0, -90);

            GameObject cannon2;//up
            cannon2 = objectPool.MakeObj(cannonBlock[0]);
            cannon2.transform.position = cannon_Obj.cannon1_2.transform.position;
            cannon2.transform.localEulerAngles = new Vector3(0, 0, 90);

            GameObject cannon3;//up
            cannon3 = objectPool.MakeObj(cannonBlock[0]);
            cannon3.transform.position = cannon_Obj.cannon2_1.transform.position;
            cannon3.transform.localEulerAngles = new Vector3(0, 0, 180);

            GameObject cannon4;//up
            cannon4 = objectPool.MakeObj(cannonBlock[0]);
            cannon4.transform.position = cannon_Obj.cannon2_2.transform.position;
            cannon4.transform.localEulerAngles = new Vector3(0, 0, 0);
        }
        yield return new WaitForSeconds(1f);

        cannon_Obj.gameObject.SetActive(false);

        yield return new WaitForSeconds(1.5f);
        manager.Explain();

    }

    IEnumerator Heart15()
    {
        yield return new WaitForSeconds(1.5f);
        Heart_General();
        yield return new WaitForSeconds(1.5f);
        Heart_General();
        yield return new WaitForSeconds(0.3f);
        Heart_General();
        yield return new WaitForSeconds(0.2f);
        Heart_General();
        yield return new WaitForSeconds(0.5f);
        Heart_General();
        yield return new WaitForSeconds(0.2f);
        Heart_General();
        yield return new WaitForSeconds(0.7f);
        Heart_General();
        yield return new WaitForSeconds(0.3f);
        Heart_General();
        yield return new WaitForSeconds(0.5f);
        Heart_General();
        yield return new WaitForSeconds(0.4f);
        Heart_General();
        yield return new WaitForSeconds(0.2f);
        Heart_General();
        yield return new WaitForSeconds(0.3f);
        Heart_General();
        yield return new WaitForSeconds(0.4f);
        Heart_General();
        yield return new WaitForSeconds(0.3f);
        Heart_General();
        yield return new WaitForSeconds(0.4f);
        Heart_General();
        yield return new WaitForSeconds(2.5f);

        heart_Obj.gameObject.SetActive(false);
        yield return new WaitForSeconds(1.5f);
        manager.Explain();
    }
    void Heart_General()
    {
        heart_ran = Random.Range(0, 6);
        GameObject heart;
        heart = objectPool.MakeObj(heartBlock[0]);
        if (heart_ran == 0)
        {
            heart.gameObject.transform.position = new Vector3(-5.5f, -1.8f);
            heart.gameObject.transform.eulerAngles = new Vector3(0, 0, 0);
        }
        else if (heart_ran == 1)
        {
            heart.gameObject.transform.position = new Vector3(-5.5f, 0);
            heart.gameObject.transform.eulerAngles = new Vector3(0, 0, 0);
        }
        else if (heart_ran == 2)
        {
            heart.gameObject.transform.position = new Vector3(-5.5f, 1.8f);
            heart.gameObject.transform.eulerAngles = new Vector3(0, 0, 0);
        }
        else if (heart_ran == 3)
        {
            heart.gameObject.transform.position = new Vector3(5.5f, -1.8f);
            heart.gameObject.transform.eulerAngles = new Vector3(0, 180, 0);
        }
        else if (heart_ran == 4)
        {
            heart.gameObject.transform.position = new Vector3(5.5f, 0);
            heart.gameObject.transform.eulerAngles = new Vector3(0, 180, 0);
        }
        else if (heart_ran == 5)
        {
            heart.gameObject.transform.position = new Vector3(5.5f, 1.8f);
            heart.gameObject.transform.eulerAngles = new Vector3(0, 180, 0);
        }
    }

    IEnumerator Move15()
    {
        yield return new WaitForSeconds(1f);
        for (int i = 0; i < 15; i++)
        {
            GameObject move;//up
            move = objectPool.MakeObj(moveBlock[0]);
            move_ran = Random.Range(0, 12);//위치
            if (move_ran == 0)
            {
                move.transform.position = new Vector3(-1.8f, -9.5f);
                move.transform.localEulerAngles = new Vector3(0, 0, 90);
            }
            else if (move_ran == 1)
            {
                move.transform.position = new Vector3(0f, -9.5f);
                move.transform.localEulerAngles = new Vector3(0, 0, 90);
            }
            else if (move_ran == 2)
            {
                move.transform.position = new Vector3(1.8f, -9.5f);
                move.transform.localEulerAngles = new Vector3(0, 0, 90);
            }
            else if (move_ran == 3)
            {
                move.transform.position = new Vector3(-9.5f, -1.8f);
                move.transform.localEulerAngles = new Vector3(0, 0, 0);
            }
            else if (move_ran == 4)
            {
                move.transform.position = new Vector3(9.5f, -1.8f);
                move.transform.localEulerAngles = new Vector3(0, 0, 180);
            }
            else if (move_ran == 5)
            {
                move.transform.position = new Vector3(-9.5f, 0f);
                move.transform.localEulerAngles = new Vector3(0, 0, 0);
            }
            else if (move_ran == 6)
            {
                move.transform.position = new Vector3(9.5f, 0f);
                move.transform.localEulerAngles = new Vector3(0, 0, 180);
            }
            else if (move_ran == 7)
            {
                move.transform.position = new Vector3(-9.5f, 1.8f);
                move.transform.localEulerAngles = new Vector3(0, 0, 0);
            }
            else if (move_ran == 8)
            {
                move.transform.position = new Vector3(9.5f, 1.8f);
                move.transform.localEulerAngles = new Vector3(0, 0, 180);
            }
            else if (move_ran == 9)
            {
                move.transform.position = new Vector3(-1.8f, 9.5f);
                move.transform.localEulerAngles = new Vector3(0, 0, -90);
            }
            else if (move_ran == 10)
            {
                move.transform.position = new Vector3(0f, 9.5f);
                move.transform.localEulerAngles = new Vector3(0, 0, -90);
            }
            else if (move_ran == 11)
            {
                move.transform.position = new Vector3(1.8f, 9.5f);
                move.transform.localEulerAngles = new Vector3(0, 0, -90);
            }

            yield return new WaitForSeconds(0.5f);
        }

    }

    IEnumerator View_Camera_Move()
    {
        float j = 0;
        for (float i = -10; i <= -1; i+=0.1f)
        {
            j -= 0.01f;
            view_Camera.gameObject.transform.localPosition = new Vector3(0, j, i);
            yield return new WaitForSeconds(0.03f);
        }
        view_Camera.gameObject.transform.localPosition = new Vector3(0, -1, -1);
        yield return new WaitForSeconds(0.1f);

        for(int i=0; i<70; i++)
        {
            view_Camera.gameObject.transform.rotation = Quaternion.Euler(-i, 0, 0);
            yield return new WaitForSeconds(0.03f);
        }
        view_Camera.gameObject.transform.rotation = Quaternion.Euler(-70, 0, 0);

        StartCoroutine(nameof(View30));
    }

    IEnumerator View30()
    {
        for (int i = 0; i < 30; i++)
        {
            manager.view_Pattern.Stop();
            manager.view_Pattern.Play();
            view_ran = Random.Range(0, 3);
            GameObject view;
            view = objectPool.MakeObj(viewBlock[0]);
            if(view_ran == 0)
            {
                view.transform.position = new Vector3(-1.8f, 20f);
            }
            else if (view_ran == 1)
            {
                view.transform.position = new Vector3(-0, 20f);
            }
            else if (view_ran == 2)
            {
                view.transform.position = new Vector3(1.8f, 20f);
            }

            yield return new WaitForSeconds(0.1f);

            manager.view_Pattern.Stop();
            manager.view_Pattern.Play();

            view_ran = Random.Range(0, 3);
            GameObject view2;
            view2 = objectPool.MakeObj(viewBlock[0]);
            if (view_ran == 0)
            {
                view2.transform.position = new Vector3(-1.8f, 20f);
            }
            else if (view_ran == 1)
            {
                view2.transform.position = new Vector3(-0, 20f);
            }
            else if (view_ran == 2)
            {
                view2.transform.position = new Vector3(1.8f, 20f);
            }

            yield return new WaitForSeconds(0.5f);
        }

        yield return new WaitForSeconds(2.5f);
        manager.game_Camera.gameObject.SetActive(true);
        view_Camera.gameObject.SetActive(false);

        yield return new WaitForSeconds(1.5f);
        manager.Explain();
    }
}
