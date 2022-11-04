using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] ParticleSystem enemyParticleSystemVFX;
    [SerializeField] ParticleSystem enemyHitVFX;
    
    [SerializeField] int hitPoints = 2;

    GameObject parentGameObject;

    ScoreBoard scoreBoard;
    int scorePerHit = 15;
    // Start is called before the first frame update
    void Start()
    {
        scoreBoard = FindObjectOfType<ScoreBoard>();
        parentGameObject = GameObject.FindWithTag("SpawnAtRuntime");
        //Add Rigidbody to Enemies using AddComponent()<>;
        //Then use gravity

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnParticleCollision(GameObject other)
    {
        
        ProcessHit();
        if(hitPoints < 1)
        {
            KillEnemy();
        }
    }
    void KillEnemy()
    {
        ParticleSystem vfx = Instantiate(enemyParticleSystemVFX, transform.position, Quaternion.identity);

        vfx.transform.parent = parentGameObject.transform;
        Destroy(gameObject);
    }
    void ProcessHit()
    {
        ParticleSystem vfx = Instantiate(enemyHitVFX, transform.position, Quaternion.identity);

        vfx.transform.parent = parentGameObject.transform;
        hitPoints -= 1;
        scoreBoard.IncreaseScore(scorePerHit);
    }

}
