using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour
{
    [SerializeField] private GameObject barrier;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider collider){
        if(collider.tag == "Player"){ //Activating/Deactivating Door
            barrier.SetActive(false);
            StartCoroutine(reactivateBarrier());
        }
    }

    IEnumerator reactivateBarrier(){
        yield return new WaitForSeconds(3f); //Reactivate barrier after 3 seconds
        barrier.SetActive(true);
    }
}
