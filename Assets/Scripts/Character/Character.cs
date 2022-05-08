using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Character : MonoBehaviour
{
    protected Node currentNode;

    protected bool isMoving = false;

    public void SetNode(Node node)
    {
        currentNode = node;
    }

    public bool IsMoving()
    {
        return isMoving;
    }

    public abstract void MoveTo(Node node);

    protected Node[] FindPath(Node nodeToGo)
    {
        Queue<List<Node>> queue = new Queue<List<Node>>();

        List<Node> path = new List<Node>();
        path.Add(currentNode);

        queue.Enqueue(path);

        while (queue.Count != 0)
        {
            path = queue.Dequeue();
            Node lastNode = path[path.Count - 1];

            if (lastNode == nodeToGo)
            {
                return path.ToArray();
            }

            foreach (Node n in lastNode.adyacentNodes)
            {
                List<Node> newPath = new List<Node>(path);
                newPath.Add(n);
                queue.Enqueue(newPath);
            }
        }
        return null;
    }

    protected abstract IEnumerator Move(Node[] path);
}
