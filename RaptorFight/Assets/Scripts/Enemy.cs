using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{

    public enum ENEMY_STATE { Alive, Floored, Dead }
    public ENEMY_STATE EnemyState = ENEMY_STATE.Alive;

    // Start is called before the first frame update
    void Start()
    {
        // just for testing purposes
        EnemyState = ENEMY_STATE.Floored;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
