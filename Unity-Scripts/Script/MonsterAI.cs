using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterAI : MonoBehaviour
{
    public GameObject thePlayer;
    public GameObject theEnemy;
    public float enemySpeed = 0.014f;
    public bool attacktrigger = false;
    public bool isAttacking = false;
    

    void Update()
    {
        transform.LookAt(thePlayer.transform);
        if (attacktrigger == false)
        {
            enemySpeed = 0.014f;
            theEnemy.GetComponent<Animation>().Play("MonsterWalk");
            transform.position = Vector3.MoveTowards(transform.position, thePlayer.transform.position, enemySpeed);
        }
        if (attacktrigger == true && isAttacking == false)
        {
            enemySpeed = 0;
            theEnemy.GetComponent<Animation>().Play("MonsterAttack");
            StartCoroutine(InflictDamage()); 
        }

    }
    void OnTriggerEnter()
    {
        attacktrigger = true;
    }
    void OnTriggerExit()
    {
        attacktrigger = false;
    }
    IEnumerator InflictDamage()
    {
        isAttacking = true;
        yield return new WaitForSeconds(0.8f);
        GlobalHealth.currentHealth = -1;
        yield return new WaitForSeconds(0.2f);
        isAttacking = false;

    }
}
