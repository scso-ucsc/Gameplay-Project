using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameOverManager : MonoBehaviour
{
    public static GameOverManager instance;
    [SerializeField] private TextMeshProUGUI playerWinText;
    [SerializeField] private TextMeshProUGUI playerLoseText;
    void Awake(){
        if(instance == null){
            instance = this;
        } else{
            Destroy(this);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        if(GameManager.instance.getPlayerWin() == true){
            playerWinText.enabled = true;
            playerLoseText.enabled = false;
        } else{
            playerWinText.enabled = false;
            playerLoseText.enabled = true;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
