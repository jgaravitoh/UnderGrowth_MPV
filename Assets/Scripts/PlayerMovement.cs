using UnityEngine;
using UnityEngine.AI;

public class PlayerMovement: MonoBehaviour
{
    [SerializeField] Transform target;

    public float velocidad = 5f;
    // This code sucks ass XD, we need to better it.
    void Update()
    {
        //RayCasting
        if(Input.GetMouseButtonDown(0))
        {
            MoveToCursor();
        }
    }
            //movement
    private void MoveToCursor()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        bool hasHit = Physics.Raycast(ray, out hit);
        if (hasHit)
        {
            GetComponent<NavMeshAgent>().destination = hit.point;
        }
    }
}
