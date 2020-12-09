using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Restart : MonoBehaviour
{
    public Transform doodle;
    public Player pos;
    private Vector2 StartPoint;
    public GameObject gameOver,gamemenu;
    

    public void Start()
    {
        StartPoint = this.transform.position;

    }
    // Update is called once per frame
    public void RestartGame()
    {
        if (gamemenu != null)
        {
            if (gameOver != null)
            {
                gameOver.SetActive(true);
                gamemenu.SetActive(false);
                doodle.transform.position = StartPoint;
                Debug.Log("Death");
            }
        }
        else if (gamemenu == null)
        {
        }
    }
    public void ResetScore()
    {
        PlayerPrefs.DeleteKey("HighScore");
        pos.Highscore.text = "0";
        
    }
}
