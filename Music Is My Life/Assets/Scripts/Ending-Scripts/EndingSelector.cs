using System.Collections;
using UnityEngine;

public class EndingSelector : MonoBehaviour
{
    public SceneMove sceneMoveScript;

    void Start()
    {
        SelectEnding();
    }

    public void SelectEnding() // 엔딩으로
    {
        int money = PlayerPrefs.GetInt("Money");
        int myFame = PlayerPrefs.GetInt("MyFame");
        int bandFame = PlayerPrefs.GetInt("BandFame");
        string endingScene;

        if (money >= 150)
        {
            endingScene = "Ending-Expedition";
        }
        else if (myFame >= 75)
        {
            endingScene = "Ending-OpeningBand";
        }
        else if (bandFame >= 150)
        {
            endingScene = "Ending-ConcertInKorea";
        }
        else
        {
            endingScene = "Ending-Normal";
        }

        // 엔딩 잠금 해제 및 저장
        PlayerPrefs.SetString("Ending", endingScene);
        sceneMoveScript.targetScene = endingScene;
        sceneMoveScript.ChangeScene();
    }
}