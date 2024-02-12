using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro; //Needed for using TextMeshPro

public class UIManager : MonoBehaviour
{
    public static UIManager instance;
    [SerializeField] private TextMeshProUGUI playerScoreText;
    [SerializeField] private TextMeshProUGUI playerAmmoText;
    [SerializeField] private Canvas playerScope;

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
        if(GameManager.instance.getDifficulty() == "Easy"){
            playerScope.enabled = true;
        } else{
            playerScope.enabled = false;
        }
    }

    // Update is called once per frame
    void Update()
    {
        playerAmmoText.text = "Ammo: " + GameManager.instance.getAmmoCount().ToString(); //Updating ammo constantly
        playerScoreText.text = "Score: " + GameManager.instance.getPlayerScore().ToString(); //Updating score constantly
    }
}
