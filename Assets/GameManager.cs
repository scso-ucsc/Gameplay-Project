using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    //Game Manager Variable
    public static GameManager instance {get; private set;} //Static enables it to be called anywhere

    // Awake is called upon creation, before everything else 
    void Awake(){
        if(instance == null){
            instance = this; //If this is the first instance of the game manager, create it
        } else{
            Destroy(this); //Else, destroy it and keep original instance
        }
    }
}
