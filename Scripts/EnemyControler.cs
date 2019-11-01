using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyControler : MonoBehaviour
{
    // Start is called before the first frame update
    Transform player;
    UnityEngine.AI.NavMeshAgent nav;
    void Start()
    {
        
    }
    private void Awake()
    {
        player = GameObject.FindGameObjectWithTag("robotSphere").transform;
        nav = GetComponent<UnityEngine.AI.NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        nav.SetDestination(player.position);
    }
}
