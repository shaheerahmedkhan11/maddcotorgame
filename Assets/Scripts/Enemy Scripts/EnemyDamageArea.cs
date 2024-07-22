using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDamageArea : MonoBehaviour
{
    [SerializeField]
    private float deactivateWaitTime = 0.1f;
    private float deactivateTimer;
    [SerializeField]
    private LayerMask playerLayer;

    private void Update()
    {
        if(Physics2D.OverlapCircle(transform.position,1f,playerLayer))
        {
            Debug.Log("Damage dealt to player");
        }
    }


}
