using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
  public string name;
  public int exp = 0;
  public Character()
  {
    name = "未定義";
  }
  public Character(string name)
  {
    this.name = name;
  }

  public void PrintStatsInfo()
  {
    Debug.LogFormat("Hero: {0} - {1} EXP", name, exp);
  }
  private void Reset()
  {
    this.name = "初期化";
    this.exp = 0;
  }
}
public struct Weapon
{
  public string name;
  public int damage;
  public Weapon(string name, int damage)
  {
    this.name = name;
    this.damage = damage;
  }
  public void PrintWeaponStats()
  {
    Debug.LogFormat("Weapon: {0} - {1} DMB", name, damage);
  }
}