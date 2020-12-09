using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Restart : MonoBehaviour
{
    public Transform doodle;
    public int pos;

    private Vector2 StartPoint;

    public void Start()
    {
        StartPoint = this.transform.position;
    }
    // Update is called once per frame
    public void Reset()
    {
        Time.timeScale = 1;
        transform.position = StartPoint;

    }
}
