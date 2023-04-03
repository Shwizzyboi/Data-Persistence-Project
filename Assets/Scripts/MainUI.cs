using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainUI : MonoBehaviour
{
    public Text highScoreText;
    //public DataManager DataManager;

    private void Start()
    {
        /*string name = DataManager.Instance.playerName;
        highScoreText.text = "Best Score: " + name + " : " + DataManager.highScore;*/
    }

    public void BackToMenu()
    {
        SceneManager.LoadScene(0);
    }
}
