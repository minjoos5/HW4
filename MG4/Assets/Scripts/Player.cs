using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Player : MonoBehaviour
{
    public delegate void IntDelegate (int value);
    public event IntDelegate _jumpEvent;
    [SerializeField] private Rigidbody2D _rb;

    [SerializeField] private CapsuleCollider2D _collider;

    [SerializeField] private AudioSource _jumpAudio;

    [SerializeField] private AudioSource _deathAudio;

    public float _jump = 5.0f;

    public int _score = 0;


    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
        _collider = GetComponent<CapsuleCollider2D>();
        _jumpAudio = GetComponent<AudioSource>();
        _deathAudio = GetComponent<AudioSource>();
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
            _jumpAudio.Play();
        }
        _jumpEvent?.Invoke(_score);
    }
    /*(4) The player loses if they collide with a pipe, which:
    plays a sound.
    stops the game.
    */

    void OnTriggerEnter2D(Collider2D collision)
    {
        string tag = collision.gameObject.tag;
        if (tag.Equals("Detector"))
        {
            _score ++;
        }
            
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        string tag = collision.gameObject.tag;
        if (tag.Equals("Fence"))
        {
            _deathAudio.Play();
            
        }
    }
}
