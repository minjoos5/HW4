using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UI : MonoBehaviour
{
    [SerializeField] private TMP_Text _scoreText;

    void Start()
    {
        Locator.Instance.Player._jumpEvent += UpdateScore;
    }

    private void UpdateScore (int score)
    {
        _scoreText.text = Locator.Instance.Player._score.ToString();
    }
}
