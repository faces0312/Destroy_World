using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Retry : MonoBehaviour
{
    public Manager manager;
    //종료 페이지
    public TextMeshProUGUI ending_Time;
    public TextMeshProUGUI ending_Stage;

    public AdmobManager admob;
    public Admob_Front admob_Front;

    // Start is called before the first frame update
    void OnEnable()
    {
        Data.Instance.gameData.num++;
        if (Data.Instance.gameData.num % 5 == 0)
        {
            admob.ShowRewardAd();
            if (Data.Instance.gameData.stage <= manager.stage_cnt)
            {
                Data.Instance.gameData.stage = manager.stage_cnt;
                Social.ReportScore(Data.Instance.gameData.stage, GPGSIds.leaderboard, (bool success) => { });
                Data.Instance.SaveGameData();
            }
        }
        else if(Data.Instance.gameData.num % 3 == 0)
        {
            admob_Front.ShowAd();
            if (Data.Instance.gameData.stage <= manager.stage_cnt)
            {
                Data.Instance.gameData.stage = manager.stage_cnt;
                Social.ReportScore(Data.Instance.gameData.stage, GPGSIds.leaderboard, (bool success) => { });
                Data.Instance.SaveGameData();
            }
        }
        else
        {
            if (Data.Instance.gameData.stage <= manager.stage_cnt)
            {
                Data.Instance.gameData.stage = manager.stage_cnt;
                Social.ReportScore(Data.Instance.gameData.stage, GPGSIds.leaderboard, (bool success) => { });
                Data.Instance.SaveGameData();
            }
        }
        


        ending_Stage.text = manager.stage_cnt.ToString();

        if(manager.time < 60)
        {
            ending_Time.text = ((int)manager.time).ToString() + "초";
        }
        else
        {
            ending_Time.text = ((int)manager.time / 60).ToString() + "분 " + ((int)manager.time % 60).ToString() + "초";
        }
    }

}
