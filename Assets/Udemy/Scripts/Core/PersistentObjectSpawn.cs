using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RPG.Core
{
  public class PersistentObjectSpawn : MonoBehaviour
  {
    [SerializeField] GameObject persistentObjectPrefab;

    // static�̓N���X���̂̕ϐ��@���������C���X�^���X�����ʂł��ϐ�
    static bool hasSpawned = false;

    private void Awake()
    {
      if (hasSpawned) return;
      SpawnPersistentObjects();
      hasSpawned = true;
    }

    private void SpawnPersistentObjects()
    {
      //DontDwstroyOnLoad �ŃV�[�����܂����ł��I�u�W�F�N�g���j�󂳂�Ȃ�
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