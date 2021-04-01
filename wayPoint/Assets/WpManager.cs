using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//faz aparecer no inspector
[System.Serializable]
public struct link
{
    //direção do tanque
    public enum direction { UNI, BI }
    //nó  1 e nó 2
    public GameObject node1;
    public GameObject node2;
    //direção
    public direction dir;
}

public class WpManager : MonoBehaviour
{
    //array de waypoints
    public GameObject[] waypoints;
    //array de links
    public link[] links;
    //graph
    public Graph graph = new Graph();

     void Start()
    {
        //se a lista de waypoints for maior que zero
        if (waypoints.Length > 0)
        {
            //para cada GameObject wp cria um nó
            foreach (GameObject wp in waypoints)
            {
                graph.AddNode(wp);
            }
            //para cada link i cria node de ida se for bi cria de ida e de volta
            foreach(link i in links)
            {
                graph.AddEdge(i.node1, i.node2);
                if (i.dir == link.direction.BI)
                    graph.AddEdge(i.node2, i.node1);
            }
        }

    }

    void Update()
    {
        //desenhos os grafos na tela
        graph.debugDraw();
    }

}
