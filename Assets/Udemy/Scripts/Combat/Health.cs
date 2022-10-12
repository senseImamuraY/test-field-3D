using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RPG.Combat
{
  public class Health : MonoBehaviour
  {
    [SerializeField] float health = 100f;

    public void TakeDamage(float damage)
    {
      health = Mathf.Max(health - damage, 0);
      print(health);
    }
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
  }

}