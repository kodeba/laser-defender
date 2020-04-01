using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ScoreDisplay : MonoBehaviour
{
    TextMeshProUGUI scoreText;
    GameSession session;

    // Start is called before the first frame update
    void Start()
    {
        scoreText = GetComponent<TextMeshProUGUI>();
        session = FindObjectOfType<GameSession>();
    }

    // Update is called once per frame
    void Update()
    {
        var score = session.GetScore().ToString();
        Debug.Log("score : " + score);
        scoreText.text = session.GetScore().ToString();
    }

}
