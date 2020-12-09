using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

[RequireComponent(typeof(Rigidbody2D))]
public class Player : MonoBehaviour {
    private int timeplayed;
	public float movementSpeed = 10f;
	private Rigidbody2D rb;
	float movement = 0f;
    public float topscore;
    public float intscore;

    public Text Highscore;
    public Text score;
    public Text startText;
    public bool isStarted = false;
    public Restart restartgame;
    public MenuButtons menu;

    // Use this for initialization
    void Start () {
		rb = GetComponent<Rigidbody2D>();
        rb.gravityScale = 0;
        Highscore.text = PlayerPrefs.GetInt("HighScore",0).ToString();
        //  DontDestroyOnLoad(gameObject);
        isStarted = false;
	}
    private void OnBecameInvisible()
    {
        restartgame.RestartGame();
        topscore = menu.Highscore; 
        // Destroy(gameObject);
    }
    // Update is called once per frame
    void Update()
    {
        movement = Input.GetAxis("Horizontal") * movementSpeed;
        if (rb.velocity.y > 0 && transform.position.y > topscore)
        {
            topscore = transform.position.y;
        }

        score.text = "Score:" + Mathf.Round(topscore).ToString();

        if (Input.GetKeyDown(KeyCode.Space) && isStarted == false)
        {
            isStarted = true;
            startText.gameObject.SetActive(false);
          
        }
        // Store in playerPrefs 
        
            
        if (topscore > PlayerPrefs.GetInt("HighScore", (int)topscore))
        {
            PlayerPrefs.SetInt("HighScore", (int)topscore);
            intscore = (int)topscore;
            Highscore.text = intscore.ToString();


        }
        
      
    }
        void FixedUpdate()
	{
        Vector2 velocity = rb.velocity;
        velocity.x = movement;
        rb.velocity = velocity;
        if(isStarted == true)
        {
            rb.gravityScale = 1;
        }
        timeplayed = (int)Time.deltaTime;
        menu.timeplayed.text = timeplayed.ToString();
       
	}
}
