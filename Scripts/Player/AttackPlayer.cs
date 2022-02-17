using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackPlayer : MonoBehaviour
{

    public Sprite fogo;
    float horizontal;
    float vertical;
    public Transform attackPointPos;
    public float attackRange = 0.5f;
    public LayerMask enemyLayer;
    public int dano = 1;
    public GameObject attackPoint;

    public float attackSpeed = 2f;
    float nextAttackTime = 0f;
    // Update is called once per frame
    void Update()
    {

        horizontal = Input.GetAxisRaw("Horizontal");
        vertical = Input.GetAxisRaw("Vertical");
        if (Time.time>= nextAttackTime)
        {
            if (Input.GetKeyDown(KeyCode.Mouse0))
            {
                Attack();
                

                nextAttackTime = Time.time + 1f / attackSpeed;

                
            }
        }

        

        
        if (vertical==-1)
        {
            attackPoint.transform.localPosition = new Vector2(0, -1);
        }

        else if (vertical == 1)
        {
            attackPoint.transform.localPosition = new Vector2(0, 1);
        }

        else if (horizontal == 1)
        {
            attackPoint.transform.localPosition = new Vector2(1, 0);
        }

        else if (horizontal == -1)
        {
            attackPoint.transform.localPosition = new Vector2(-1, 0);
        }
    }

    void Attack(){
        
        //todos os inimigos atingidos pelo collider de attaque sao adicionados a um array
        Collider2D[] hitEnemies =  Physics2D.OverlapCircleAll(attackPointPos.position, attackRange,enemyLayer);
        this.gameObject.GetComponent<SpriteRenderer>().sprite = fogo;
        foreach(Collider2D enemy in hitEnemies){
            enemy.GetComponent<Inimigos>().TakeDamage(dano);
            Debug.Log("no");
        }
        
        Debug.Log("Yes");



        


    }

}
