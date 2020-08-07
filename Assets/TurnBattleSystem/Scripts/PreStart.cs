using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PreStart : MonoBehaviour
{

    public Transform playerPos1;
    public Transform playerPos2;
    public Transform enemyPos1;
    public GameObject[] playerCustom;
    public GameObject[] enemyCustom;


    public int numPlayers;
    public int numEnemies;

    //preciso puxar um player ramdom
    // Start is called before the first frame update
    void Start()
    {
      
        InstantiateChars();
        
    }

    // Update is called once per frame
    void Update()
    {
           
    }

    public void InstantiateChars() {
         int numPlayersArray = 0;
         int numEnemiesArray = 0;
            int numPCount = 1;
            int numECount = 1;

        while(numEnemies > 0){
          GameObject enemyCustomPos = GameObject.FindGameObjectWithTag("enemyPos"+ numECount);

          Instantiate(enemyCustom[numEnemiesArray], new Vector2(enemyCustomPos.transform.position.x, enemyCustomPos.transform.position.y) ,  Quaternion.Euler(0, enemyCustomPos.transform.rotation.eulerAngles.y,0));
          numECount++;
          numEnemiesArray++;
          numEnemies--;
        }

        while(numPlayers > 0){
          GameObject playerCustomPos = GameObject.FindGameObjectWithTag("playerPos"+ numPCount);

          Instantiate(playerCustom[numPlayersArray], new Vector2(playerCustomPos.transform.position.x, playerCustomPos.transform.position.y) ,  Quaternion.Euler(0, playerCustomPos.transform.rotation.eulerAngles.y,0));
          numPCount++;
          numPlayersArray++;
          numPlayers--;
        }

    }
}
