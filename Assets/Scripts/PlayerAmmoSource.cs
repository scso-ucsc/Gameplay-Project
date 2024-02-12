using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAmmoSource : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    private void OnTriggerEnter(Collider collider){
        if(collider.tag == "Player"){ //Adding ammo to player then deactivating
            GameManager.instance.addAmmo(5);
            this.gameObject.SetActive(false);
        }
    }
}
