using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RPG.Core
{
  public class PersistentObjectSpawn : MonoBehaviour
  {
    [SerializeField] GameObject persistentObjectPrefab;

    // staticはクラス自体の変数　生成したインスタンスが共通でもつ変数
    static bool hasSpawned = false;

    private void Awake()
    {
      if (hasSpawned) return;
      SpawnPersistentObjects();
      hasSpawned = true;
    }

    private void SpawnPersistentObjects()
    {
      //DontDwstroyOnLoad でシーンをまたいでもオブジェクトが破壊されない
      GameObject persistentObject = Instantiate(persistentObjectPrefab);
      DontDestroyOnLoad(persistentObject);
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