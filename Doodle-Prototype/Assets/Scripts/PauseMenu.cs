using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PauseMenu : MonoBehaviour {

	public GameObject ui;
    public GameObject tips;

	public string menuSceneName = "MainMenu";

    //	public SceneFader sceneFader;
    private void Awake()
    {
        Time.timeScale = 1;
    }

    void Update ()
	{
		if (Input.GetKeyDown(KeyCode.Escape) || Input.GetKeyDown(KeyCode.P))
		{
			Toggle();
		}

        if (Input.GetKeyDown(KeyCode.L))
        {
            tips.SetActive(false);
        }


    }

	public void Toggle ()
	{
		ui.SetActive(!ui.activeSelf);

		if (ui.activeSelf)
		{
			Time.timeScale = 0f;
		} else
		{
			Time.timeScale = 1f;
		}
	}

	public void Retry ()
	{
		Toggle();
		//sceneFader.FadeTo(SceneManager.GetActiveScene().name);
    }

	public void Menu (int scene)
	{
        SceneManager.LoadScene(scene);
		//sceneFader.FadeTo(menuSceneName);
	}

}
