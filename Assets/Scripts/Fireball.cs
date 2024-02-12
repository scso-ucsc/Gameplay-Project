using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fireball : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collider){
        if(collider.gameObject.tag == "Wall"){ //If fireball collides with a wall, disable the fireball
            this.gameObject.GetComponent<Rigidbody>().velocity = Vector3.zero; //Resetting velocity to 0 so that if active again, that force no longer applies
            this.gameObject.SetActive(false);
        } else if(collider.gameObject.tag == "Coin"){
            Destroy(collider.gameObject);
            this.gameObject.GetComponent<Rigidbody>().velocity = Vector3.zero; //Resetting velocity to 0 so that if active again, that force no longer applies
            this.gameObject.SetActive(false);
            GameManager.instance.addScore(50);
            //UIManager.instance.addScore(LootManager.instance.generateCoinValue()); //Adding score to UI
        } else if(collider.gameObject.tag == "Ammo"){
            Destroy(collider.gameObject);
            this.gameObject.GetComponent<Rigidbody>().velocity = Vector3.zero;
            this.gameObject.SetActive(false);
            GameManager.instance.addAmmo(5);
            Debug.Log(GameManager.instance.getAmmoCount());
        }
    }
}
