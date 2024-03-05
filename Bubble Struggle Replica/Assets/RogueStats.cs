using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RogueStats : MonoBehaviour
{
    [Header("Player")]
    public float playerSpeed;
    public int playerLifeRegen;
    public int startingLives;

    [Header("Chain")]
    public float chainSpeed = 2;
    public int chainDamage = 1;
    public float chainCritChance = 0.0f;
    public int maxChainShots = 1;
    public int chainPierceAmount = 0;
    public bool chainSticksToTop = false;
    public int chainStickTime = 1;
    public int chainSplitAmount = 0;
    public float chainThickness = 1;

    public float coinDropOdds = .10f;

    [Header("Economy")]
    public int maxInterest = 20;
    [Tooltip("In Balatro worded as -- 1 coin per X up to 25-- X is this value")]
    public int coinValueForInterestCoin = 5;

    [Header("Timer")]
    public int TimerExtension = 0;
    public float ExtraTimePercent = 0.0f;
    public int coinPerSecondRemaining = 0;
}
