using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public delegate void IntDelegate (int value);
    public event IntDelegate _jumpEvent;
    [SerializeField] private Rigidbody2D _rb;

    [SerializeField] private CapsuleCollider2D _collider;

    [SerializeField] private AudioSource _audio;

    public float _jump = 5.0f;

    public int _score = 0;


    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
        _collider = GetComponent<CapsuleCollider2D>();
        _audio = GetComponent<AudioSource>();
    }

    void Update()
    {
        Jump();

    
    /*(3) The player can flap with SPACE, which:
    makes the player pop upwards, but gravity pulls them down.
    plays a sound. */
    }

    private void Jump()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            _rb.velocity = new Vector2(_rb.velocity.x, _jump);
            _audio.Play();
        }

    }
    /*(4) The player loses if they collide with a pipe, which:
    plays a sound.
    stops the game.
    */
}
