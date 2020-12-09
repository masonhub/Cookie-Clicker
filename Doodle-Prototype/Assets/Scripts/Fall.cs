using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fall : MonoBehaviour
{
    public Vector3 doodle;

    public Player doodlleSpawn;
    public GameObject menu;
    // Update is called once per frame
    void Update()
    {

    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Restart");
        Time.timeScale = 0;
        menu.SetActive(true);

        
        doodle.x = 0;
        doodle.y = 0;
    }
}
