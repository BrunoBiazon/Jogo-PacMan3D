using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(NavMeshAgent))]
public class scriptGhost : MonoBehaviour
{
    public Transform pc; 
    
    public Transform[] waypoints; 


    public float distanciaPerseguicao = 10f;
    public float distMin = 1.5f;


    private NavMeshAgent agente;
    private int indice = 0;
    private bool persegue = false;
    private Transform destinoAtual;

    void Start()
    {
        agente = GetComponent<NavMeshAgent>();


        if (waypoints != null && waypoints.Length > 0)
        {
            destinoAtual = waypoints[0];
            agente.SetDestination(destinoAtual.position);
        }
        else
        {
            Debug.LogWarning("Waypoints não atribuídos no scriptGhost.");
        }
    }

    void Update()
    {

        if (pc == null) return; 


        float distanciaParaPC = Vector3.Distance(transform.position, pc.position);


        if (distanciaParaPC < distanciaPerseguicao)
        {
            persegue = true;
        }

        else if (distanciaParaPC > distanciaPerseguicao * 1.5f)
        {
            persegue = false;
        }


        if (persegue)
        {
            agente.SetDestination(pc.position);
        }
        else
        {
            Patrulhar();
        }
    }

    private void Patrulhar()
    {
        if (waypoints.Length == 0) return;


        if (Vector3.Distance(transform.position, destinoAtual.position) < distMin)
        {
            Proximo();
        }
        else
        {

            agente.SetDestination(destinoAtual.position);
        }
    }

    private void Proximo()
    {


        indice = (indice + 1) % waypoints.Length;
        
        destinoAtual = waypoints[indice];
        agente.SetDestination(destinoAtual.position);
    }
}