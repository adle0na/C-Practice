using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] GameObject[] goGameUI = null;
    [SerializeField] GameObject goTitleUI = null;

    public static GameManager instance;

    public bool isStartGame = false;

    ComboManager theCombo;
    ScoreManager theScore;
    TimingManager thetiming;
    StatusManager theStatus;
    PlayerController thePlayer;
    StageManager theStage;
    NoteManager theNote;
    [SerializeField] CenterFrame theMusic = null;

    void Start()
    {
        instance = this;
        theStage = FindObjectOfType<StageManager>();
        theCombo = FindObjectOfType<ComboManager>();
        theScore = FindObjectOfType<ScoreManager>();
        thetiming = FindObjectOfType<TimingManager>();
        theStatus = FindObjectOfType<StatusManager>();
        thePlayer = FindObjectOfType<PlayerController>();
        theNote = FindObjectOfType<NoteManager>();

    }

    public void GameStart(int p_songNum, int p_bpm)
    {
        for(int i = 0; i < goGameUI.Length; i++)
        {
            goGameUI[i].SetActive(true);
        }

        theMusic.bgmName = "BGM" + p_songNum;
        theNote.bpm = p_bpm;
        theStage.RemoveStage();
        theStage.SettingStage(p_songNum);
        theCombo.ResetCombo();
        theScore.Initialized();
        thetiming.Initialized();
        theStatus.Initialized();
        thePlayer.Initialized();

        AudioManager.instance.StopBGM();

        isStartGame = true;
    }

   public void MainMenu()
    {
        for (int i = 0; i < goGameUI.Length; i++)
        {
            goGameUI[i].SetActive(false);
        }

        goTitleUI.SetActive(true);
    }
}
