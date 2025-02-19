using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiceRolling : MonoBehaviour
{
    private void RollDice()
    {
        int dice1 = Random.Range(0, 6) + 1;
        int dice2 = Random.Range(0, 6) + 1;
        int result = dice1 + dice2;
    }
}