using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI; //Necessary for AI navigation

public class Navigation : MonoBehaviour
{
    //Based on AI Navigation Unity tutorial - https://www.youtube.com/watch?v=u2EQtrdgfNs
    public Transform player;
    private NavMeshAgent enemy;

    // Start is called before the first frame update
    void Start()
    {
        enemy = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        enemy.destination = player.position;
    }
}
