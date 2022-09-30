using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LearningCurve : MonoBehaviour
{
  // Integer variables
  private int currentAge = 30;
  public int addedAge = 1;

  public float pi = 3.14f;
  public string firstName = "Harrison";
  public bool isAuthor = true;

  // Start is called before the first frame update
  void Start()
  {
    ComputeAge();
    Character hero = new Character();
    // Debug.LogFormat("Hero: {0} - {1} EXP", hero.name, hero.exp);
    hero.PrintStatsInfo();
    Character heroine = new Character("アガサ");
        //hero.Reset();
        // Debug.LogFormat("Hero: {0} - {1} EXP", heroine.name, heroine.exp);
        heroine.PrintStatsInfo();
    Weapon huntingBow = new Weapon("Hunting Bow", 105);
    Paladin knight = new Paladin("アーサー卿", huntingBow);
    knight.PrintStatsInfo();
  }

  // Update is called once per frame
  void Update()
  {
        
  }

  /// <summary>
  /// Computes a modified age integer
  /// </summary>
  void ComputeAge()
  {
    Debug.Log(currentAge + addedAge);
  }
}