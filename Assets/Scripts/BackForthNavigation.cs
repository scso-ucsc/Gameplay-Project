using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class BackForthNavigation : MonoBehaviour
{
    [SerializeField] Transform wall1;
    [SerializeField] Transform wall2;
    private NavMeshAgent enemy;
    [SerializeField] private string direction;

    // Start is called before the first frame update
    void Start()
    {
        enemy = GetComponent<NavMeshAgent>();
        StartCoroutine(switchDirection());
    }

    // Update is called once per frame
    void Update()
    {
        if(direction == "right"){
            enemy.destination = wall2.position;
        } else{
            enemy.destination = wall1.position;
        }
    }

    IEnumerator switchDirection(){
        while(true){
            yield return new WaitForSeconds(3.5f); //Switch direction every 4 seconds
            if(direction == "right"){
                direction = "left";
            } else{ //direction == "left"
                direction = "right";
            }
        }
    }
}
