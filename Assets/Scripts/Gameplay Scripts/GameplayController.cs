using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameplayController : MonoBehaviour
{
    public static GameplayController instance;

    [SerializeField]
    private Text enemyKillCountTxt;

    private int enemyKillCount;

    private void Awake()
    {
        if (instance == null)
            instance = this;
    }
    public void EnemyKilled()
    {
        enemyKillCount++;
        enemyKillCountTxt.text = "Enemies Killed : " + enemyKillCount;
    }
    public void RestartGame()
    {
        Invoke(nameof(Restart), 3f);
    }

    private void Restart()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("Gameplay");
    }
}
