using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GooglePlayGames;
using UnityEngine.UI;

public class GoogleManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Awake()
    {
        PlayGamesPlatform.DebugLogEnabled = true;
        PlayGamesPlatform.Activate();
        LogIn();
    }

    public void LogIn()
    {
        Social.localUser.Authenticate((bool success) =>
        {
            
        });
    }

    public void ShowLeaderboardUI() => Social.ShowLeaderboardUI();
}
