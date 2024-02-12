using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuManager : MonoBehaviour
{
    [SerializeField] private Canvas MainMenuUI;
    [SerializeField] private Canvas OptionsUI;
    [SerializeField] private Canvas CreditsUI;

    // Start is called before the first frame update
    void Start()
    {
        ReturnToMainMenu();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartGame(){
        SceneManager.LoadScene("PlayScene");
    }

    public void OpenOptions(){
        OptionsUI.enabled = true;
        MainMenuUI.enabled = false;
    }

    public void OpenCredits(){
        CreditsUI.enabled = true;
        MainMenuUI.enabled = false;
    }

    public void ReturnToMainMenu(){
        MainMenuUI.enabled = true;
        OptionsUI.enabled = false;
        CreditsUI.enabled = false;
    }
}
