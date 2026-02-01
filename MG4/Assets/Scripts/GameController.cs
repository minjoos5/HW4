using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class GameController : MonoBehaviour
{
    // should be singleton
    [SerializeField] GameObject _fencePrefab;

    private float _randomY;

    void Start()
    {
        InvokeRepeating("SpawnFence", 2.0f, 3.0f);
    }

    
    private void SpawnFence()
    {
        GameObject _fence = Instantiate(_fencePrefab,transform.position, Quaternion.identity);
        _randomY = Random.Range(-1.5f, 1.5f);
        transform.position = new Vector3(transform.position.x, _randomY, transform.position.z);
    }



}
