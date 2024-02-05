using System.Collections;
using System.Collections.Generic;
using System.IO.Enumeration;
using UnityEngine;

[CreateAssetMenu(fileName = "PlayerData", menuName = "Player Data")]
public class PlayerData : ScriptableObject
{
    [SerializeField] private string PlayerName;
    [SerializeField] private int PlayerHealth;
}
