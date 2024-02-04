using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{

    public Text playerScore, computerScore;
    public int playersScore, computersScore = 0;


    
    // Start is called before the first frame update
    void Start()
    {
        computersScore = 0;
        playersScore = 0;
    }

    public void OnTriggerEnter(Collider collision) {

        if (collision.CompareTag("Playerr"))
            computersScore += 1;
        else if (collision.CompareTag("Computer"))
            playersScore += 1;

    }

    public void updateScore() {

        playerScore.text = "Player: " + playersScore;
        computerScore.text = "Computer: " + computersScore;

    }


    // Update is called once per frame
    void Update()
    {
        updateScore();
    }
}
