using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPath : MonoBehaviour
{
    /*
    //transform do objetivo
    Transform goal;
    //velocidade que o tanque se move
    float speed = 5.0f;
    //distancia entre o objetivo e o tanque para que mude o objetivo
    float accuracy = 1.0f;
    //velocidade de rotação
    float rotSpeed = 2.0f;*/

    //variavel para pegar o GameObject em que esta o escript WPManager
    public GameObject wpManager;
    //lista de WayPoints
    GameObject[] wps;
    //variavel do tipo navmesh agent
    UnityEngine.AI.NavMeshAgent agent;

    /*
    //nó atual
    GameObject currentNode;
    //Waypoint atual
    int currentWP = 0;
    //variavel do grafo
    Graph g;*/
    // Start is called before the first frame update
    void Start()
    {
        //pega os WayPoints do wpManager e atribui a  variavel wps
        wps = wpManager.GetComponent<WpManager>().waypoints;
        //pega o navmeshagent e atribui a  variavel agent
        agent = this.GetComponent<UnityEngine.AI.NavMeshAgent>();

        /*
        //pega o graph do wpManager e atribui a  variavel g
        g = wpManager.GetComponent<WpManager>().graph;
        //iguala o nó atual a posição zero dowps
        currentNode = wps[0];*/
    }

    //função para ir ao heliporto
    public void GoToHeli()
    {

        agent.SetDestination(wps[1].transform.position);

        /*
        //calcula o caminho para o waypoit 1
        g.AStar(currentNode, wps[1]);
        currentWP = 0;*/
    }

    //função para ir ate as ruinas
    public void GoToRuin()
    {
        agent.SetDestination(wps[6].transform.position);

        /*
        //calcula o caminho para o waypoit 6
        g.AStar(currentNode, wps[6]);
        currentWP = 0;*/
    }

    public void GoToFactory()
    {
        agent.SetDestination(wps[4].transform.position);

        /*
        //calcula o caminho para o waypoit 5
        g.AStar(currentNode, wps[4]);
        currentWP = 0;*/
    }

    void LateUpdate()
    {
        /*
        //não fazer nada se a lista de nós for igual a zero ou se p wayPoint atrual for igual ao tamanho da lista de nós
        if (g.getPathLength() == 0 || currentWP == g.getPathLength())
            return;

        //o nó que estara mais proximo neste momento
        currentNode = g.getPathPoint(currentWP);

        //se estivermos proximos o bastante do nó o tanque se movera pra o proximo
        if (Vector3.Distance(g.getPathPoint(currentWP).transform.position, transform.position) < accuracy)
        {
            currentWP++;
        }

        //se o numero do Waypoint atual for menor que a lista
        if(currentWP<g.getPathLength())
        {
            //goal é igual a posição do WayPoint atual
            goal = g.getPathPoint(currentWP).transform;
            //posição do objetivo
            Vector3 lookAtGoal = new Vector3(goal.position.x,
                this.transform.position.y,
                goal.position.z);
            //direção entre o objetivo e o tanque
            Vector3 direction = lookAtGoal - this.transform.position;

            //faz o player rotacionar no sentido do vetor
            this.transform.rotation = Quaternion.Slerp(this.transform.rotation,
                Quaternion.LookRotation(direction),
                Time.deltaTime * rotSpeed);
                
        }

        //faz o tanque se mover
        transform.Translate(0, 0, speed * Time.deltaTime);
        */
    }
}
