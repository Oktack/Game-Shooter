using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Winning : MonoBehaviour
{
    public Text scoreText;
    private int score;
    public GameObject Enemy;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void SetScoreText()
    {
        scoreText.text = "Score " + score.ToString();
        if (score >= 20)
        {
            Destroy(gameObject);
            SceneManager.LoadScene("Finish");
            return;
        }
    }
}
