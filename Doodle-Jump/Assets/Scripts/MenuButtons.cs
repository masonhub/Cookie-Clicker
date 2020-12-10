using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

    public class MenuButtons : MonoBehaviour
    {
        public int LoadedScore, Highscore;
        // public Restart game;
 [SerializeField] public Text CurrentScore, Highscores;
 [SerializeField] public Text timeplayed;
        public Animator doodler, doodlerjetpack;

        private void Start()
        {
        LoadedScore = PlayerPrefs.GetInt("HighScore");
     //   Highscore = PlayerPrefs.GetInt("Score", LoadedScore);
        timeplayed.text = PlayerPrefs.GetInt("Time", (int)Time.timeSinceLevelLoad).ToString();
        }


        public void ChangeScene(int sceneIndex)
        {
            SceneManager.LoadScene(sceneIndex);

           // DontDestroyOnLoad()
        }
        public void QuitGame()
        {
#if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;
#endif
            Application.Quit();
        }

        public void animatorplay()
        {
            doodler.speed = 1;
            doodlerjetpack.speed = 1;  
        }

        public void animatorpause()
        {
           doodlerjetpack.speed = 0;
           doodler.speed =0;
            
        }

    public void ResetScore()
    {
        PlayerPrefs.DeleteAll();
        LoadedScore = 0;
        Highscore = 0;
        CurrentScore.text = LoadedScore.ToString();
        Highscores.text = Highscore.ToString();
    }

        public void LoadScore()
        {
         //   pscore.topscore = LoadedScore;
         //   pscore.intscore = Highscore;
            PlayerPrefs.GetInt("HighScore", (int)LoadedScore);
            PlayerPrefs.GetInt("Score", (int)Highscore);
            PlayerPrefs.GetInt("Time", (int)Time.timeSinceLevelLoad);
            CurrentScore.text = LoadedScore.ToString() ;
            Highscores.text = Highscore.ToString();
        }

        public void LoadFile()
        {
            string filePath = Application.dataPath + "/SaveFile.SAV";
            Debug.Log(filePath);
            FileStream file;

            if (File.Exists(filePath))
            {
                file = File.OpenRead(filePath);
            }
            else
            {
                Debug.LogError("Save file not found");
                return;
            }

            BinaryFormatter bf = new BinaryFormatter();
        //    GameData data = (GameData)bf.Deserialize(file);
            file.Close();

        //    LoadedScore = data.Score;

        }
    }
