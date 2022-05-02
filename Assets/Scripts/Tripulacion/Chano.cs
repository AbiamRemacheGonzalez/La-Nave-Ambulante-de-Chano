using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chano : Character
{
    private Stats stats;
    public Animator anim;
    public GameObject lifeBarObject;
    protected int maxLife = 10;
    protected int life = 10;

    private LifeBarController lifeBar;

    void Start()
    {
        lifeBar = lifeBarObject.GetComponent<LifeBarController>();
        lifeBar.SetValuesTo(maxLife);
        lifeBarObject.SetActive(false);
    }

    public void SetLife(int newLifeValue)
    {
        life = (newLifeValue > maxLife) ? maxLife : (newLifeValue < 0) ? 0 : newLifeValue;
        if (life < maxLife) {
            lifeBarObject.SetActive(true);
        }
        else
        {
            lifeBarObject.SetActive(false);
        }
        lifeBar.SetLife(life);
        if (life <= 0) Die();
    }

    public int GetLife()
    {
        return life;
    }

    public void Die()
    {
        Destroy(gameObject);
    }

    public override void MoveTo(Node node)
    {
        Node[] path = FindPath(node);

        if(!isMoving)
            StartCoroutine(Move(path));
    }

    public void SetStats(Stats stats)
    {
        this.stats = stats;
    }

    public Stats GetStats()
    {
        return stats;
    }

    protected override IEnumerator Move(Node[] path)
    {
        isMoving = true;
        anim.SetBool("isMoving", isMoving);
        currentNode.SetOccupied(false);
        foreach (Node n in path)
        {
            currentNode = n;
            while (transform.position != n.transform.position)
            {
                float step = stats.GetSpeed() * Time.deltaTime;
                transform.position = Vector3.MoveTowards(transform.position, n.transform.position, step);
                yield return new WaitForEndOfFrame();
            }
            yield return new WaitForEndOfFrame();
        }
        currentNode.SetOccupied(true);
        isMoving = false;
        anim.SetBool("isMoving", isMoving);
        StartCoroutine(CheckTask());
    }

    private IEnumerator CheckTask()
    {
        Tarea tarea = currentNode.GetTarea();
        if (tarea != null) {
            tarea.DoTask(this);
            //subir estadistica
        }
        yield return new WaitForEndOfFrame();
    }
}
