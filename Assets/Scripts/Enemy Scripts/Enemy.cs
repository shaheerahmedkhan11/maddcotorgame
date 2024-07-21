using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private Transform playerTarget;

    [SerializeField]
    private float moveSpeed = 2f;
    private Vector3 tempScale;

    [SerializeField]
    private float stoppingDistance = 1.5f;
    private PlayerAnimation enemyAnimation;

    private void Awake()
    {
        Debug.Log("The Awake function is being called!");
        playerTarget = GameObject.FindWithTag(TagManager.PLAYER_TAG).transform;
        enemyAnimation = GetComponent<PlayerAnimation>();
        if (playerTarget == null)
        {
            Debug.LogError("Player target not found! Make sure the player has the correct tag.");
        }
        if (enemyAnimation == null)
        {
            Debug.LogError("PlayerAnimation component not found! Make sure the enemy has a PlayerAnimation component.");
        }
    }
    private void Start()
    {
        Debug.Log("Enemy script Start called");
    }

    private void Update()
    {
        Debug.Log("Enemy script Update called");
        SearchForPlayer();
    }
    void SearchForPlayer()
    {
        if (!playerTarget)
            return;
        float distanceToPlayer = Vector3.Distance(transform.position, playerTarget.position);
        if (distanceToPlayer > stoppingDistance)
        {
            Debug.Log("Distance to player: " + distanceToPlayer);

            transform.position = Vector2.MoveTowards(transform.position, playerTarget.position, moveSpeed * Time.deltaTime);
            Debug.Log("Moving towards player, playing walk animation: " + TagManager.WALK_ANIMATION_NAME);
            enemyAnimation.PlayAnimation(TagManager.WALK_ANIMATION_NAME);
        }
        


    }
}
