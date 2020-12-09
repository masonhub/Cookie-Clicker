using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement;


public class MenuFunctions : MonoBehaviour
{
    public AudioClip[] clicks;
    public AudioSource Audio;
    public GameObject PauseMenu;


    public bool Pause;


    void Start()
    {
        Debug.Log("Start, First frame the object exists and is active only if the script is also active");
    }
    void Update()
    {

    }

    #region collision code
    void OnTriggerEnter(Collider other)
    {

    }
    void OnTriggerStay(Collider other)
    {

    }
    void OnTriggerExit(Collider other)
    {

    }
    void OnCollisionEnter(Collision collision)
    {

    }
    void OnCollisionStay(Collision collision)
    {

    }
    void OnCollisionExit(Collision collision)
    {

    }

    #endregion

    public void ChangeScene(int Sceneindex)
    {
        SceneManager.LoadScene(Sceneindex);
    }

    public void QuitGame()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#endif
        Application.Quit();
    }

    public void AudioClicked()
    {
        int i = Random.Range(0, clicks.Length);
        Audio.clip = clicks[i];
        Audio.Play();
    }
}
