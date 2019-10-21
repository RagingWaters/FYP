using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class enemyController : MonoBehaviour
{

    public float lookRadius = 10f;

    public Transform target;
   
    
    NavMeshAgent agent;
    //public GameObject decoyTarget;


    // Start is called before the first frame update
    void Start()
    {
        //GameObject.FindGameObjectWithTag("Player"); -too manual and troublesome

        target = PlayerControls.instance.transform;
        agent = GetComponent<NavMeshAgent>();
        
        
    }

    // Update is called once per frame
    void Update()
    {
        float distance = Vector3.Distance(target.position, transform.position); //check radius

        if (distance <= lookRadius)
        {
            agent.SetDestination(target.position);
            if (distance <= agent.stoppingDistance)
            {
                //Add attack target
                FaceTarget();
                //print("ter");
            }
            
        }

        else
        {
            agent.ResetPath();
        }
        if (enemySpawner.startSpawn == false) Destroy(gameObject);
        //print(agent.destination);
    }

    void FaceTarget ()
    {
        Vector3 direction = (target.position - transform.position).normalized;
        Quaternion lookRotation = Quaternion.LookRotation(new Vector3(direction.x, 0, direction.z));
        transform.rotation = Quaternion.Slerp(transform.rotation, lookRotation, Time.deltaTime * 5f);
        // lookRotation; (slerp smoother)
        Debug.DrawRay(transform.position, direction, Color.green);

    }

    private void OnDrawGizmosSelected() //radius
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, lookRadius);
    }
    
   

}
