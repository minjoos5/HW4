using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class GameController : MonoBehaviour
{
    // should be singleton
    [SerializeField] GameObject _fencePrefab;

    void Start()
    {
        InvokeRepeating("SpawnFence", 2.0f, 3.0f);
    }

    void Update()
    {
        
    }
    private void SpawnFence()
    {
        GameObject _fence = Instantiate(_fencePrefab,transform.position, Quaternion.identity);
    }



}
