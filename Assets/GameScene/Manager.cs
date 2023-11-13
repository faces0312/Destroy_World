using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class Manager : MonoBehaviour
{
    public static Manager manager;
    public Camera game_Camera;
    public ObjectManager objectManager;
    public Game_Player player;
    public GameObject retry;
    //패턴과 패턴 사이의 쿨타임
    public bool is_pattern;//패턴이 진행 중인지
    public float pattern_CoolTime;
    public float pattern_Tmp_CoolTime;
    //패턴 종류
    int[] pattern_array;
    public int pattern_num;//무슨 패턴을 쓸건지
    //스테이지
    public bool is_stage;
    public TextMeshProUGUI stage_cnt_Text;
    public int stage_cnt;
    //플레이어
    public int hp;
    //시간
    public TextMeshProUGUI time_Text;
    public float time;
    //설명
    public GameObject explain;
    public TextMeshProUGUI explain1;
    public TextMeshProUGUI explain2;
    public TextMeshProUGUI explain3;
    public TextMeshProUGUI explain4;
    //소리
    public GameObject sound;
    public AudioSource move_Sound;
    public AudioSource x_Pattern;
    public AudioSource square_Pattern;
    public AudioSource laser_Pattern;
    public AudioSource drop_Pattern;
    public AudioSource turn_Pattern;
    public AudioSource line_Pattern;
    public AudioSource heart_Pattern;
    public AudioSource view_Pattern;
    public AudioSource big_Pattern;


    void Awake()
    {
        Time.timeScale = 1;
        manager = this;

        is_pattern = true;
        pattern_CoolTime = 1;
        pattern_Tmp_CoolTime = pattern_CoolTime;

        retry.gameObject.SetActive(false);

        hp = 3;

        stage_cnt = 0;
        time = 0;
        is_stage = false;
    }

    private void Start()
    {
        Pick_Random();
        Explain();
        stage_cnt_Text.gameObject.SetActive(true);


        if (Data.Instance.gameData.sound_off == false)
        {
            sound.gameObject.SetActive(true);
        }
        else
        {
            sound.gameObject.SetActive(false);
        }
    }

    private void Update()
    {
        time += Time.deltaTime;
        time_Text.text = string.Format("{0:N1}", time);

        //패턴 고르기
        if (is_pattern == false )
        {
            pattern_Tmp_CoolTime -= Time.deltaTime;
            if(pattern_Tmp_CoolTime <= 0 && is_stage == false)
            {
                stage_cnt++;
                is_stage = true;
                stage_cnt_Text.text = "Stage" + stage_cnt;

                is_pattern = true;
                is_stage = false;
                pattern_Tmp_CoolTime = pattern_CoolTime;
                Debug.Log("패턴 고르기");
                Pick_Pattern();
            }
        }

        if(hp <= 0)
        {
            Time.timeScale = 0;
        }

    }

    public void Explain()
    {
        explain.gameObject.SetActive(true);
        StartCoroutine(nameof(Explain_Pattern));
        
    }

    IEnumerator Explain_Pattern()
    {
        explain1.gameObject.transform.localPosition = new Vector3(-375f, 0, 0);
        explain2.gameObject.transform.localPosition = new Vector3(-125f, 0, 0);
        explain3.gameObject.transform.localPosition = new Vector3(125f, 0, 0);
        explain4.gameObject.transform.localPosition = new Vector3(375f, 0, 0);

        do
        {
            pattern_num = Random.Range(0, 20);
        } while (pattern_array[pattern_num] == 100);

        pattern_array[pattern_num] = 100;

        if (pattern_num == 0)
        {
            explain1.text = "회";
            explain2.text = "피";
            explain3.text = "하";
            explain4.text = "라";
        }
        else if (pattern_num == 1)
        {
            explain1.text = "회";
            explain2.text = "피";
            explain3.text = "하";
            explain4.text = "라";
        }
        else if (pattern_num == 2)
        {
            explain1.text = "따";
            explain2.text = "라";
            explain3.text = "해";
            explain4.text = "라";
        }
        else if (pattern_num == 3)
        {
            explain1.text = "이";
            explain2.text = "동";
            explain3.text = "해";
            explain4.text = "라";
        }
        else if (pattern_num == 4)
        {
            explain1.text = "회";
            explain2.text = "피";
            explain3.text = "해";
            explain4.text = "라";
        }
        else if (pattern_num == 5)
        {
            explain1.text = "회";
            explain2.text = "피";
            explain3.text = "해";
            explain4.text = "라";
        }
        else if (pattern_num == 6)
        {
            explain1.text = "도";
            explain2.text = "망";
            explain3.text = "쳐";
            explain4.text = "라";
        }
        else if (pattern_num == 7)
        {
            explain1.text = "따";
            explain2.text = "라";
            explain3.text = "해";
            explain4.text = "라";
        }
        else if (pattern_num == 8)
        {
            explain1.text = "회";
            explain2.text = "피";
            explain3.text = "해";
            explain4.text = "라";
        }
        else if (pattern_num == 9)
        {
            explain1.text = "회";
            explain2.text = "피";
            explain3.text = "해";
            explain4.text = "라";
        }
        else if (pattern_num == 10)
        {
            explain1.text = "회";
            explain2.text = "피";
            explain3.text = "해";
            explain4.text = "라";
        }
        else if (pattern_num == 11)
        {
            explain1.text = "회";
            explain2.text = "피";
            explain3.text = "해";
            explain4.text = "라";
        }
        else if (pattern_num == 12)
        {
            explain1.text = "똑";
            explain2.text = "딱";
            explain3.text = "똑";
            explain4.text = "딱";
        }
        else if (pattern_num == 13)
        {
            explain1.text = "따";
            explain2.text = "라";
            explain3.text = "가";
            explain4.text = "라";
        }
        else if (pattern_num == 14)
        {
            explain1.text = "회";
            explain2.text = "피";
            explain3.text = "해";
            explain4.text = "라";
        }
        else if (pattern_num == 15)
        {
            explain1.text = "도";
            explain2.text = "망";
            explain3.text = "쳐";
            explain4.text = "라";
        }
        else if (pattern_num == 16)
        {
            explain1.text = "부";
            explain2.text = "딪";
            explain3.text = "쳐";
            explain4.text = "라";
        }
        else if (pattern_num == 17)
        {
            explain1.text = "회";
            explain2.text = "피";
            explain3.text = "해";
            explain4.text = "라";
        }
        else if (pattern_num == 18)
        {
            explain1.text = "회";
            explain2.text = "피";
            explain3.text = "해";
            explain4.text = "라";
        }
        else if (pattern_num == 19)
        {
            explain1.text = "이";
            explain2.text = "동";
            explain3.text = "해";
            explain4.text = "라";
        }


        for (int i = 0; i < 15; i++)
        {
            explain1.gameObject.transform.Translate(Vector3.left * 3f);
            explain2.gameObject.transform.Translate(Vector3.left * 3f);
            explain3.gameObject.transform.Translate(Vector3.left * 3f);
            explain4.gameObject.transform.Translate(Vector3.left * 3f);

            yield return new WaitForSeconds(0.01f);
        }
        for (int i = 0; i < 15; i++)
        {
            explain1.gameObject.transform.Translate(Vector3.right * 3f);
            explain2.gameObject.transform.Translate(Vector3.right * 3f);
            explain3.gameObject.transform.Translate(Vector3.right * 3f);
            explain4.gameObject.transform.Translate(Vector3.right * 3f);

            yield return new WaitForSeconds(0.01f);
        }
        for (int i = 0; i < 15; i++)
        {
            explain1.gameObject.transform.Translate(Vector3.left * 3f);
            explain2.gameObject.transform.Translate(Vector3.left * 3f);
            explain3.gameObject.transform.Translate(Vector3.left * 3f);
            explain4.gameObject.transform.Translate(Vector3.left * 3f);

            yield return new WaitForSeconds(0.01f);
        }
        for (int i = 0; i < 15; i++)
        {
            explain1.gameObject.transform.Translate(Vector3.right * 3f);
            explain2.gameObject.transform.Translate(Vector3.right * 3f);
            explain3.gameObject.transform.Translate(Vector3.right * 3f);
            explain4.gameObject.transform.Translate(Vector3.right * 3f);

            yield return new WaitForSeconds(0.01f);
        }
        for (int i = 0; i < 15; i++)
        {
            explain1.gameObject.transform.Translate(Vector3.left * 3f);
            explain2.gameObject.transform.Translate(Vector3.left * 3f);
            explain3.gameObject.transform.Translate(Vector3.left * 3f);
            explain4.gameObject.transform.Translate(Vector3.left * 3f);

            yield return new WaitForSeconds(0.01f);
        }
        for (int i = 0; i < 15; i++)
        {
            explain1.gameObject.transform.Translate(Vector3.right * 3f);
            explain2.gameObject.transform.Translate(Vector3.right * 3f);
            explain3.gameObject.transform.Translate(Vector3.right * 3f);
            explain4.gameObject.transform.Translate(Vector3.right * 3f);

            yield return new WaitForSeconds(0.01f);
        }
        for (int i = 0; i < 15; i++)
        {
            explain1.gameObject.transform.Translate(Vector3.left * 3f);
            explain2.gameObject.transform.Translate(Vector3.left * 3f);
            explain3.gameObject.transform.Translate(Vector3.left * 3f);
            explain4.gameObject.transform.Translate(Vector3.left * 3f);

            yield return new WaitForSeconds(0.01f);
        }
        for (int i = 0; i < 15; i++)
        {
            explain1.gameObject.transform.Translate(Vector3.right * 3f);
            explain2.gameObject.transform.Translate(Vector3.right * 3f);
            explain3.gameObject.transform.Translate(Vector3.right * 3f);
            explain4.gameObject.transform.Translate(Vector3.right * 3f);

            yield return new WaitForSeconds(0.01f);
        }
        for (int i = 0; i < 15; i++)
        {
            explain1.gameObject.transform.Translate(Vector3.left * 3f);
            explain2.gameObject.transform.Translate(Vector3.left * 3f);
            explain3.gameObject.transform.Translate(Vector3.left * 3f);
            explain4.gameObject.transform.Translate(Vector3.left * 3f);

            yield return new WaitForSeconds(0.01f);
        }
        for (int i = 0; i < 15; i++)
        {
            explain1.gameObject.transform.Translate(Vector3.right * 3f);
            explain2.gameObject.transform.Translate(Vector3.right * 3f);
            explain3.gameObject.transform.Translate(Vector3.right * 3f);
            explain4.gameObject.transform.Translate(Vector3.right * 3f);

            yield return new WaitForSeconds(0.01f);
        }
        is_pattern = false;
        explain.gameObject.SetActive(false);
    }

    public void Pick_Random()
    {
        pattern_array = new int[20] { 1, 2, 3, 100, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 100, 16, 17, 100, 100, 20 };
    }
    
    public void Pick_Pattern()
    {
        //SquarePattern();//Clear, sound
        //Pattern_Laser();//clear, sound
        //XPattern();//Clear. sound
        //StarPattern();//delete
        //DropPattern();//Clear, sound
        //DiaPattern();//Clear, sound
        //TurnPattern();//Clear, sound
        //ArrowPattern();//Clear
        //BigPattern();//Clear, sound
        //LinePattern();//Clear, sound
        //SpeedPattern();//Clear, sound
        //SmoothPattern();//Clear, sound
        //TictocPattern();//Clear
        //RBRPattern();//Clear
        //FanPattern();//Delete
        //CannonPattern();//Clear, sound
        //HeartPattern();//Clear, sound
        //OffWhitePattern();//Delete
        //TripplePattern();//Delete
        //ViewPattern();//Clear, sound

        //본체
        if (pattern_array[0] == 100 && pattern_array[1] == 100 && pattern_array[2] == 100 && pattern_array[3] == 100 && pattern_array[4] == 100 &&
            pattern_array[5] == 100 && pattern_array[6] == 100 && pattern_array[7] == 100 && pattern_array[8] == 100 && pattern_array[9] == 100 &&
            pattern_array[10] == 100 && pattern_array[11] == 100 && pattern_array[12] == 100 && pattern_array[13] == 100 && pattern_array[14] == 100 &&
            pattern_array[15] == 100 && pattern_array[16] == 100 && pattern_array[17] == 100 && pattern_array[18] == 100 && pattern_array[19] == 100)
        {
            Pick_Random();
        }

        if (pattern_num == 0)
        {
            SquarePattern();//clear
        }
        else if (pattern_num == 1)
        {
            Pattern_Laser();//clear
        }
        else if (pattern_num == 2)
        {
            XPattern();//안됨
        }
        else if (pattern_num == 3)
        {
            StarPattern();
        }
        else if (pattern_num == 4)
        {
            DropPattern();
        }
        else if (pattern_num == 5)
        {
            DiaPattern();
        }
        else if (pattern_num == 6)
        {
            TurnPattern();
        }
        else if (pattern_num == 7)
        {
            ArrowPattern();
        }
        else if (pattern_num == 8)
        {
            BigPattern();
        }
        else if (pattern_num == 9)
        {
            LinePattern();
        }
        else if (pattern_num == 10)
        {
            SpeedPattern();
        }
        else if (pattern_num == 11)
        {
            SmoothPattern();
        }
        else if (pattern_num == 12)
        {
            TictocPattern();
        }
        else if (pattern_num == 13)
        {
            RBRPattern();
        }
        else if (pattern_num == 14)
        {
            FanPattern();
        }
        else if (pattern_num == 15)
        {
            CannonPattern();
        }
        else if (pattern_num == 16)
        {
            HeartPattern();
        }
        else if (pattern_num == 17)
        {
            OffWhitePattern();
        }
        else if (pattern_num == 18)
        {
            TripplePattern();
        }
        else if (pattern_num == 19)
        {
            ViewPattern();
        }
    }

    public void Pattern_Laser()
    {
        objectManager.LaserPattern();
    }

    public void SquarePattern()
    {
        objectManager.SquarePattern();
    }

    public void XPattern()
    {
        objectManager.x_cnt--;
        objectManager.XPattern();
    }

    public void StarPattern()
    {
        objectManager.StarPattern();  
    }

    public void DropPattern()
    {
        objectManager.DropPattern();
    }

    public void DiaPattern()
    {
        objectManager.DiaPattern();
    }

    public void TurnPattern()
    {
        objectManager.TurnPattern();
    }

    public void ArrowPattern()
    {
        objectManager.ArrowPattern();
    }

    public void BigPattern()
    {
        objectManager.BigPattern();
    }

    public void LinePattern()
    {
        objectManager.LinePattern();
    }

    public void SpeedPattern()
    {
        objectManager.SpeedPattern();
    }

    public void SmoothPattern()
    {
        objectManager.SmoothPattern();
    }

    public void TictocPattern()
    {
        objectManager.TictocPattern();
    }

    public void RBRPattern()
    {
        objectManager.RBRPattern();
    }

    public void FanPattern()
    {
        objectManager.FanPattern();
    }

    public void CannonPattern()
    {
        objectManager.CannonPattern();
    }

    public void HeartPattern()
    {
        objectManager.HeartPattern();
    }

    public void MovePattern()
    {
        objectManager.MovePattern();
    }

    public void OffWhitePattern()
    {
        objectManager.OffWhitePattern();
    }

    public void TripplePattern()
    {
        objectManager.TripplePattern();
    }

    public void ViewPattern()
    {
        objectManager.ViewPattern();
    }

    public void Hit_Player()
    {
        Debug.Log("맞기");
        StopCoroutine(nameof(Hit_Player_Effect));
        StartCoroutine(nameof(Hit_Player_Effect));
    }

    IEnumerator Hit_Player_Effect()
    {
        player.gameObject.tag = "Untagged";

        yield return new WaitForSeconds(0.5f);
        player.gameObject.tag = "Player";
    }


    public void Retry()
    {
        SceneManager.LoadScene("GameScene");
    }

    public void Main_Page()
    {
        SceneManager.LoadScene("MainScene");
    }
}
