using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PreStart : MonoBehaviour
{

    public GameObject player1;
    public GameObject player2;
    public GameObject enemy1;

    public Transform playerPos1;
    public Transform playerPos2;
    public Transform enemyPos1;


    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(enemyPos1.rotation.eulerAngles.y);
        
        Instantiate(player1, new Vector2(playerPos1.position.x, playerPos1.position.y) ,  Quaternion.Euler(0, playerPos1.rotation.eulerAngles.y,0));
        Instantiate(player2, new Vector2(playerPos2.position.x, playerPos2.position.y) , Quaternion.Euler(0, playerPos2.rotation.eulerAngles.y,0));
        Instantiate(enemy1, new Vector2(enemyPos1.position.x, enemyPos1.position.y) , Quaternion.Euler(0, enemyPos1.rotation.eulerAngles.y,0));
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
