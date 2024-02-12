using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    //Game Manager Variable
    public static GameManager instance; //Static enables it to be called anywhere
    private static int ammoCount;
    private static int playerScore;
    private static string gameDifficulty = "Easy";

    // Awake is called upon creation, before everything else 
    void Awake(){
        if(instance == null){
            instance = this; //If this is the first instance of the game manager, create it
        } else{
            Destroy(this); //Else, destroy it and keep original instance
        }
    }

    void Start(){
        ammoCount = 5;
        playerScore = 0;
    }

    public int getAmmoCount(){
        return ammoCount;
    }

    public int getPlayerScore(){
        return playerScore;
    }

    public void subtractAmmo(){
        ammoCount -= 1;
    }

    public void addAmmo(int addAmmoValue){
        ammoCount += addAmmoValue;
    }

    public void addScore(int addScoreValue){
        playerScore += addScoreValue;
    }

    public void gameOver(){
        SceneManager.LoadScene("MainMenuScene"); //Change!!!
    }

    public void switchToHard(){
        gameDifficulty = "Hard";
    }

    public void switchToEasy(){
        gameDifficulty = "Easy";
    }

    public string getDifficulty(){
        return gameDifficulty;
    }
}
