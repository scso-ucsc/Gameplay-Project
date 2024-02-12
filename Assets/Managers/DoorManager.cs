using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorManager : MonoBehaviour
{
    public static DoorManager instance;
    [SerializeField] private GameObject door1;
    [SerializeField] private GameObject door2;
    [SerializeField] private GameObject door3;
    [SerializeField] private GameObject door4;
    [SerializeField] private GameObject playerAmmoSourcePrefab;
    [SerializeField] private Transform ammoParent;
    [SerializeField] private Transform spawnpoint1;
    [SerializeField] private Transform spawnpoint2;
    [SerializeField] private Transform spawnpoint3;
    [SerializeField] private Transform spawnpoint4;

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
        door1.SetActive(true);
        door2.SetActive(true);
        door3.SetActive(true);
        door4.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        if(GameManager.instance.getPlayerScore() >= 150 && door1.activeSelf){
            door1.SetActive(false);
            if(GameManager.instance.getAmmoCount() <= 5){ //Spawning extra free ammo if ammo count is below 5
                GameObject extraAmmo = Instantiate(playerAmmoSourcePrefab, spawnpoint1.position, Quaternion.Euler(0, 0, 0), ammoParent);
            }
        }
        if(GameManager.instance.getPlayerScore() >= 400 && door2.activeSelf){
            door2.SetActive(false);
            if(GameManager.instance.getAmmoCount() <= 5){ //Spawning extra free ammo if ammo count is below 5
                GameObject extraAmmo = Instantiate(playerAmmoSourcePrefab, spawnpoint2.position, Quaternion.Euler(0, 0, 0), ammoParent);
            }
        }
        if(GameManager.instance.getPlayerScore() >= 650 && door3.activeSelf){
            door3.SetActive(false);
            if(GameManager.instance.getAmmoCount() <= 5){ //Spawning extra free ammo if ammo count is below 5
                GameObject extraAmmo = Instantiate(playerAmmoSourcePrefab, spawnpoint3.position, Quaternion.Euler(0, 0, 0), ammoParent);
            }
        }
        if(GameManager.instance.getPlayerScore() >= 800 && door4.activeSelf){
            door4.SetActive(false);
            if(GameManager.instance.getAmmoCount() <= 5){ //Spawning extra free ammo if ammo count is below 5
                GameObject extraAmmo = Instantiate(playerAmmoSourcePrefab, spawnpoint4.position, Quaternion.Euler(0, 0, 0), ammoParent);
            }
        }
    }
}
