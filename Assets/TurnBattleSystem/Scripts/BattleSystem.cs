using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// references: https://www.youtube.com/watch?v=_1pz_ohupPs parei no 21:55

public class BattleSystem : MonoBehaviour {
  public enum BattleState { START, PLAYERONETURN, PLAYERTWOTURN, WON, LOST }

  public GameObject playerOnePrefab;
  public GameObject playerTwoPrefab;

  public Transform playerOneBattleStation;
  public Transform playerTwoBattleStation;

  Unit playerOneUnit;
  Unit playerTwoUnit;

  public BattleState state;

  public bool playerOneAttack = false;

  void Start () {
    state = BattleState.START;
    StartCoroutine (SetupBatte ());
  }

  IEnumerator PlayerOneAttack () {
    playerTwoUnit.TakeDamage(PlayerOneUnit.damage);

    yield return new WaitForSeconds(2f);

    // Check if the enemy is dead
    // Change state based on what happened
  }

  void SetupBattle () {
    GameObject playerOneGO = Instantiate (playerOnePrefab, playerOneBattleStation);
    playerOneUnit = playerOneGO.GetComponent<Unit> ();

    GameObject playerTwoGO = Instantiate (playerTwoPrefab, playerTwoBattleStation);
    playerTwoUnit = playerTwoGO.GetComponent<Unit> ();

    playerOneHud.setHUD (playerOneUnit);
    playerTwoHud.setHUD (playerTwoUnit);

    yield return new WaitForSeconds (2f);

    state = BattleState.PLAYERONETURN;
    PlayerOneTurn ();

  }

  void PlayerOneTurn () {
    StartCoroutine(PlayerAttack ());
  }
}