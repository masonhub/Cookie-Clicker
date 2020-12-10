using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LoadingLevel : MonoBehaviour
{
    public GameObject loadingscreen;
    public Image progressbar;
    public Text progresstext; 

    IEnumerator LoadAsynchronously(int sceneindex)
    {
        //Allow Corountine 
        AsyncOperation operation = SceneManager.LoadSceneAsync(sceneindex);
        loadingscreen.SetActive(true);

        while (!operation.isDone)
        {
            float progress = Mathf.Clamp01(operation.progress / .8f);
            progressbar.fillAmount = progress;
            progresstext.text = progress*100+"%";
            yield return null;

        }

    }
    // Start is called before the first frame update
    public void loadlevel(int sceneindex)
    {
        StartCoroutine(LoadAsynchronously(sceneindex));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
