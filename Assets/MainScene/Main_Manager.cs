using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Main_Manager : MonoBehaviour
{
    public Camera main_Camera;

    public int stage_num;

    public GameObject stage1_yes_button;
    public GameObject stage1_no_button;
    public GameObject stage2_yes_button;
    public GameObject stage2_no_button;

    public GameObject box_stage1;
    public GameObject player_stage1;

    public GameObject box_stage2;
    public GameObject player_stage2;

    public GameObject gameStart_Button;
    public GameObject comingSoon_Button;

    public GameObject sound_on;
    public GameObject sound_off;

    public GameObject sound;
    public AudioSource button_Audio;

    public AudioSource bgm1_Audio;
    public AudioSource bgm2_Audio;

    private void Start()
    {
        bgm1_Audio.gameObject.SetActive(false);
        bgm2_Audio.gameObject.SetActive(false);


        if (Data.Instance.gameData.sound_off == false)
        {
            sound_on.gameObject.SetActive(true);
            sound_off.gameObject.SetActive(false);

            bgm1_Audio.gameObject.SetActive(true);
            bgm2_Audio.gameObject.SetActive(false);

            sound.gameObject.SetActive(true);
        }
        else
        {
            sound_on.gameObject.SetActive(false);
            sound_off.gameObject.SetActive(true);


            sound.gameObject.SetActive(false);
        }


        stage_num = 1;

        stage1_yes_button.gameObject.SetActive(true);
        stage1_no_button.gameObject.SetActive(false);
        stage2_yes_button.gameObject.SetActive(false);
        stage2_no_button.gameObject.SetActive(true);

        box_stage1.gameObject.SetActive(true);
        player_stage1.gameObject.SetActive(true);
        box_stage2.gameObject.SetActive(false);
        player_stage2.gameObject.SetActive(false);

        gameStart_Button.gameObject.SetActive(true);
        comingSoon_Button.gameObject.SetActive(false);

    }

    public void GameStart()
    {
        SceneManager.LoadScene("GameScene");
    }

    public void Next_Stage()
    {
        if (stage_num == 2)
        {
            stage1_yes_button.gameObject.SetActive(true);
            stage1_no_button.gameObject.SetActive(false);
            stage2_yes_button.gameObject.SetActive(false);
            stage2_no_button.gameObject.SetActive(true);


            box_stage1.gameObject.SetActive(true);
            player_stage1.gameObject.SetActive(true);
            box_stage2.gameObject.SetActive(false);
            player_stage2.gameObject.SetActive(false);

            gameStart_Button.gameObject.SetActive(true);
            comingSoon_Button.gameObject.SetActive(false);


            bgm1_Audio.gameObject.SetActive(true);
            bgm2_Audio.gameObject.SetActive(false);

            stage_num = 1;
        }
        else if(stage_num == 1)
        {
            stage1_yes_button.gameObject.SetActive(false);
            stage1_no_button.gameObject.SetActive(true);
            stage2_yes_button.gameObject.SetActive(true);
            stage2_no_button.gameObject.SetActive(false);

            box_stage1.gameObject.SetActive(false);
            player_stage1.gameObject.SetActive(false);
            box_stage2.gameObject.SetActive(true);
            player_stage2.gameObject.SetActive(true);

            gameStart_Button.gameObject.SetActive(false);
            comingSoon_Button.gameObject.SetActive(true);

            bgm1_Audio.gameObject.SetActive(false);
            bgm2_Audio.gameObject.SetActive(true);

            stage_num = 2;
        }
    }

    public void Sound_Change()
    {
        if(Data.Instance.gameData.sound_off == false)
        {
            sound_on.gameObject.SetActive(false);
            sound_off.gameObject.SetActive(true);

            Data.Instance.gameData.sound_off = true;

            sound.gameObject.SetActive(false);
            Data.Instance.SaveGameData();
        }
        else
        {
            sound_on.gameObject.SetActive(true);
            sound_off.gameObject.SetActive(false);

            Data.Instance.gameData.sound_off = false;

            sound.gameObject.SetActive(true);
            Data.Instance.SaveGameData();
        }
    }
}
