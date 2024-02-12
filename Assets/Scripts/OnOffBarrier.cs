using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnOffBarrier : MonoBehaviour
{
    [SerializeField] private GameObject onOffBarrier;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(OnOffBarrierSwitch());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator OnOffBarrierSwitch(){
        while(true){
            yield return new WaitForSeconds(2f); //Activate/Deactivate barrier every 2 seconds
            if(onOffBarrier.activeSelf){
                onOffBarrier.SetActive(false);
            } else{
                onOffBarrier.SetActive(true);
            }
        }
    }
}
