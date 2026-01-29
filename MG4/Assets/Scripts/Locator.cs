using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Locator : MonoBehaviour
{
    public static Locator Instance { get; private set; }
    public Player Player { get; private set; }

    private void Awake()
    {
        GameObject playerObj = GameObject.FindWithTag("Player");
        Player = playerObj.GetComponent<Player>();

        if (Instance != null && Instance != this)
        {
            Destroy(this.gameObject);
            return;
        }
        else
        {
            Instance = this;
        }
    }
}