using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fence : MonoBehaviour
{
    public float _speed = 2.0f;

    [SerializeField] private BoxCollider2D _boxCollider;

    void Update()
    {
        Vector3 _coinPos = transform.position;
        float _xPos = _coinPos.x - (_speed * Time.deltaTime);
        transform.position = new Vector3 (_xPos, _coinPos.y, _coinPos.z);

        

        if (transform.position.x < -15.0f)
        {
            Destroy(this.gameObject);
        }
    }

    

/*
(1) Pipes move to the left endlessly.
(2) Pipes have variation as to where the gap between the top and bottom pipes are placed.
and should be prefab.
*/

}
